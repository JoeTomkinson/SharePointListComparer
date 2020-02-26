using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using SharePointListComparer.Models;
using SharePointListComparer.Windows;

namespace SharePointListComparer.Views
{
    /// <summary>
    /// Interaction logic for ComparisonResultsView.xaml
    /// </summary>
    public partial class ComparisonResultsView : UserControl
    {
        public List<ComparisonResult> ComparisonResults { get; set; }

        public ComparisonResultsView(List<ComparisonResult> comparisonResults)
        {
            InitializeComponent();

            ComparisonResults = comparisonResults ?? throw new ArgumentNullException("Comparison results required to display this window.");

            // set up datagrind
            dgComparisonResults.ItemsSource = ComparisonResults;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //TODO: Replace/Refactor this whole method with some sort of proper template.
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text file (*.txt)|*.txt"
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                using (TextWriter tw = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (var item in ComparisonResults)
                    {
                        tw.WriteLine(string.Format("Comparison Result for List {0} & Comparison List {1}", item.ListName, item.ComparisonListName));
                        tw.WriteLine(string.Format("Primary List had {0} columns", item.FirstListColumnsAnalysis.Count()));
                        tw.WriteLine(string.Format("Comparison List had {0} columns", item.SecondListColumnAnalysis.Count()));

                        if (item.Identical)
                        {
                            tw.WriteLine("Both lists are identical and both contain the following columns:");
                            tw.WriteLine("");

                            foreach (var column in item.FirstListColumnsAnalysis)
                            {
                                tw.WriteLine(string.Format("Column: {0}, Matched: {1}", column.DisplayName, column.Matched));
                            }
                        }
                        else
                        {
                            tw.WriteLine("Both lists were not identical:");
                            tw.WriteLine("");
                            tw.WriteLine(item.ListName);
                            tw.WriteLine("");

                            foreach (var column in item.FirstListColumnsAnalysis)
                            {
                                tw.WriteLine(string.Format("Column: {0}, Matched: {1}", column.DisplayName, column.Matched));
                            }

                            tw.WriteLine(item.ComparisonListName);
                            tw.WriteLine("");

                            foreach (var column in item.SecondListColumnAnalysis)
                            {
                                tw.WriteLine(string.Format("Column: {0}, Matched: {1}", column.DisplayName, column.Matched));
                            }
                        }

                        tw.WriteLine("");
                        tw.WriteLine("");
                        tw.WriteLine("---------------------------------------");
                        tw.WriteLine("");
                        tw.WriteLine("");
                    }
                }
            }
        }

        private void dgComparisonResults_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int index = dgComparisonResults.SelectedIndex;
            var result = ComparisonResults[index];
            ColumnComparisonView columnComparisonView = new ColumnComparisonView(result);
            RootWindow.AddToMainContentView(columnComparisonView);
        }

        private void btnOpenInNew_Click(object sender, RoutedEventArgs e)
        {
            this.spNavigationButtons.Visibility = Visibility.Hidden;
            RootWindow.RemoveFromMainContentView(this);
            ExpansionWindow expansionWindow = new ExpansionWindow(this, "Comparison Results");
            expansionWindow.Show();
        }

        private void btnBackNav_Click(object sender, RoutedEventArgs e)
        {
            RootWindow.RemoveFromMainContentView(this);
        }
    }
}
