using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Timer
{
    internal class Presentation
    {
        Model model = null;
        MainWindow mainWindow = null;
        System.Timers.Timer timer = new System.Timers.Timer();
        public Presentation(MainWindow mainWindow)
        {
            this.model = new Model();
            this.mainWindow = mainWindow;
            this.mainWindow.Start += new EventHandler(StartHandler);
            this.mainWindow.Stop += new EventHandler(StopHandler);
            this.mainWindow.Reset += new EventHandler(ResetHandler);
            timer.Interval = 100;
            timer.Elapsed += TimerTick;
            timer.Start();
        }

        private void TimerTick(object sender, ElapsedEventArgs e)
        {
            mainWindow.MonitorBlock.Dispatcher.Invoke(new Action(() => mainWindow.MonitorBlock.Text = model.CurrentTime()));
        }
        private void StartHandler(object sender, EventArgs e)
        {
            string s = "Start";
                mainWindow.MonitorBlock.Text = model.CurrentTime(s);
        }
        private void StopHandler(object sender, EventArgs e)
        {
            string s = "Stop";
                mainWindow.MonitorBlock.Text = model.CurrentTime(s);
        }
        private void ResetHandler(object sender, EventArgs e)
        {
            string s = "Reset";
                mainWindow.MonitorBlock.Text = model.CurrentTime(s);
        }

        
    }
}
