using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace zenZoneApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private Tray tray;

        public App()
        {
            tray = new Tray();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            tray.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            tray.OnExit();
        }
    }
}
