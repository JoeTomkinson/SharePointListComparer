using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using SharePointListComparer.Models;
using SharePointListComparer.Storage;
using SharePointListComparer.Utilities;

namespace SharePointListComparer.Views
{
    /// <summary>
    /// Interaction logic for SettingsView.xaml
    /// </summary>
    public partial class SettingsView : UserControl
    {
        public SettingsView()
        {
            InitializeComponent();

            var spInfo = ApplicationState.GetValue<SharePointInformation>("SharePointInformation");

            // we only need to check if one exists, as this form only submits data if all three are provided.
            if (spInfo != null && !string.IsNullOrEmpty(spInfo?.Username))
            {
                tbSPPasssword.Password = PortableCryptography.Decrypt(spInfo.EncryptedPassword, spInfo.Username);
                tbSPUsername.Text = spInfo.Username;
                tbSiteURL.Text = spInfo.SiteUrl;
                chkOnline.IsChecked = spInfo.IsSharePointOnline;
                chkRemember.IsChecked = ApplicationState.GetValue<bool>("RememberMe");
                ApplicationState.SetValue("ShowOnlineButton", true);
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            tbSPPasssword.IsEnabled = false;
            tbSPUsername.IsEnabled = false;
            tbSiteURL.IsEnabled = false;

            if (ValidateInputs())
            {
                var pass = tbSPPasssword.Password;
                var user = tbSPUsername.Text.TrimEnd().TrimStart();
                var url = tbSiteURL.Text.TrimEnd().TrimStart();

                // encrypt sensitive information.
                var encryptedPass = PortableCryptography.Encrypt(pass, user);

                SharePointInformation sharePointInformation = new SharePointInformation
                {
                    EncryptedPassword = encryptedPass,
                    SiteUrl = url,
                    Username = user,
                    IsSharePointOnline = (bool)chkOnline.IsChecked
                };

                // Store information to memory.
                ApplicationState.SetValue("SharePointInformation", sharePointInformation);

                var currDirectory = Environment.CurrentDirectory;
                var directoryPath = currDirectory + App.Directory;
                var fileName = directoryPath + App.Filename;

                if (chkRemember.IsChecked == true)
                {
                    // In order to remember, we need to store an encrypted configuration file.
                    var json = JsonConvert.SerializeObject(sharePointInformation);
                    var encryptedJson = PortableCryptography.Encrypt(json, "StoredValues");
                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }
                    File.WriteAllText(fileName, encryptedJson);
                    ApplicationState.SetValue("RememberMe", true);
                }
                else
                {
                    if (Directory.Exists(directoryPath))
                    {
                        if (File.Exists(fileName))
                        {
                            File.Delete(fileName);
                        }
                    }
                    ApplicationState.SetValue("RememberMe", false);
                }

                ApplicationState.SetValue("ShowOnlineButton", true);

                RootWindow.MessageQueue.Enqueue("SharePoint information successfully saved.");
            }

            tbSPPasssword.IsEnabled = true;
            tbSPUsername.IsEnabled = true;
            tbSiteURL.IsEnabled = true;
        }

        private void btnBackNav_Click(object sender, RoutedEventArgs e)
        {
            RootWindow.RemoveFromMainContentView(this);
        }

        private bool ValidateInputs()
        {
            var pass = tbSPPasssword.Password;
            var user = tbSPUsername.Text.TrimEnd().TrimStart();
            var url = tbSiteURL.Text.TrimEnd().TrimStart();
            var passProvided = !string.IsNullOrEmpty(pass);
            var userProvided = !string.IsNullOrEmpty(user);
            var siteProvided = !string.IsNullOrEmpty(url);

            bool? isOnline = chkOnline.IsChecked;

            if (!passProvided || !userProvided || !siteProvided || isOnline == null)
            {
                SetWarnings(!passProvided, !userProvided, !siteProvided, isOnline == null);
                RootWindow.MessageQueue.Enqueue("Please ensure all fields are populated.");
                return false;
            }

            SetWarnings();
            return true;
        }

        private void SetWarnings(bool pass = false, bool user = false, bool site = false, bool isOnline = false)
        {
            userWarning.Visibility = user ? Visibility.Visible : Visibility.Hidden;
            siteWarning.Visibility = site ? Visibility.Visible : Visibility.Hidden;
            passWarning.Visibility = pass ? Visibility.Visible : Visibility.Hidden;
            isOnlineWarning.Visibility = isOnline ? Visibility.Visible : Visibility.Hidden;
        }

        private void tbSPPasssword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            // password contains spaces warn the user.
            if (tbSPPasssword.Password.Contains(" "))
            {
                passSpaceWarning.Visibility = Visibility.Visible;
            }
            else
            {
                passSpaceWarning.Visibility = Visibility.Hidden;
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            ApplicationState.Remove("SharePointInformation");
            ApplicationState.SetValue("RememberMe", false);
            var currDirectory = Environment.CurrentDirectory;
            var directoryPath = currDirectory + App.Directory;
            var fileName = directoryPath + App.Filename;
            if (Directory.Exists(directoryPath))
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
            }
            ApplicationState.SetValue("ShowOnlineButton", false);

            tbSiteURL.Clear();
            tbSPPasssword.Clear();
            tbSPUsername.Clear();
            chkOnline.IsChecked = null;
            chkRemember.IsChecked = null;

            RootWindow.MessageQueue.Enqueue("All SharePoint information successfully Erased.");
        }
    }
}
