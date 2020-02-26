using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security;
using System.Threading.Tasks;
using SharePointListComparer.SharePoint.Abstract;

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
    }
}