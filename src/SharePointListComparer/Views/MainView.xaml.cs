using Microsoft.Win32;
using SharePointListComparer.Models;
using SharePointListComparer.SharePoint.Service;
using SharePointListComparer.Storage;
using SharePointListComparer.Utilities;
using SharePointListComparer.ValueConverters;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using Tooling.SharePointListComparer.Views;

namespace SharePointListComparer.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public LocalListParsingService ListParsingService { get; set; }

        public SharePointDataService SharePointDataService { get; set; } = null;

        public CabService CabService { get; set; }

        public ObservableCollection<SharePointListStructure> LeftSharePointLists { get; set; }

        public ObservableCollection<SharePointListStructure> RightSharePointLists { get; set; }

        public MainView()
        {
            InitializeComponent();
            // initialise rest of control
            leftCardOptions.Visibility = Visibility.Hidden;
            rightCardOptions.Visibility = Visibility.Hidden;
            ListParsingService = new LocalListParsingService();
            CabService = new CabService();
            SetUpDataGrids();
            this.LayoutUpdated += MainView_LayoutUpdated;

            SetUpSharePointDataService(false);
        }

        private void SetUpSharePointDataService(bool synchronous)
        {
            if (!synchronous)
            {
                Task.Run(() =>
                {
                    var sharePointInformation = ApplicationState.GetValue<SharePointInformation>("SharePointInformation");
                    if (sharePointInformation != null && !string.IsNullOrEmpty(sharePointInformation?.Username))
                    {
                        var password = PortableCryptography.Decrypt(sharePointInformation.EncryptedPassword, sharePointInformation.Username);
                        var username = sharePointInformation.Username;
                        var siteUrl = sharePointInformation.SiteUrl;
                        var isOnlineSite = sharePointInformation.IsSharePointOnline;

                        // create SharePoint Client
                        try
                        {
                            SharePointDataService = new SharePointDataService(username, password, siteUrl, isOnlineSite);
                        }
                        catch (Exception ex)
                        {
                            //IdcrlException: The sign-in name or password does not match one in the Microsoft account system.
                            var innerEx = ex.InnerException?.Message;
                            if (!string.IsNullOrEmpty(innerEx))
                            {
                                RootWindow.MessageQueue.Enqueue("Failed attempting to connect to SharePoint isntance: " + innerEx);
                            }
                        }

                        Dispatcher.Invoke(() =>
                        {
                            // make a note of our failed lists.
                            miLeftSubmitToSharePoint.IsEnabled = true;
                            miRightSubmitToSharePoint.IsEnabled = true;
                        });
                    }
                    else
                    {
                        Dispatcher.Invoke(() =>
                        {
                            // make a note of our failed lists.
                            miLeftSubmitToSharePoint.IsEnabled = false;
                            miRightSubmitToSharePoint.IsEnabled = false;
                        });
                    }
                });
            }
            else
            {
                var sharePointInformation = ApplicationState.GetValue<SharePointInformation>("SharePointInformation");
                if (sharePointInformation != null && !string.IsNullOrEmpty(sharePointInformation?.Username))
                {
                    var password = PortableCryptography.Decrypt(sharePointInformation.EncryptedPassword, sharePointInformation.Username);
                    var username = sharePointInformation.Username;
                    var siteUrl = sharePointInformation.SiteUrl;
                    var isOnlineSite = sharePointInformation.IsSharePointOnline;

                    // create SharePoint Client
                    try
                    {
                        SharePointDataService = new SharePointDataService(username, password, siteUrl, isOnlineSite);
                    }
                    catch (Exception ex)
                    {
                        //IdcrlException: The sign-in name or password does not match one in the Microsoft account system.
                        var innerEx = ex.InnerException?.Message;
                        if (!string.IsNullOrEmpty(innerEx))
                        {
                            RootWindow.MessageQueue.Enqueue("Failed attempting to connect to SharePoint isntance: " + innerEx);
                        }
                    }

                    // make a note of our failed lists.
                    miLeftSubmitToSharePoint.IsEnabled = true;
                    miRightSubmitToSharePoint.IsEnabled = true;
                }
                else
                {
                    // make a note of our failed lists.
                    miLeftSubmitToSharePoint.IsEnabled = false;
                    miRightSubmitToSharePoint.IsEnabled = false;
                }
            }
        }

        private void MainView_LayoutUpdated(object sender, EventArgs e)
        {
            var showOnline = ApplicationState.GetValue<bool>("ShowOnlineButton");
            if (showOnline != btnLeftServer.IsEnabled)
            {
                btnLeftServer.IsEnabled = showOnline;
                btnRightServer.IsEnabled = showOnline;
            }
        }

        private void SetUpDataGrids()
        {
            LeftSharePointLists = new ObservableCollection<SharePointListStructure>();
            RightSharePointLists = new ObservableCollection<SharePointListStructure>();

            // set up left datagrind
            DataGridTextColumn col = dgLeftList.Columns[1] as DataGridTextColumn;
            Binding binding = new Binding
            {
                RelativeSource = new RelativeSource(RelativeSourceMode.FindAncestor, typeof(DataGridRow), 1),
                Converter = new RowToIndexConverter(),
                NotifyOnTargetUpdated = true
            };

            col.Binding = binding;
            dgLeftList.ItemsSource = LeftSharePointLists;
            dgLeftList.EnableColumnVirtualization = false;
            dgLeftList.EnableRowVirtualization = false;

            // Set up right datagrid
            DataGridTextColumn colRight = dgRightList.Columns[1] as DataGridTextColumn;
            Binding bindingRight = new Binding
            {
                RelativeSource = new RelativeSource(RelativeSourceMode.FindAncestor, typeof(DataGridRow), 1),
                Converter = new RowToIndexConverter(),
                NotifyOnTargetUpdated = true
            };
            colRight.Binding = bindingRight;
            dgRightList.ItemsSource = RightSharePointLists;
            dgRightList.EnableColumnVirtualization = false;
            dgRightList.EnableRowVirtualization = false;
        }

        private void OpenParseStoreList(ObservableCollection<SharePointListStructure> list)
        {
            // Create OpenFileDialog 
            OpenFileDialog dlg = new OpenFileDialog
            {
                Multiselect = true
            };

            // folder path
            string folderpath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\SPTFiles\\";

            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".stp";
            dlg.Filter = "SP Template (*.stp)|*.stp|Cab Files (*.cab)|*.cab|All files (*.*)|*.*";

            // Display OpenFileDialog by calling ShowDialog method 
            bool? result = dlg.ShowDialog();

            Task.Run(() =>
            {
                // Get the selected file name and display in a TextBox 
                if (result == true)
                {
                    // ensure our save directory exists already
                    if (!Directory.Exists(folderpath))
                    {
                        Directory.CreateDirectory(folderpath);
                    }

                    //Failed items
                    List<SharePointListStructure> failedImports = new List<SharePointListStructure>();

                    foreach (string fp in dlg.FileNames)
                    {
                        // Open document 
                        string name = Path.GetFileName(fp);
                        string filePath = fp;

                        // get and check document extension
                        string ext = Path.GetExtension(fp);
                        if (ext.ToLower() == ".spt")
                        {
                            name = Guid.NewGuid().ToString();
                            filePath = folderpath + Path.GetFileName(filePath + ".cab");
                            File.Copy(filePath, filePath, true);
                        }

                        // create extract directory for the manifest file
                        var extractDir = string.Format("{0}{1}", folderpath, name);
                        if (!Directory.Exists(extractDir))
                        {
                            Directory.CreateDirectory(extractDir);
                        }

                        var extractedFilePath = CabService.ExtractFromCabFile(filePath, extractDir);
                        var parsedFile = ListParsingService.ParseSPTFile(extractedFilePath);

                        if (parsedFile != null && parsedFile?.ColumnDefinitions != null)
                        {
                            Dispatcher.Invoke(() =>
                            {
                                list.Add(parsedFile);
                            });
                        }
                        else
                        {
                            Dispatcher.Invoke(() =>
                            {
                                // make a note of our failed lists.
                                failedImports.Add(parsedFile);
                            });
                        }
                    }

                    if (failedImports.Count > 0)
                    {
                        // Show which lists failed to Import.
                        StringBuilder stringBuilder = new StringBuilder();
                        stringBuilder.Append("Failed List Imports:").AppendLine().AppendLine();
                        foreach (var structure in failedImports)
                        {
                            string line = string.Format("List name: {0}", structure.ListName);
                            stringBuilder.Append(line).AppendLine().AppendLine().Append("----").AppendLine().AppendLine();
                        }

                        Dispatcher.Invoke(() =>
                        {
                            RootWindow.DialogOverlayControl.SetDialogText(stringBuilder.ToString());
                            RootWindow.DialogOverlayControl.ToggleOverlay();
                        });
                    }
                }
            });
        }

        private void CompareLists()
        {
            Task.Run(() =>
            {
                // perform list comparisons, this might take awhile.
                int index = 0;
                var results = new List<ComparisonResult>();
                foreach (var list in LeftSharePointLists)
                {
                    ComparisonResult result = new ComparisonResult
                    {
                        ListName = list.ListName,
                        ComparisonListName = RightSharePointLists[index].ListName,
                        ComparisonIndex = index
                    };

                    // extract out a list of each columns display name as an array of strings to compare.
                    var firstListColumns = list.ColumnDefinitions.Select(x => x.DisplayName);
                    var secondListColumns = RightSharePointLists[index].ColumnDefinitions.Select(x => x.DisplayName);

                    // We need to compare both ways incase of count differences

                    var firstListAnalysis = new ConcurrentBag<ColumnAnalysis>();
                    bool firstIdentical = true;
                    Parallel.ForEach(firstListColumns, item =>
                    {
                        ColumnAnalysis columnAnalysis = new ColumnAnalysis()
                        {
                            DisplayName = item
                        };

                        var exists = secondListColumns.Any(x => x == item);

                        if (exists)
                        {
                            columnAnalysis.Matched = true;
                        }
                        else
                        {
                            firstIdentical = false;
                            columnAnalysis.Matched = false;
                        }

                        firstListAnalysis.Add(columnAnalysis);
                    });

                    var secondListAnalysis = new ConcurrentBag<ColumnAnalysis>();
                    bool secondIdentical = true;
                    Parallel.ForEach(secondListColumns, item =>
                    {
                        ColumnAnalysis columnAnalysis = new ColumnAnalysis()
                        {
                            DisplayName = item
                        };

                        var exists = firstListColumns.Any(x => x == item);

                        if (exists)
                        {
                            columnAnalysis.Matched = true;
                        }
                        else
                        {
                            secondIdentical = false;
                            columnAnalysis.Matched = false;
                        }

                        secondListAnalysis.Add(columnAnalysis);
                    });

                    result.SecondListColumnAnalysis = secondListAnalysis;
                    result.FirstListColumnsAnalysis = firstListAnalysis;
                    result.Identical = firstIdentical && secondIdentical;

                    // let's do a view comparison too.
                    var viewsLeft = list.ViewDefinitions;
                    var viewsRight = RightSharePointLists[index].ViewDefinitions;

                    List<bool> matches = new List<bool>();
                    foreach (var view in viewsLeft)
                    {
                        foreach (var fieldRef in view.ViewFieldRefs)
                        {
                            var rightView = viewsRight.Find(x => x.ViewDisplayName == view.ViewDisplayName);
                            if (rightView == null)
                            {
                                break;
                            }
                            matches.Add(rightView.ViewFieldRefs.Any(x => x == fieldRef));
                        }
                    }
                    foreach (var view in viewsRight)
                    {
                        foreach (var fieldRef in view.ViewFieldRefs)
                        {
                            var leftView = viewsLeft.Find(x => x.ViewDisplayName == view.ViewDisplayName);
                            if (leftView == null)
                            {
                                break;
                            }
                            matches.Add(leftView.ViewFieldRefs.Any(x => x == fieldRef));
                        }
                    }

                    result.AreViewsIdentical = !matches.Any(x => x == false);

                    // collect our results and up the index count.
                    results.Add(result);
                    index++;
                }

                Dispatcher.Invoke(() =>
                {
                    grdLoadingOverlay.Visibility = Visibility.Hidden;
                    // let's display our results
                    ComparisonResultsView comparisonResultsView = new ComparisonResultsView(results);
                    RootWindow.AddToMainContentView(comparisonResultsView);
                });
            });
        }

        #region BUTTON EVENTS

        private void btnAddLeft_Click(object sender, RoutedEventArgs e)
        {
            if (leftCardOptions.Visibility == Visibility.Hidden)
            {
                leftCardOptions.Visibility = Visibility.Visible;
            }
            else
            {
                leftCardOptions.Visibility = Visibility.Hidden;
            }
        }

        private void btnAddRight_Click(object sender, RoutedEventArgs e)
        {
            if (rightCardOptions.Visibility == Visibility.Hidden)
            {
                rightCardOptions.Visibility = Visibility.Visible;
            }
            else
            {
                rightCardOptions.Visibility = Visibility.Hidden;
            }
        }

        private void btnRemoveLeft_Click(object sender, RoutedEventArgs e)
        {
            if (dgLeftList.SelectedIndex != -1)
            {
                LeftSharePointLists.RemoveAt(dgLeftList.SelectedIndex);
            }
        }

        private void btnRemoveRight_Click(object sender, RoutedEventArgs e)
        {
            if (dgRightList.SelectedIndex != -1)
            {
                RightSharePointLists.RemoveAt(dgRightList.SelectedIndex);
            }
        }

        private void btnRunComparison_Click(object sender, RoutedEventArgs e)
        {
            grdLoadingOverlay.Visibility = Visibility.Visible;

            var count = LeftSharePointLists.Count == 0 || RightSharePointLists.Count == 0;
            if (LeftSharePointLists.Count != RightSharePointLists.Count || count)
            {
                RootWindow.MessageQueue.Enqueue("Failed - Please ensure all lists have a comparison list set.");
                return;
            }
            CompareLists();
        }

        private void btnResetAll_Click(object sender, RoutedEventArgs e)
        {
            if (LeftSharePointLists.Count > 0)
            {
                LeftSharePointLists.Clear();
            }

            if (RightSharePointLists.Count > 0)
            {
                RightSharePointLists.Clear();
            }

            RootWindow.MessageQueue.Enqueue("All SharePoint lists cleared.");
        }

        private void list_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = (e.Source as DataGrid).SelectedItem as SharePointListStructure;
            ViewFieldsView viewFieldsView = new ViewFieldsView(item);
            RootWindow.AddToMainContentView(viewFieldsView);
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            RootWindow.AddToMainContentView(new SettingsView());
        }

        private void btnLeftLocal_Click(object sender, RoutedEventArgs e)
        {
            OpenParseStoreList(LeftSharePointLists);
            leftCardOptions.Visibility = Visibility.Hidden;
        }

        private void btnRightLocal_Click(object sender, RoutedEventArgs e)
        {
            OpenParseStoreList(RightSharePointLists);
            rightCardOptions.Visibility = Visibility.Hidden;
        }

        private void btnLeftServer_Click(object sender, RoutedEventArgs e)
        {
            OnlineAddView onlineAddView = new OnlineAddView();
            onlineAddView.Unloaded += (s, ev) =>
            {
                if (onlineAddView.RetrievedData.Count > 0)
                {
                    foreach (var item in onlineAddView.RetrievedData)
                    {
                        LeftSharePointLists.Add(item);
                    }
                }
            };
            RootWindow.AddToMainContentView(onlineAddView);
            leftCardOptions.Visibility = Visibility.Hidden;
        }

        private void btnRightServer_Click(object sender, RoutedEventArgs e)
        {
            OnlineAddView onlineAddView = new OnlineAddView();
            onlineAddView.Unloaded += (s, ev) =>
            {
                if (onlineAddView.RetrievedData.Count > 0)
                {
                    foreach (var item in onlineAddView.RetrievedData)
                    {
                        RightSharePointLists.Add(item);
                    }
                }
            };
            RootWindow.AddToMainContentView(onlineAddView);
            rightCardOptions.Visibility = Visibility.Hidden;
        }

        private void miLeftSubmitToSharePoint_Click(object sender, RoutedEventArgs e)
        {
            SubmitToSharePoint(dgLeftList);
        }

        private void miRightSubmitToSharePoint_Click(object sender, RoutedEventArgs e)
        {
            SubmitToSharePoint(dgRightList);
        }

        private void btnAttributions_Click(object sender, RoutedEventArgs e)
        {
            RootWindow.AddToMainContentView(new AttributionView());
        }

        #endregion

        private void SubmitToSharePoint(DataGrid dataGrid)
        {
            if (SharePointDataService != null)
            {
                var selectedLists = new List<SharePointListStructure>();
                for (int i = 0; i < dataGrid.SelectedItems.Count; i++)
                {
                    selectedLists.Add((SharePointListStructure)dataGrid.SelectedItems[i]);
                }

                var includesOnlineLists = selectedLists.Any(x => !x.LocalList);
                var localLists = selectedLists.FindAll(x => x.LocalList);

                if (includesOnlineLists)
                {
                    RootWindow.MessageQueue.Enqueue("Ignoring Online Lists.");
                }

                // pass through our lists to create in SharePoint.
                SharePointDataService.CreateLists(localLists);
            }
            else
            {
                RootWindow.MessageQueue.Enqueue("No SharePoint Site Set.");
            }
        }
    }
}
