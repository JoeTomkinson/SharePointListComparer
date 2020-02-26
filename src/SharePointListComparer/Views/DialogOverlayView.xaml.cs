using System;
using System.Windows;
using System.Windows.Controls;

namespace SharePointListComparer.Views
{
    /// <summary>
    /// Interaction logic for DialogOverlayView.xaml
    /// </summary>
    public partial class DialogOverlayView : UserControl
    {
        public DialogOverlayView()
        {
            this.Visibility = Visibility.Hidden;
            InitializeComponent();
        }

        public void ToggleOverlay()
        {
            if (this.Visibility == Visibility.Visible)
            {
                this.Visibility = Visibility.Hidden;
            }
            else
            {
                this.Visibility = Visibility.Visible;
                BringToFront((Parent as Grid), this);
            }
        }

        public void SetDialogText(string text)
        {
            if (gridOverlayContent.Children.Count > 0)
            {
                // if we already have content, clear it.
                gridOverlayContent.Children.Clear();
            }

            TextBlock textBlock = new TextBlock
            {
                Text = text,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                Margin = new Thickness(3, 3, 3, 3)
            };

            gridOverlayContent.Children.Add(textBlock);
        }

        public void SetOverlayContent(UIElement content)
        {
            if (gridOverlayContent.Children.Count > 0)
            {
                // if we already have content, clear it.
                gridOverlayContent.Children.Clear();
            }

            gridOverlayContent.Children.Add(content);
        }

        public void ToggleLowerDismissButtonOnly()
        {
            if (rdButtonRow.Height == new GridLength(0))
            {
                btnAction2.Visibility = Visibility.Collapsed;
                btnAction1.Visibility = Visibility.Collapsed;
                btnDismiss.Visibility = Visibility.Visible;
                rdButtonRow.Height = new GridLength(30);
            }
            else
            {
                btnDismiss.Visibility = Visibility.Collapsed;
                rdButtonRow.Height = new GridLength(0);
            }
        }

        public void SetActionButtons(string action1Content = null, Action action1Function = null, string action2Content = null, Action action2Function = null)
        {
            // to use this button we require both parameters
            if (action1Content == null || action1Function == null)
            {
                btnAction1.Visibility = Visibility.Collapsed;
            }
            else
            {
                btnAction1.Visibility = Visibility.Visible;
                btnAction1.Click += ((s, e) => { action1Function(); });
                btnAction1.Content = action1Content;
            }

            // to use this button we require both parameters
            if (action2Content == null || action2Function == null)
            {
                btnAction2.Visibility = Visibility.Collapsed;
            }
            else
            {
                btnAction2.Visibility = Visibility.Visible;
                btnAction2.Click += ((s, e) => { action2Function(); });
                btnAction2.Content = action2Content;
            }

            // if either of our buttons are used, then show the row.
            if (btnAction1.Visibility == Visibility.Visible || btnAction2.Visibility == Visibility.Visible)
            {
                rdButtonRow.Height = new GridLength(30);
                btnDismiss.Visibility = Visibility.Visible;
            }
        }

        /// <summary>
        /// Button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DismissOverlay(object sender, RoutedEventArgs e)
        {
            ToggleOverlay();
        }

        private void BringToFront(Grid pParent, UserControl pToMove)
        {
            try
            {
                int currentIndex = Canvas.GetZIndex(pToMove);
                int zIndex = 0;
                int maxZ = 0;
                UserControl child;
                for (int i = 0; i < pParent.Children.Count; i++)
                {
                    if (pParent.Children[i] is UserControl &&
                        pParent.Children[i] != pToMove)
                    {
                        child = pParent.Children[i] as UserControl;
                        zIndex = Canvas.GetZIndex(child);
                        maxZ = Math.Max(maxZ, zIndex);
                        if (zIndex > currentIndex)
                        {
                            Canvas.SetZIndex(child, zIndex - 1);
                        }
                    }
                }
                Canvas.SetZIndex(pToMove, maxZ);
            }
            catch (Exception ex)
            {
            }
        }
    }
}