namespace SharePointListComparer.Models
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ListTemplate
    {
        /// <remarks/>
        public ListTemplateDetails Details { get; set; }

        /// <remarks/>
        public ListTemplateFiles Files { get; set; }

        /// <remarks/>
        public ListTemplateUserLists UserLists { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("WebPart", IsNullable = false)]
        public ListTemplateWebPart[] WebParts { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string WebUrl { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateDetails
    {

        /// <remarks/>
        public string TemplateDescription { get; set; }

        /// <remarks/>
        public string TemplateTitle { get; set; }

        /// <remarks/>
        public byte ProductVersion { get; set; }

        /// <remarks/>
        public ushort Language { get; set; }

        /// <remarks/>
        public byte TemplateID { get; set; }

        /// <remarks/>
        public byte Configuration { get; set; }

        /// <remarks/>
        public string FeatureId { get; set; }

        /// <remarks/>
        public byte TemplateType { get; set; }

        /// <remarks/>
        public byte BaseType { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateFiles
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("File", typeof(ListTemplateFilesFile))]
        [System.Xml.Serialization.XmlElementAttribute("Folder", typeof(ListTemplateFilesFolder))]
        public object[] Items { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateFilesFile
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("MetaKey", IsNullable = false)]
        public ListTemplateFilesFileMetaKey[] MetaInfo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Src { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateFilesFileMetaKey
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateFilesFolder
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("MetaKey", IsNullable = false)]
        public ListTemplateFilesFolderMetaKey[] MetaInfo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateFilesFolderMetaKey
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserLists
    {

        /// <remarks/>
        public ListTemplateUserListsList List { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsList
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaData MetaData { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Title { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Description { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Direction { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte BaseType { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FeatureId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ServerTemplate { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Url { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FolderCreation { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NavigateForFormsPages { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BrowserFileHandling { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Version { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaData
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("View", IsNullable = false)]
        public ListTemplateUserListsListMetaDataView[] Views { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Field", IsNullable = false)]
        public ListTemplateUserListsListMetaDataField[] Fields { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ContentType", IsNullable = false)]
        public ListTemplateUserListsListMetaDataContentType[] ContentTypes { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Form", IsNullable = false)]
        public ListTemplateUserListsListMetaDataForm[] Forms { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataSecurity Security { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Receiver", IsNullable = false)]
        public ListTemplateUserListsListMetaDataReceiver[] Receivers { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataView
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Aggregations", typeof(ListTemplateUserListsListMetaDataViewAggregations))]
        [System.Xml.Serialization.XmlElementAttribute("CustomFormatter", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("JSLink", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Mobile", typeof(ListTemplateUserListsListMetaDataViewMobile))]
        [System.Xml.Serialization.XmlElementAttribute("ParameterBindings", typeof(ListTemplateUserListsListMetaDataViewParameterBindings))]
        [System.Xml.Serialization.XmlElementAttribute("Query", typeof(ListTemplateUserListsListMetaDataViewQuery))]
        [System.Xml.Serialization.XmlElementAttribute("RowLimit", typeof(ListTemplateUserListsListMetaDataViewRowLimit))]
        [System.Xml.Serialization.XmlElementAttribute("Toolbar", typeof(ListTemplateUserListsListMetaDataViewToolbar))]
        [System.Xml.Serialization.XmlElementAttribute("ViewData", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("ViewFields", typeof(ListTemplateUserListsListMetaDataViewViewFields))]
        [System.Xml.Serialization.XmlElementAttribute("XslLink", typeof(ListTemplateUserListsListMetaDataViewXslLink))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DefaultView { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MobileView { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MobileDefaultView { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DisplayName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Url { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Level { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte BaseViewID { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ContentTypeID { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ImageUrl { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataViewAggregations
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataViewMobile
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte MobileItemLimit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MobileSimpleViewField { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataViewParameterBindings
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ParameterBinding")]
        public ListTemplateUserListsListMetaDataViewParameterBindingsParameterBinding[] ParameterBinding { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataViewParameterBindingsParameterBinding
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Location { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataViewQuery
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataViewQueryOrderBy OrderBy { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataViewQueryOrderBy
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataViewQueryOrderByFieldRef FieldRef { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataViewQueryOrderByFieldRef
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataViewRowLimit
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Paged { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataViewToolbar
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataViewViewFields
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FieldRef")]
        public ListTemplateUserListsListMetaDataViewViewFieldsFieldRef[] FieldRef { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataViewViewFieldsFieldRef
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataViewXslLink
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Default { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        Aggregations,

        /// <remarks/>
        CustomFormatter,

        /// <remarks/>
        JSLink,

        /// <remarks/>
        Mobile,

        /// <remarks/>
        ParameterBindings,

        /// <remarks/>
        Query,

        /// <remarks/>
        RowLimit,

        /// <remarks/>
        Toolbar,

        /// <remarks/>
        ViewData,

        /// <remarks/>
        ViewFields,

        /// <remarks/>
        XslLink,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataField
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CHOICE", IsNullable = false)]
        public string[] CHOICES { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("FieldRef", IsNullable = false)]
        public ListTemplateUserListsListMetaDataFieldFieldRef[] FieldRefs { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPattern DisplayPattern { get; set; }

        /// <remarks/>
        public string Default { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte RowOrdinal { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RowOrdinalSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Sealed { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReadOnly { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Hidden { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DisplayName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DisplaceOnUpgrade { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SourceID { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StaticName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ColName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FromBaseType { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Required { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EnforceUniqueValues { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Indexed { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte MaxLength { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxLengthSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Version { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VersionSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanToggleHidden { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Filterable { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Sortable { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Format { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FriendlyDisplayFormat { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string List { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ShowField { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnlimitedLengthInDocumentLibrary { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RelationshipDeleteBehavior { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AppendOnly { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IsolateStyles { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte NumLines { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumLinesSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RichText { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RichTextMode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Title { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ShowInFileDlg { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ShowInVersionHistory { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AuthoringInfo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FieldRef { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string JoinColName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte JoinRowOrdinal { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool JoinRowOrdinalSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string JoinType { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NoCustomize { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DisplayNameSrcField { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ListItemMenuAllowed { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LinkToItemAllowed { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClassInfo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RenderXMLUsingPattern { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MaskCheck { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RecreateIfMissing { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PrimaryKey { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Group { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PITarget { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PIAttribute { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StorageTZ { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SetAs { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Dir { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EnableLookup { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HeaderImage { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Min { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint Max { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxSpecified { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TextOnly { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SchemaVersion { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldFieldRef
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPattern
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Column", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternColumn))]
        [System.Xml.Serialization.XmlElementAttribute("Counter", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternCounter))]
        [System.Xml.Serialization.XmlElementAttribute("CurrentRights", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("Field", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternField))]
        [System.Xml.Serialization.XmlElementAttribute("FieldSwitch", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternFieldSwitch))]
        [System.Xml.Serialization.XmlElementAttribute("GetVar", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternGetVar))]
        [System.Xml.Serialization.XmlElementAttribute("HTML", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("HttpHost", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternHttpHost))]
        [System.Xml.Serialization.XmlElementAttribute("IfEqual", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqual))]
        [System.Xml.Serialization.XmlElementAttribute("IfHasRights", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternIfHasRights))]
        [System.Xml.Serialization.XmlElementAttribute("LookupColumn", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternLookupColumn))]
        [System.Xml.Serialization.XmlElementAttribute("MapToAll", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternMapToAll))]
        [System.Xml.Serialization.XmlElementAttribute("MapToContentType", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternMapToContentType))]
        [System.Xml.Serialization.XmlElementAttribute("SetVar", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternSetVar))]
        public object[] Items { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternColumn
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HTMLEncode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string URLEncodeAsURL { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternCounter
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternField
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string URLEncodeAsURL { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternFieldSwitch
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternFieldSwitchExpr Expr { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternFieldSwitchCase Case { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternFieldSwitchDefault Default { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternFieldSwitchExpr
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternFieldSwitchExprGetVar GetVar { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternFieldSwitchExprGetVar
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternFieldSwitchCase
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternFieldSwitchCaseField Field { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternFieldSwitchCaseField
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternFieldSwitchDefault
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Field", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternFieldSwitchDefaultField))]
        [System.Xml.Serialization.XmlElementAttribute("HTML", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("SetVar", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternFieldSwitchDefaultSetVar))]
        public object[] Items { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternFieldSwitchDefaultField
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternFieldSwitchDefaultSetVar
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Value { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternGetVar
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternHttpHost
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string URLEncodeAsURL { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqual
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualExpr1 Expr1 { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualExpr2 Expr2 { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThen Then { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElse Else { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualExpr1
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualExpr1GetVar GetVar { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualExpr1LookupColumn LookupColumn { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualExpr1GetVar
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualExpr1LookupColumn
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualExpr2
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualExpr2Column Column { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualExpr2Column
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThen
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HTML")]
        public string[] HTML { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenField Field { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenLookupColumn LookupColumn { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitch FieldSwitch { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenField
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenLookupColumn
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HTMLEncode { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitch
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchExpr Expr { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchCase Case { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefault Default { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchExpr
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchExprGetVar GetVar { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchExprGetVar
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchCase
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GetVar")]
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchCaseGetVar[] GetVar { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchCaseLookupColumn LookupColumn { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Value { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchCaseGetVar
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchCaseLookupColumn
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HTMLEncode { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefault
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FieldSwitch", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultFieldSwitch))]
        [System.Xml.Serialization.XmlElementAttribute("GetVar", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultGetVar))]
        [System.Xml.Serialization.XmlElementAttribute("HTML", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("IfEqual", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultIfEqual))]
        [System.Xml.Serialization.XmlElementAttribute("LookupColumn", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultLookupColumn))]
        [System.Xml.Serialization.XmlElementAttribute("ScriptQuote", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultScriptQuote))]
        [System.Xml.Serialization.XmlElementAttribute("SetVar", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultSetVar))]
        public object[] Items { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultFieldSwitch
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultFieldSwitchExpr Expr { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultFieldSwitchCase Case { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultFieldSwitchDefault Default { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultFieldSwitchExpr
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultFieldSwitchExprGetVar GetVar { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultFieldSwitchExprGetVar
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultFieldSwitchCase
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GetVar")]
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultFieldSwitchCaseGetVar[] GetVar { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Value { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultFieldSwitchCaseGetVar
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultFieldSwitchDefault
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GetVar", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultFieldSwitchDefaultGetVar))]
        [System.Xml.Serialization.XmlElementAttribute("HTML", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ScriptQuote", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultFieldSwitchDefaultScriptQuote))]
        public object[] Items { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultFieldSwitchDefaultGetVar
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HTMLEncode { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultFieldSwitchDefaultScriptQuote
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultFieldSwitchDefaultScriptQuoteGetVar GetVar { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NotAddingQuote { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultFieldSwitchDefaultScriptQuoteGetVar
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultGetVar
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HTMLEncode { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultIfEqual
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultIfEqualExpr1 Expr1 { get; set; }

        /// <remarks/>
        public byte Expr2 { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultIfEqualThen Then { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultIfEqualExpr1
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultIfEqualExpr1GetVar GetVar { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultIfEqualExpr1GetVar
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultIfEqualThen
    {

        /// <remarks/>
        public string HTML { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultLookupColumn
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HTMLEncode { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultScriptQuote
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultScriptQuoteField Field { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultScriptQuoteUserID UserID { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultScriptQuoteServerProperty ServerProperty { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultScriptQuoteColumn Column { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultScriptQuoteMapToControl MapToControl { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultScriptQuoteListProperty ListProperty { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultScriptQuoteGetVar GetVar { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NotAddingQuote { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultScriptQuoteField
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultScriptQuoteUserID
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowAnonymous { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultScriptQuoteServerProperty
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Select { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultScriptQuoteColumn
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultScriptQuoteMapToControl
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Column", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultScriptQuoteMapToControlColumn))]
        [System.Xml.Serialization.XmlElementAttribute("HTML", typeof(string))]
        public object[] Items { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultScriptQuoteMapToControlColumn
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultScriptQuoteListProperty
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Select { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultScriptQuoteGetVar
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultSetVar
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SetVar")]
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultSetVarSetVar[] SetVar { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultSetVarFilterLink FilterLink { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultSetVarSetVar
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultSetVarSetVarFieldSwitch FieldSwitch { get; set; }

        /// <remarks/>
        public string HTML { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultSetVarSetVarLookupColumn LookupColumn { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultSetVarSetVarFieldSwitch
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultSetVarSetVarFieldSwitchExpr Expr { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultSetVarSetVarFieldSwitchCase Case { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultSetVarSetVarFieldSwitchExpr
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultSetVarSetVarFieldSwitchExprListProperty ListProperty { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultSetVarSetVarFieldSwitchExprListProperty
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Select { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultSetVarSetVarFieldSwitchCase
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultSetVarSetVarFieldSwitchCaseColumn Column { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Value { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultSetVarSetVarFieldSwitchCaseColumn
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultSetVarSetVarLookupColumn
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualThenFieldSwitchDefaultSetVarFilterLink
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Default { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Paged { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElse
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Column", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseColumn))]
        [System.Xml.Serialization.XmlElementAttribute("Counter", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseCounter))]
        [System.Xml.Serialization.XmlElementAttribute("Field", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseField))]
        [System.Xml.Serialization.XmlElementAttribute("GetVar", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseGetVar))]
        [System.Xml.Serialization.XmlElementAttribute("HTML", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("IfEqual", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseIfEqual))]
        [System.Xml.Serialization.XmlElementAttribute("IfNew", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseIfNew))]
        [System.Xml.Serialization.XmlElementAttribute("ScriptQuote", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseScriptQuote))]
        [System.Xml.Serialization.XmlElementAttribute("URL", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("UrlBaseName", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseUrlBaseName))]
        public object[] Items { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseColumn
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HTMLEncode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Default { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseCounter
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseField
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string URLEncodeAsURL { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseGetVar
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseIfEqual
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseIfEqualExpr1 Expr1 { get; set; }

        /// <remarks/>
        public byte Expr2 { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseIfEqualThen Then { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseIfEqualExpr1
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseIfEqualExpr1GetVar GetVar { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseIfEqualExpr1GetVar
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseIfEqualThen
    {

        /// <remarks/>
        public string HTML { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseIfNew
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HTML")]
        public string[] HTML { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseScriptQuote
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseScriptQuoteField Field { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseScriptQuoteUserID UserID { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseScriptQuoteColumn Column { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseScriptQuoteMapToControl MapToControl { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseScriptQuoteListProperty ListProperty { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseScriptQuoteServerProperty ServerProperty { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NotAddingQuote { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseScriptQuoteField
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseScriptQuoteUserID
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowAnonymous { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseScriptQuoteColumn
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseScriptQuoteMapToControl
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Column", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseScriptQuoteMapToControlColumn))]
        [System.Xml.Serialization.XmlElementAttribute("HTML", typeof(string))]
        public object[] Items { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseScriptQuoteMapToControlColumn
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseScriptQuoteListProperty
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Select { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseScriptQuoteServerProperty
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Select { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseUrlBaseName
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseUrlBaseNameLookupColumn LookupColumn { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HTMLEncode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IsPath { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfEqualElseUrlBaseNameLookupColumn
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfHasRights
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfHasRightsRightsChoices RightsChoices { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfHasRightsThen Then { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfHasRightsElse Else { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfHasRightsRightsChoices
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternIfHasRightsRightsChoicesRightsGroup RightsGroup { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfHasRightsRightsChoicesRightsGroup
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PermEditListItems { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfHasRightsThen
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Counter", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternIfHasRightsThenCounter))]
        [System.Xml.Serialization.XmlElementAttribute("HTML", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("URL", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternIfHasRightsThenURL))]
        public object[] Items { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfHasRightsThenCounter
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfHasRightsThenURL
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Cmd { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternIfHasRightsElse
    {

        /// <remarks/>
        public string HTML { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternLookupColumn
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IncludeVersions { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string URLEncodeAsURL { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternMapToAll
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Column", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternMapToAllColumn))]
        [System.Xml.Serialization.XmlElementAttribute("HTML", typeof(string))]
        public object[] Items { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternMapToAllColumn
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternMapToContentType
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternMapToContentTypeColumn Column { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternMapToContentTypeColumn
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVar
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GetVar", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarGetVar))]
        [System.Xml.Serialization.XmlElementAttribute("HTML", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("IfEqual", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqual))]
        [System.Xml.Serialization.XmlElementAttribute("SetVar", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVar))]
        public object[] Items { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarGetVar
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqual
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqualExpr1 Expr1 { get; set; }

        /// <remarks/>
        public string Expr2 { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqualThen Then { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqualElse Else { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqualExpr1
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqualExpr1Column Column { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqualExpr1LookupColumn LookupColumn { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqualExpr1Column
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqualExpr1LookupColumn
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqualThen
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqualThenIfSubString IfSubString { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqualThenIfSubString
    {

        /// <remarks/>
        public string Expr1 { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqualThenIfSubStringExpr2 Expr2 { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqualThenIfSubStringThen Then { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqualThenIfSubStringElse Else { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqualThenIfSubStringExpr2
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqualThenIfSubStringExpr2Column Column { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqualThenIfSubStringExpr2Column
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqualThenIfSubStringThen
    {

        /// <remarks/>
        public string HTML { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqualThenIfSubStringThenLookupColumn LookupColumn { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqualThenIfSubStringThenLookupColumn
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HTMLEncode { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqualThenIfSubStringElse
    {

        /// <remarks/>
        public string HTML { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqualThenIfSubStringElseLookupColumn LookupColumn { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqualThenIfSubStringElseLookupColumn
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HTMLEncode { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqualElse
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HTML", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("LookupColumn", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqualElseLookupColumn))]
        [System.Xml.Serialization.XmlElementAttribute("MapToOverlay", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqualElseMapToOverlay))]
        public object[] Items { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqualElseLookupColumn
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HTMLEncode { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqualElseMapToOverlay
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqualElseMapToOverlayColumn Column { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarIfEqualElseMapToOverlayColumn
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVar
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqual IfEqual { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqual
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualExpr1 Expr1 { get; set; }

        /// <remarks/>
        public object Expr2 { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThen Then { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualElse Else { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualExpr1
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualExpr1Column Column { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualExpr1Column
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThen
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqual IfEqual { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqual
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualExpr1 Expr1 { get; set; }

        /// <remarks/>
        public byte Expr2 { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThen Then { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualElse Else { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualExpr1
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualExpr1LookupColumn LookupColumn { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualExpr1LookupColumn
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThen
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqual IfEqual { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqual
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqualExpr1 Expr1 { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqualExpr2 Expr2 { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqualThen Then { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqualElse Else { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqualExpr1
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Column", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqualExpr1Column))]
        [System.Xml.Serialization.XmlElementAttribute("HTML", typeof(string))]
        public object[] Items { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqualExpr1Column
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqualExpr2
    {

        /// <remarks/>
        public string HTML { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqualThen
    {

        /// <remarks/>
        public string HTML { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqualElse
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqualElseSetVar SetVar { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqualElseIfEqual IfEqual { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqualElseSetVar
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqualElseSetVarMapToIcon MapToIcon { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqualElseSetVarMapToIcon
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Column", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqualElseSetVarMapToIconColumn))]
        [System.Xml.Serialization.XmlElementAttribute("HTML", typeof(string))]
        public object[] Items { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqualElseSetVarMapToIconColumn
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqualElseIfEqual
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqualElseIfEqualExpr1 Expr1 { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqualElseIfEqualExpr2 Expr2 { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqualElseIfEqualThen Then { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqualElseIfEqualElse Else { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqualElseIfEqualExpr1
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqualElseIfEqualExpr1GetVar GetVar { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqualElseIfEqualExpr1GetVar
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqualElseIfEqualExpr2
    {

        /// <remarks/>
        public object MapToIcon { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqualElseIfEqualThen
    {

        /// <remarks/>
        public string HTML { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqualElseIfEqualElse
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqualElseIfEqualElseGetVar GetVar { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualThenIfEqualElseIfEqualElseGetVar
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualElse
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualElseMapToIcon MapToIcon { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualElseMapToIcon
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Column", typeof(ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualElseMapToIconColumn))]
        [System.Xml.Serialization.XmlElementAttribute("HTML", typeof(string))]
        public object[] Items { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualThenIfEqualElseMapToIconColumn
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualElse
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualElseMapToIcon MapToIcon { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualElseMapToIcon
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualElseMapToIconColumn Column { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataFieldDisplayPatternSetVarSetVarIfEqualElseMapToIconColumn
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataContentType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("FieldRef", IsNullable = false)]
        public ListTemplateUserListsListMetaDataContentTypeFieldRef[] FieldRefs { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataContentTypeXmlDocuments XmlDocuments { get; set; }

        /// <remarks/>
        public ListTemplateUserListsListMetaDataContentTypeFolder Folder { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Group { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Description { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Version { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FeatureId { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataContentTypeFieldRef
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Required { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DisplayName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Format { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Hidden { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataContentTypeXmlDocuments
    {

        /// <remarks/>
        public ListTemplateUserListsListMetaDataContentTypeXmlDocumentsXmlDocument XmlDocument { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataContentTypeXmlDocumentsXmlDocument
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.microsoft.com/sharepoint/v3/contenttype/forms")]
        public FormTemplates FormTemplates { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NamespaceURI { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sharepoint/v3/contenttype/forms")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/sharepoint/v3/contenttype/forms", IsNullable = false)]
    public partial class FormTemplates
    {

        /// <remarks/>
        public string Display { get; set; }

        /// <remarks/>
        public string Edit { get; set; }

        /// <remarks/>
        public string New { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataContentTypeFolder
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TargetName { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataForm
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Url { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Default { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte FormID { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataSecurity
    {

        /// <remarks/>
        public byte ReadSecurity { get; set; }

        /// <remarks/>
        public byte WriteSecurity { get; set; }

        /// <remarks/>
        public byte SchemaSecurity { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateUserListsListMetaDataReceiver
    {

        /// <remarks/>
        public string Name { get; set; }

        /// <remarks/>
        public byte Synchronization { get; set; }

        /// <remarks/>
        public ushort Type { get; set; }

        /// <remarks/>
        public ushort SequenceNumber { get; set; }

        /// <remarks/>
        public string Assembly { get; set; }

        /// <remarks/>
        public string Class { get; set; }

        /// <remarks/>
        public string Data { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ListTemplateWebPart
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string List { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Type { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint Flags { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DisplayName { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Version { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Url { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte WebPartOrder { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string WebPartZoneID { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte IsIncluded { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte FrameState { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string WPTypeId { get; set; }
    }
}