using MaterialDesignThemes.Wpf;
using SharePointListComparer.Views;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SharePointListComparer
{
    /// <summary>
    /// Interaction logic for RootWindow.xaml
    /// </summary>
    public partial class RootWindow : Window
    {
        private static Grid mainContentGrid;

        public static DialogOverlayView DialogOverlayControl { get; private set; }

        public static SnackbarMessageQueue MessageQueue { get; private set; }

        public RootWindow()
        {
            InitializeComponent();

            // get our pointer for our main grid
            mainContentGrid = gridMainContent;

            // add main view to our primary grid.
            mainContentGrid.Children.Add(new SplashView());

            // create our dialog control overlay and add it to our grid
            DialogOverlayControl = new DialogOverlayView();
            mainContentGrid.Children.Add(DialogOverlayControl);

            // get a pointer to our snackbar queue.
            MessageQueue = this.snackBarElement.MessageQueue;

            // populate title
            tbTitle.Text = Title;
        }

        public static void AddToMainContentView(UserControl userControl)
        {
            mainContentGrid.Children.Add(userControl);
        }

        public static void RemoveFromMainContentView(UserControl userControl)
        {
            mainContentGrid.Children.Remove(userControl);
        }

        #region TOP BAR

        private void gridTopBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                btnMaximise_Click(sender, e);
            }

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
            Application.Current.Shutdown();
        }

        #endregion
    }
}