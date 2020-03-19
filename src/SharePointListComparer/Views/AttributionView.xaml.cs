using SharePointListComparer;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Navigation;

namespace Tooling.SharePointListComparer.Views
{
    /// <summary>
    /// Interaction logic for AttributionView.xaml
    /// </summary>
    public partial class AttributionView : UserControl
    {
        public AttributionView()
        {
            InitializeComponent();

            //TODO: all of this should be passed in and dynamically built from a config list, this is lazy.
            Hyperlink link = new Hyperlink
            {
                IsEnabled = true
            };
            link.Inlines.Add("Iconset Homepage");
            link.NavigateUri = new Uri(" http://www.fatcow.com/free-icons");
            link.RequestNavigate += LinkClicked;
             
            SetText(rtAttr, "[Icons] Artist: Fatcow Web Hosting, License: CC Attribution 4.0", link);
        }

        private void LinkClicked(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(e.Uri.ToString());
        }

        public void SetText(RichTextBox richTextBox, string plainText = null, Hyperlink hyperlink = null)
        {
            richTextBox.Document.Blocks.Clear();

            if(!string.IsNullOrEmpty(plainText))
            {
                richTextBox.Document.Blocks.Add(new Paragraph(new Run(plainText)));
            }

            if (hyperlink != null)
            {
                Paragraph para = new Paragraph();
                para.Inlines.Add(hyperlink);
                richTextBox.Document.Blocks.Add(para);
            }
        }

        public string GetText(RichTextBox richTextBox)
        {
            return new TextRange(richTextBox.Document.ContentStart,
                richTextBox.Document.ContentEnd).Text;
        }

        private void btnBackNav_Click(object sender, RoutedEventArgs e)
        {
            RootWindow.RemoveFromMainContentView(this);
        }
    }
}