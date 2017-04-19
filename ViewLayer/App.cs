using ApplicationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ViewLayer
{
    class App : Application
    {
        [STAThread]
        static void Main()
        {
            App app = new App();

            MainWindow appView = new MainWindow();
            appView.DataContext = new VolumeLoadViewModel();

            app.Run(appView);
        }
    }
}
