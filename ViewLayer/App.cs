using ApplicationLayer;
using System;
using System.Windows;

namespace ViewLayer
{
    internal class App : Application
    {
        [STAThread]
        private static void Main()
        {
            App app = new App();

            MainWindow appView = new MainWindow();
            appView.DataContext = new VolumeLoadViewModel();

            app.Run(appView);
        }
    }
}