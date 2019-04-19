using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace TT.BL
{
    public class TimerController
    {
        //When user starts typing
        public static void StartTimer(Timer timer)
        {
            MyTimer.watch.Start();
            timer.Enabled = true;
        }

        //When typed text length match sample text length
        public static void StopTimer(Timer timer)
        {
            MyTimer.watch.Stop();
            timer.Enabled = false;
        }

        //When Reset button was pressed
        public static void ResetTimer(Timer timer)
        {
            MyTimer.watch.Reset();
            StopTimer(timer);
        }

        //Getting current time from Timer
        public static string GetTime(TimeSpan elapsed)
        {
            string time = $"{elapsed.Minutes:00}:{elapsed.Seconds:00}.{elapsed.Milliseconds:000}";
            return time;
        }

        //Updating the Timer on UI
        public static void UpdateTimer(Label timer)
        {
            timer.Text = GetTime(MyTimer.watch.Elapsed);
        }
    }
}
