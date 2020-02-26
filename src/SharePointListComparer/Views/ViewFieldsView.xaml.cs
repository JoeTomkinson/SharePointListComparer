using System;
using System.Collections.Generic;
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
using SharePointListComparer.Windows;

namespace SharePointListComparer.Views
{
    /// <summary>
    /// Interaction logic for ViewFieldsView.xaml
    /// </summary>
    public partial class ViewFieldsView : UserControl
    {
        private readonly SharePointListStructure data;

        public ViewFieldsView(SharePointListStructure sharePointListStructure)
        {
            InitializeComponent();

            // initialise rest of window
            data = sharePointListStructure ?? throw new ArgumentNullException(nameof(SharePointListStructure));
            SetUpData();
            tbListName.Text = string.Format("DISPLAYING: {0}", data.ListName);
        }

        private void SetUpData()
        {
            dgViews.ItemsSource = data.ViewDefinitions;
        }

        private void dgViews_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var view = (e.Source as DataGrid).SelectedItem as SharePointListView;
            lvViewColumns.ItemsSource = view.ViewFieldRefs;
            tbViewColumnCount.Text = string.Format("Column Count: {0}", view.ViewFieldRefs.Count.ToString());
        }

        private void btnOpenInNew_Click(object sender, RoutedEventArgs e)
        {
            this.col1.Width = new GridLength(0);
            this.col2.Width = new GridLength(0);
            this.spNavigationButtons.Visibility = Visibility.Hidden;
            RootWindow.RemoveFromMainContentView(this);
            ExpansionWindow expansionWindow = new ExpansionWindow(this, "View Fields");
            expansionWindow.Show();
        } 

        private void btnBackNav_Click(object sender, RoutedEventArgs e)
        {
            RootWindow.RemoveFromMainContentView(this);
        }

        private void lvViewColumns_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selection = (sender as ListView).SelectedItem.ToString();
            Clipboard.SetText(selection);
            RootWindow.MessageQueue.Enqueue("Copied to Clipboard.");
        }
    }
}