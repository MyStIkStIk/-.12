using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;
using System.Windows.Controls;
using System.Diagnostics;

namespace Timer
{
    internal class Model
    {
        private readonly Stopwatch stopwatch = new Stopwatch();
        public string CurrentTime()
        {
            return stopwatch.Elapsed.ToString("mm\\:ss");
        }
        public string CurrentTime(string sender)
        {
            if (sender == "Start")
            {
                stopwatch.Start();
            }
            else if (sender == "Stop")
            {
                stopwatch.Stop();
            }
            else if (sender == "Reset")
            {
                stopwatch.Reset();
            }
            return stopwatch.Elapsed.ToString("mm\\:ss"); ;
        }
    }
}
