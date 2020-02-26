using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SharePointListComparer.Windows
{
    /// <summary>
    /// Interaction logic for ExpansionWindow.xaml
    /// </summary>
    public partial class ExpansionWindow : Window
    {
        public ExpansionWindow(UserControl userControl, string title)
        {
            InitializeComponent();
            gridMainContent.Children.Add(userControl ?? throw new ArgumentNullException(nameof(UserControl)));
            tbTitle.Text = title ?? throw new ArgumentNullException("Title required");
        }

        #region TOP BAR

        private void gridTopBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnMinimise_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnMaximise_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
