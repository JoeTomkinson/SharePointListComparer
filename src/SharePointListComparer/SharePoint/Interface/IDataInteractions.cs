namespace SharePointListComparer.SharePoint.Interface
{
    /// <summary>
    /// Defines the core requirements for a data service.
    /// </summary>
    public interface IDataInteractions
    {
        object GetAllLists();

        object LoadListItems(object list);
    }
}