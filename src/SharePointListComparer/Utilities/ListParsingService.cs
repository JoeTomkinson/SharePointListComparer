using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;
using SharePointListComparer.Models;

namespace SharePointListComparer.Utilities
{
    public class LocalListParsingService
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public LocalListParsingService()
        {
            //
        }

        public SharePointListStructure ParseSPTFile(string filepath)
        {
            var fullXMLString = File.ReadAllText(filepath);

            string xmlString = string.Empty;

            // remove <Data></Data> node
            var readString = fullXMLString;
            string dataPattern = "<Data>[\\s\\S]*?<\\/Data>";
            Regex dataRegex = new Regex(
                dataPattern,
                RegexOptions.IgnoreCase |
                RegexOptions.CultureInvariant |
                RegexOptions.IgnorePatternWhitespace |
                RegexOptions.Compiled);

            Match match = dataRegex.Match(readString);
            if (match.Success)
            {
                xmlString = Regex.Replace(readString, dataPattern, string.Empty);
            }

            // see if we can deserialise it as is into our template
            var template = new ListTemplate();
            XmlDocument doc = new XmlDocument();
            bool attemptManual = false;
            try
            {

                doc.LoadXml(xmlString);
                using (TextReader reader = new StringReader(doc.OuterXml))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ListTemplate));
                    template = (ListTemplate)serializer.Deserialize(reader);
                    reader.Close();
                }
            }
            catch
            {
                attemptManual = true;
            }

            // we failed to parse the XML into an object, so let's try to manually extract the data we need
            if (attemptManual)
            {
                template = ManualXMLParse(fullXMLString, doc, template);
            }

            if (template == null)
            {
                // if we are null here we need to abort this parsing.
                string value = null;
                var groups = Regex.Match(fullXMLString, "(?<=TemplateTitle>).*(?=</TemplateTitle>)").Groups;
                if (groups != null && groups?.Count > 0)
                {
                    value = groups[0].Value;
                }

                return new SharePointListStructure
                {
                    ListName = value ?? "No List Name could be retrieved from XML",
                    ColumnDefinitions = null,
                    ListPhysicalPath = filepath,
                    LocalList = true,
                    FullXMLSchema = fullXMLString,
                };
            }

            try
            {
                var sharePointListStructure = new SharePointListStructure
                {
                    ListName = template.Details.TemplateTitle,
                    ColumnDefinitions = new List<ColumnDefinition>(),
                    ViewDefinitions = new List<SharePointListView>(),
                    LocalList = true,
                    ListPhysicalPath = filepath,
                    FullXMLSchema = fullXMLString,
                };

                foreach (var field in template.UserLists.List.MetaData.Fields)
                {

                    var columnDefinition = new ColumnDefinition
                    {
                        ColumnType = field.Type,
                        DisplayName = field.DisplayName,
                        Name = field.Name,
                        Required = field.Required,
                        StaticName = field.StaticName
                    };
                    sharePointListStructure.ColumnDefinitions.Add(columnDefinition);
                }

                if (template.UserLists.List.MetaData.Views != null)
                {
                    foreach (var view in template.UserLists.List.MetaData.Views)
                    {
                        var splv = new SharePointListView()
                        {
                            ViewDisplayName = view.DisplayName
                        };
                        splv.ViewFieldRefs = new List<string>();

                        if (view.Items[0] is ListTemplateUserListsListMetaDataViewViewFields viewFields)
                        {
                            foreach (var item in viewFields.FieldRef)
                            {
                                splv.ViewFieldRefs.Add(item.Name);
                            }
                        }
                        sharePointListStructure.ViewDefinitions.Add(splv);
                    }
                }

                return sharePointListStructure;
            }
            catch (Exception)
            {
                string value = null;
                var groups = Regex.Match(fullXMLString, "(?<=TemplateTitle>).*(?=</TemplateTitle>)").Groups;
                if (groups != null && groups?.Count > 0)
                {
                    value = groups[0].Value;
                }

                return new SharePointListStructure
                {
                    ListName = value ?? "No List Name could be retrieved from XML",
                    ColumnDefinitions = null,
                    FullXMLSchema = fullXMLString,
                };
            }
        }

        private ListTemplate ManualXMLParse(string rawXMLString, XmlDocument doc, ListTemplate template)
        {
            // we could not deserialise it so let's try a different more manual approach.
            // initialise our required fields.
            template = new ListTemplate()
            {
                Details = new ListTemplateDetails()
                {
                    TemplateTitle = string.Empty
                },
                UserLists = new ListTemplateUserLists
                {
                    List = new ListTemplateUserListsList()
                    {
                        MetaData = new ListTemplateUserListsListMetaData
                        {
                            Fields = new ListTemplateUserListsListMetaDataField[0],
                            Views = new ListTemplateUserListsListMetaDataView[0]
                        }
                    }
                }
            };

            if (doc == null || string.IsNullOrEmpty(doc?.OuterXml))
            {
                // lets try and prettify the xml ready for Regexing
                string prettyXML = PrintXML(rawXMLString);

                // If the document is null then we need to do this manually
                string value = null;
                var groups = Regex.Match(rawXMLString, "(?<=TemplateTitle>).*(?=</TemplateTitle>)").Groups;
                if (groups != null && groups?.Count > 0)
                {
                    value = groups[0].Value;
                }
                template.Details.TemplateTitle = value ?? "No List Name could be retrieved from XML";

                // get our metadata tag
                var metadataSubstring = Regex.Match(prettyXML, "(?<=<MetaData>).*(?=</MetaData>)", RegexOptions.Singleline).Value;

                // get our field data
                template.UserLists.List.MetaData.Fields = FieldsRegexParse(metadataSubstring);

                // get our views data
                template.UserLists.List.MetaData.Views = ViewsRegexParse(metadataSubstring);
            }
            else
            {
                // It loaded into an xml document so structure is ok, let's get the node we need.

                XmlNodeList nodes = doc.GetElementsByTagName("TemplateTitle");
                foreach (XmlNode node in nodes)
                {
                    if (node.Name == "TemplateTitle")
                    {
                        template.Details.TemplateTitle = node.InnerText;
                    }
                }
                // get our fields
                template.UserLists.List.MetaData.Fields = FieldsNodeParse(doc);

                // get our views data
                template.UserLists.List.MetaData.Views = ViewsNodeParse(doc);
            }
            return template;
        }

        private ListTemplateUserListsListMetaDataField[] FieldsNodeParse(XmlDocument doc)
        {
            try
            {
                // lets try and get the field nodes:
                XmlNodeList fieldNodes = doc.SelectNodes(@"/ListTemplate/UserLists/List/MetaData/Fields/Field");
                List<ListTemplateUserListsListMetaDataField> fields = new List<ListTemplateUserListsListMetaDataField>();
                foreach (XmlNode node in fieldNodes)
                {
                    if (node.Name == "Field")
                    {
                        fields.Add(new ListTemplateUserListsListMetaDataField()
                        {
                            Name = node.Attributes["Name"].Value,
                            DisplayName = node.Attributes["DisplayName"].Value,
                            StaticName = node.Attributes["StaticName"].Value,
                            Required = node.Attributes["Required"]?.Value ?? "false",
                            Type = node.Attributes["Type"].Value
                        });
                    }
                }
                return fields.ToArray();
            }
            catch
            {
                return null;
            }
        }

        private ListTemplateUserListsListMetaDataView[] ViewsNodeParse(XmlDocument doc)
        {
            try
            {
                // lets try and get the field nodes:
                XmlNodeList viewNodes = doc.SelectNodes(@"/ListTemplate/UserLists/List/MetaData/Views/View");
                List<ListTemplateUserListsListMetaDataView> views = new List<ListTemplateUserListsListMetaDataView>();
                foreach (XmlNode node in viewNodes)
                {
                    if (node.Name == "View")
                    {
                        var childNode = node.SelectNodes(@"ViewFields");
                        var fieldNodes = childNode[0].SelectNodes(@"FieldRef");

                        var fieldRefList = new List<ListTemplateUserListsListMetaDataViewViewFieldsFieldRef>();

                        foreach (XmlNode field in fieldNodes)
                        {
                            var fieldRef = new ListTemplateUserListsListMetaDataViewViewFieldsFieldRef
                            {
                                Name = field.Attributes["Name"].Value
                            };
                            fieldRefList.Add(fieldRef);
                        }

                        views.Add(new ListTemplateUserListsListMetaDataView()
                        {
                            Name = node.Attributes["Name"].Value,
                            DisplayName = node.Attributes["DisplayName"].Value,
                            Type = node.Attributes["Type"].Value,
                            Items = fieldRefList.ToArray()
                        });
                    }
                }
                return views.ToArray();
            }
            catch
            {
                return null;
            }
        }

        private ListTemplateUserListsListMetaDataField[] FieldsRegexParse(string metadataSubstring)
        {
            // populate our field data
            List<ListTemplateUserListsListMetaDataField> fields = new List<ListTemplateUserListsListMetaDataField>();

            var fieldsSubstring = Regex.Match(metadataSubstring, "(?<=<Fields>).*(?=</Fields>)", RegexOptions.Singleline).Value;
            var fieldGroups = Regex.Matches(fieldsSubstring, "<Field .*[>]", RegexOptions.Multiline |
                RegexOptions.IgnorePatternWhitespace);

            if (fieldGroups != null && fieldGroups?.Count > 0)
            {
                foreach (Match field in fieldGroups)
                {
                    // extract our attributes here.
                    var name = string.Empty;
                    var displayName = string.Empty;
                    var staticName = string.Empty;
                    var required = string.Empty;
                    var type = string.Empty;

                    try
                    {
                        name = Regex.Match(field.Value, "(?<=Name=\").?([^\"]*)").Value;
                        displayName = Regex.Match(field.Value, "(?<=DisplayName=\").?([^\"]*)").Value;
                        staticName = Regex.Match(field.Value, "(?<=StaticName=\").?([^\"]*)").Value;
                        required = Regex.Match(field.Value, "(?<=Required=\").?([^\"]*)").Value;
                        type = Regex.Match(field.Value, "(?<=Type=\").?([^\"]*)").Value;
                    }
                    catch
                    {
                        break;
                    }

                    // quick check to see if required is empty and to set a default value of false if it is.
                    required = string.IsNullOrEmpty(required) ? "false" : required;

                    // populate field object with these attributes
                    fields.Add(new ListTemplateUserListsListMetaDataField()
                    {
                        Name = name,
                        DisplayName = displayName,
                        StaticName = staticName,
                        Required = required,
                        Type = type
                    });
                }
            }
            return fields.ToArray();
        }

        private ListTemplateUserListsListMetaDataView[] ViewsRegexParse(string metadataSubstring)
        {
            var viewsSubstring = Regex.Match(metadataSubstring, "(?<=<Views>).*(?=</Views>)", RegexOptions.Singleline).Value;
            var viewSubstring = Regex.Matches(viewsSubstring, "(?<=<View ).*(?=</View>)", RegexOptions.Singleline);
            //initialise required objects
            List<ListTemplateUserListsListMetaDataView> Views = new List<ListTemplateUserListsListMetaDataView>();
            ListTemplateUserListsListMetaDataView view = new ListTemplateUserListsListMetaDataView
            {
                Items = new ListTemplateUserListsListMetaDataViewViewFields[0],
            };

            var viewItems = new List<ListTemplateUserListsListMetaDataViewViewFields>();

            foreach (Match match in viewSubstring)
            {

                var viewitem = new ListTemplateUserListsListMetaDataViewViewFields();

                var viewName = Regex.Match(match.Value, "(?<=DisplayName=\").?([^\"]*)").Value;

                // narrow down to our view fields.
                var viewFields = Regex.Match(match.Value, "(?<=<ViewFields>).*(?=</ViewFields>)", RegexOptions.Singleline).Value;

                // get our fieldRefs
                var fieldRefGroups = Regex.Matches(viewFields, "<FieldRef\\b.*[>]", RegexOptions.Singleline |
                    RegexOptions.IgnorePatternWhitespace);

                var fieldRefList = new List<ListTemplateUserListsListMetaDataViewViewFieldsFieldRef>();

                foreach (Match field in fieldRefGroups)
                {
                    var fieldRef = new ListTemplateUserListsListMetaDataViewViewFieldsFieldRef
                    {
                        Name = field.Value
                    };
                    fieldRefList.Add(fieldRef);
                }

                viewitem.FieldRef = fieldRefList.ToArray();
                viewItems.Add(viewitem);
                view.Items = viewItems.ToArray();
                view.DisplayName = viewName;
                Views.Add(view);
            }
            return Views.ToArray();
        }

        public string PrintXML(string xml)
        {
            string result = "";

            MemoryStream mStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(mStream, Encoding.Unicode);
            XmlDocument document = new XmlDocument();

            try
            {
                // Load the XmlDocument with the XML.
                document.LoadXml(xml);

                writer.Formatting = Formatting.Indented;

                // Write the XML into a formatting XmlTextWriter
                document.WriteContentTo(writer);
                writer.Flush();
                mStream.Flush();

                // Have to rewind the MemoryStream in order to read
                // its contents.
                mStream.Position = 0;

                // Read MemoryStream contents into a StreamReader.
                StreamReader sReader = new StreamReader(mStream);

                // Extract the text from the StreamReader.
                string formattedXml = sReader.ReadToEnd();

                result = formattedXml;
            }
            catch (XmlException)
            {
                // Handle the exception
            }

            mStream.Close();
            writer.Close();

            return result;
        }
    }
}