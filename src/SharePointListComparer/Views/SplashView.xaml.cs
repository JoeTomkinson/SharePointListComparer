using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using SharePointListComparer.Models;
using SharePointListComparer.Storage;
using SharePointListComparer.Utilities;

namespace SharePointListComparer.Views
{
    /// <summary>
    /// Interaction logic for SpashView.xaml
    /// </summary>
    public partial class SplashView : UserControl
    {
        public SplashView()
        {
            InitializeComponent();


            CheckForSharePointInfo();

            Task.Run(async () => 
            {
                await Task.Delay(3000);
                Dispatcher.Invoke(() => {
                    FadeFromTo(this, 1, 0, 1000, false, false, true);
                });
                await Task.Delay(1500);

                Dispatcher.Invoke(() => {
                    RootWindow.RemoveFromMainContentView(this);
                    var mainview = new MainView
                    {
                        Opacity = 0
                    };
                    RootWindow.AddToMainContentView(mainview);
                    FadeFromTo(mainview, 0, 1, 500, false, true, false);
                });
            });
        }

        private void CheckForSharePointInfo()
        {
            // start with a false remember me value
            ApplicationState.SetValue("RememberMe", false);

            // Check IO
            var currDirectory = Environment.CurrentDirectory;
            var directoryPath = currDirectory + App.Directory;
            var fileName = directoryPath + App.Filename;
            var encryptedJson = string.Empty;

            try
            {
                encryptedJson = File.ReadAllText(fileName);
            }
            catch
            {
                ApplicationState.SetValue("ShowOnlineButton", false);
                return;
            }

            var decryptedJson = PortableCryptography.Decrypt(encryptedJson, "StoredValues");
            var sharePointInfo = JsonConvert.DeserializeObject<SharePointInformation>(decryptedJson);
            if (sharePointInfo != null && !string.IsNullOrEmpty(sharePointInfo?.Username))
            {
                ApplicationState.SetValue("SharePointInformation", sharePointInfo);
                ApplicationState.SetValue("RememberMe", true);
                ApplicationState.SetValue("ShowOnlineButton", true);
            }
        }

        private void FadeFromTo(UIElement uIElement, double fromOpacity,
        double toOpacity, int durationInMilliseconds, bool loopAnimation,
        bool showOnStart, bool collapseOnFinish)
        {
            var timeSpan = TimeSpan.FromMilliseconds(durationInMilliseconds);
            var doubleAnimation =
                  new DoubleAnimation(fromOpacity, toOpacity,
                                      new Duration(timeSpan));
            if (loopAnimation)
                doubleAnimation.RepeatBehavior = RepeatBehavior.Forever;
            uIElement.BeginAnimation(UIElement.OpacityProperty, doubleAnimation);
            if (showOnStart)
            {
                uIElement.ApplyAnimationClock(UIElement.VisibilityProperty, null);
                uIElement.Visibility = Visibility.Visible;
            }
            if (collapseOnFinish)
            {
                var keyAnimation = new ObjectAnimationUsingKeyFrames { Duration = new Duration(timeSpan) };
                keyAnimation.KeyFrames.Add(new DiscreteObjectKeyFrame(Visibility.Collapsed, KeyTime.FromTimeSpan(timeSpan)));
                uIElement.BeginAnimation(UIElement.VisibilityProperty, keyAnimation);
            }
        }
    }
}