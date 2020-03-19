using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security;
using System.Threading.Tasks;
using SharePointListComparer.SharePoint.Abstract;
using SharePointListComparer.Models;

namespace SharePointListComparer.SharePoint.Service
{
    /// <summary>
    /// SharePoint Online service used to handle data interactions with SharePoint Online lists.
    /// </summary>
    public class SharePointDataService : DataServiceAbstract
    {
        private readonly Web web;
        private readonly ListCollection lists;
        private readonly ClientContext clientContext;
        private readonly string _siteURL;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="siteUrl"></param>
        public SharePointDataService(string username, string password, string siteUrl, bool isOnline) : base()
        {
            _siteURL = string.IsNullOrEmpty(siteUrl) ? throw new ArgumentNullException("SharePointService - Site URL Missing") : siteUrl;
            clientContext = new ClientContext(_siteURL);


            if (isOnline)
            {
                // create password as securestring
                SecureString spSecurePassword = new SecureString();
                foreach (char c in password.ToCharArray()) spSecurePassword.AppendChar(c);

                // SharePoint Online
                clientContext.Credentials = new SharePointOnlineCredentials(username, spSecurePassword);
            }
            else
            {
                // onPrem SharePoint
                clientContext.Credentials = new NetworkCredential(username, password);
            }

            try
            {
                // The SharePoint web at the URL.
                web = clientContext.Web;

                // Retrieve all lists from the server. 
                clientContext.Load(web.Lists, lists => lists.Include(list => list.Title, list => list.Id));
            }
            catch (Exception genEx)
            {
                throw new Exception("Failed at constructor load action for lists.", genEx);
            }

            try
            {
                // Execute query. 
                clientContext.ExecuteQuery();
            }
            catch (Exception genEx)
            {
                throw new Exception("Failed at constructor execute query for SharePoint Client Context.", genEx);
            }

            // Store the web lists. : 'Failed at constructor execute query for SharePoint Client Context
            lists = web?.Lists;
        }

        public override object CreateLists(object lists)
        {
            if (lists is List<SharePointListStructure> spLists)
            {
                foreach (var list in spLists)
                {
                    bool templateUploaded = UploadTemplateToSharePoint(list);
                    bool listCreated = false;
                    if (templateUploaded)
                    {
                        listCreated = CreateListFromTemplate(list);
                    }
                }

                return null;
            }
            else
            {
                return new ArgumentException($"Did not receive expected class type of {nameof(List<SharePointListStructure>)}");
            }
        }

        public override object GetAllLists()
        {
            clientContext.Load(web.Lists, lists => lists.Include(list => list.Title, list => list.Id));

            // Execute query. 
            clientContext.ExecuteQuery();

            return lists;
        }

        public override object LoadListItems(object list)
        {
            if (list is List spList)
            {
                clientContext.Load(spList.Views);
                clientContext.Load(spList.Fields);
                // We must call ExecuteQuery before enumerate list.Fields.
                clientContext.ExecuteQuery();

                // right now we need the view fields as well :/
                foreach (var view in spList.Views)
                {
                    clientContext.Load(view.ViewFields);
                }

                // Call ExecuteQuery again
                clientContext.ExecuteQuery();

                return spList;
            }
            return list;
        }

        private bool UploadTemplateToSharePoint(SharePointListStructure list)
        {
            var featureID = Guid.NewGuid();

            // Get the List template Gallery Folder
            var listTemplateGallery = web.Lists.GetByTitle("List Template Gallery");
            var listFolder = listTemplateGallery.RootFolder;
            FileCreationInformation fileCreationInformation = new FileCreationInformation
            {
                Content = System.IO.File.ReadAllBytes(list.ListPhysicalPath),
                Overwrite = true,
                Url = "_catalogs/lt/" + list.ListName + ".stp",
            };

            var file = listFolder.Files.Add(fileCreationInformation);
            file.Update();
            clientContext.Load(file);

            try
            {
                clientContext.ExecuteQuery();
            }
            catch
            {
                return false;
            }

            return true;
        }

        private bool CreateListFromTemplate(SharePointListStructure list)
        {
            // Create list
            //ListCreationInformation listCreationInfo = new ListCreationInformation
            //{
            //    Title = list.ListName,
            //    TemplateType = (int)ListTemplateType.GenericList
            //};
            //List oList = web.Lists.Add(listCreationInfo);
            //clientContext.ExecuteQuery();

            //// add fields to list

            //var pList = clientContext.Web.Lists.GetByTitle(list.ListName);

            //pList

            //var pField = oList.Fields.AddFieldAsXml("<Field DisplayName='MyField' Type='Number' />",

            //    true, AddFieldOptions.DefaultValue);

            //var fieldNumber = clientContext.CastTo<FieldNumber>(pField);
            //fieldNumber.MaximumValue = 100;
            //fieldNumber.MinimumValue = 35;

            //fieldNumber.Update();

            //clientContext.ExecuteQuery();

            return true;
        }
    }
}