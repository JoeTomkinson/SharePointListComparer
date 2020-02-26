using System;
using SharePointListComparer.SharePoint.Interface;

namespace SharePointListComparer.SharePoint.Abstract
{
    public abstract class DataServiceAbstract : IDataInteractions
    {
        public DataServiceAbstract()
        {
        }

        public abstract object GetAllLists();

        public abstract object LoadListItems(object list);
    }
}
