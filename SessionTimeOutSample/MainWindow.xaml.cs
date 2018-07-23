using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using System.Drawing;
using System.Threading;
using System.Windows.Interop;
using System.Windows.Threading;

namespace SessionTimeOutSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EventHandler handler;
        //private TimeSpan idleTime = new TimeSpan(1);
        private InactivityTimer _inactivityTimer;

        private delegate void WindowClose();
        
        public MainWindow()
        {
            InitializeComponent();
            _inactivityTimer = new InactivityTimer(TimeSpan.FromSeconds(10));
            _inactivityTimer.Inactivity += InactivityDetected;
            
            //System.Windows.Threading.Dispatcher.CurrentDispatcher.Hooks.DispatcherInactive += delegate
            //{
            //    System.Timers.Timer timer = new System.Timers.Timer();
            //    timer.Interval = 2000;
            //    timer.Elapsed += delegate
            //    {
            //        timer.Stop();
            //        timer.Dispose();
            //        timer = null;
            //        System.Windows.Threading.Dispatcher.CurrentDispatcher.Hooks.DispatcherInactive += null;
            //        MessageBox.Show("You get caught!");
            //    };

            //    timer.Start();

            //    System.Windows.Threading.Dispatcher.CurrentDispatcher.Hooks.OperationPosted += delegate
            //    {
            //        System.Windows.Threading.Dispatcher.CurrentDispatcher.Hooks.DispatcherInactive += null;
            //        if (timer != null)
            //        {
            //            timer.Stop();
            //            timer.Dispose();
            //            timer = null;
            //            System.Windows.Threading.Dispatcher.CurrentDispatcher.Hooks.DispatcherInactive += null;
            //        }
            //    };

            //};

        }
       

        void InactivityDetected(object sender, EventArgs e)
        {
            //  Take action - e.g. close the window            
            MessageBox.Show("InActive");            
        }

        void Window_Closed(object sender, EventArgs e)
        {
            // The instance MUST be disposed to avoid memory leak
            _inactivityTimer.Dispose();
        }


    }
}

              
