using System.Windows;
using System.Windows.Controls;
using SharePointListComparer.Models;
using SharePointListComparer.Windows;

namespace SharePointListComparer.Views
{
    /// <summary>
    /// Interaction logic for ColumnComparisonView.xaml
    /// </summary>
    public partial class ColumnComparisonView : UserControl
    {
        public ColumnComparisonView(ComparisonResult result)
        {
            InitializeComponent();

            lvComparisonColumns.ItemsSource = result.SecondListColumnAnalysis;
            lvComparisonColumns.DisplayMemberPath = "DisplayName";

            lvListColumns.ItemsSource = result.FirstListColumnsAnalysis;
            lvListColumns.DisplayMemberPath = "DisplayName";

            tbListName.Text = result.ListName;
            tbComparisonName.Text = result.ComparisonListName;
        }

        private void btnOpenInNew_Click(object sender, RoutedEventArgs e)
        {
            this.spNavigationButtons.Visibility = Visibility.Hidden;
            this.rdTopRowDef.Height = new GridLength(0);
            RootWindow.RemoveFromMainContentView(this);
            ExpansionWindow expansionWindow = new ExpansionWindow(this, "Columns Comparison");
            expansionWindow.Show();
        }

        private void btnBackNav_Click(object sender, RoutedEventArgs e)
        {
            RootWindow.RemoveFromMainContentView(this);
        }
    }
}
