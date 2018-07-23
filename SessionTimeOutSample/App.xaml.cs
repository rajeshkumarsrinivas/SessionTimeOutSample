using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SessionTimeOutSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        System.Windows.Threading.DispatcherTimer sessionTimer = new System.Windows.Threading.DispatcherTimer();

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            sessionTimer.Interval = TimeSpan.FromSeconds(10);
            sessionTimer.Tick += new EventHandler(sessionTimer_Tick);
            sessionTimer.Start();
        }

        void sessionTimer_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Session time out, the application will shutdown now");
            Application.Current.Shutdown();
        }

        public void ResetSessionTimer()
        {
            this.sessionTimer.Interval = TimeSpan.FromSeconds(10);
        }
    }
}
