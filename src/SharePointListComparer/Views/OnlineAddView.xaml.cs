using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SharePointListComparer.Models;
using SharePointListComparer.SharePoint.Service;
using SharePointListComparer.Storage;
using SharePointListComparer.Utilities;

namespace SharePointListComparer.Views
{
    /// <summary>
    /// Interaction logic for OnlineAddView.xaml
    /// </summary>
    public partial class OnlineAddView : UserControl
    {
        public ObservableCollection<SharePointListStructure> RetrievedData { get; private set; } = new ObservableCollection<SharePointListStructure>();

        private string username, password, siteUrl;
        private bool isOnlineSite;
        private SharePointDataService sharePointDataService;
        private SharePointInformation sharePointInformation;

        public OnlineAddView()
        {
            InitializeComponent();

            Task.Run(() =>
            {
                sharePointInformation = ApplicationState.GetValue<SharePointInformation>("SharePointInformation");
                if (sharePointInformation != null && !string.IsNullOrEmpty(sharePointInformation?.Username))
                {
                    password = PortableCryptography.Decrypt(sharePointInformation.EncryptedPassword, sharePointInformation.Username);
                    username = sharePointInformation.Username;
                    siteUrl = sharePointInformation.SiteUrl;
                    isOnlineSite = sharePointInformation.IsSharePointOnline;

                    // create SharePoint Client
                    sharePointDataService = new SharePointDataService(username, password, siteUrl, isOnlineSite);
                    var listCollection = sharePointDataService.GetAllLists() as ListCollection;

                    Dispatcher.Invoke(() =>
                    {
                        dtSharePointLists.ItemsSource = listCollection;

                        grdLoadingOverlay.Visibility = Visibility.Hidden;
                    });
                }
                else
                {
                    Dispatcher.Invoke(() =>
                    {
                        // For now, if we get to this screen without credentials, just push backwards.
                        btnBackNav_Click(this, null);
                    });
                }
            });
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var items = dtSharePointLists.SelectedItems;

            Task.Run(() =>
            {
                foreach (Microsoft.SharePoint.Client.List item in items)
                {
                    var sharePointListStructure = new SharePointListStructure
                    {
                        ListName = item.Title
                    };

                    // get our list data populated.
                    var listData = sharePointDataService.LoadListItems(item) as Microsoft.SharePoint.Client.List;

                    //initialise object lists
                    sharePointListStructure.ColumnDefinitions = new List<Models.ColumnDefinition>();
                    sharePointListStructure.ViewDefinitions = new List<SharePointListView>();

                    foreach (var field in listData.Fields)
                    {
                        sharePointListStructure.ColumnDefinitions.Add(new Models.ColumnDefinition
                        {
                            ColumnType = field.TypeDisplayName,
                            DisplayName = field.Title,
                            Name = field.InternalName,
                            Required = field.Required ? "True" : "False",
                            StaticName = field.StaticName
                        });
                    }

                    foreach (var view in listData.Views)
                    {
                        sharePointListStructure.ViewDefinitions = new List<SharePointListView>()
                        {
                             new SharePointListView()
                             {
                                ViewDisplayName = view.Title,
                                 ViewFieldRefs = view.ViewFields.ToList(),
                             }
                        };
                    }

                    RetrievedData.Add(sharePointListStructure);
                }

                Dispatcher.Invoke(() => { RootWindow.RemoveFromMainContentView(this); });
            });
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            grdLoadingOverlay.Visibility = Visibility.Visible;

            Task.Run(() =>
            {
                if (sharePointInformation != null && !string.IsNullOrEmpty(sharePointInformation?.Username))
                {
                    password = PortableCryptography.Decrypt(sharePointInformation.EncryptedPassword, sharePointInformation.Username);
                    username = sharePointInformation.Username;
                    siteUrl = sharePointInformation.SiteUrl;
                    isOnlineSite = sharePointInformation.IsSharePointOnline;

                    // create SharePoint Client
                    sharePointDataService = new SharePointDataService(username, password, siteUrl, isOnlineSite);
                    var listCollection = sharePointDataService.GetAllLists() as ListCollection;

                    Dispatcher.Invoke(() =>
                    {
                        dtSharePointLists.ItemsSource = listCollection;
                        grdLoadingOverlay.Visibility = Visibility.Hidden;
                    });
                }
            });
        }

        private void btnBackNav_Click(object sender, RoutedEventArgs e)
        {
            RetrievedData.Clear();
            RootWindow.RemoveFromMainContentView(this);
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            btnBackNav_Click(sender, e);
        }
    }
}
