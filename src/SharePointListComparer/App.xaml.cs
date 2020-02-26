using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SharePointListComparer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Constants
        public const string Directory = "\\config";

        public const string Filename = "\\configfile.txt";

        private void Application_Startup(object sender, StartupEventArgs e)
        {

        }
    }
}
