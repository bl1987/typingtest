using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TT.BL
{
    public class WordPerMinController
    {
        //Calculate words per min by getting one minute divide by total elapsed milliseconds from Stopwatch and multiply them by total word count
        private static int CalWordPerMin(RichTextBox text)
        {
            int count = WordCountController.GetWordCount(text);
            int minute = 60000;
            int time = (int)MyTimer.watch.ElapsedMilliseconds;
            return (count * minute / time);
        }
        //Set visibility of wordPerMin Label
        public static void SetVisibility(Label wpm, bool set)
        {
            wpm.Visible = set;
        }

        //Converts calculated word count per min and set it to WordPerMinLabel and switching it to visible
        public static void UpdateWordPerMin(RichTextBox text, Label wpm, Label wpmLabel)
        {
            wpm.Text = CalWordPerMin(text).ToString();
            SetVisibility(wpm, true);
            SetVisibility(wpmLabel, true);
        }
    }
}
