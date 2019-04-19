using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TT.BL
{
    public class WordCountController
    {
        //Spliting text from textBox by ' ', '\r', '\n' and returning the length of words array
        public static int GetWordCount(TextBox text)
        {
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            string typedText = text.Text;
            int count = typedText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
            return count;
        }

        //inserting the word count from GetWordCount to wordCount label
        public static void UpdateWordCount(TextBox text, Label wordCount)
        {
            int count = GetWordCount(text);
            wordCount.Text = count.ToString();
        }

        public static string CalWordPerMin(TextBox text)
        {
            int count = GetWordCount(text);
            int minute = 60000;
            int time = (int)MyTimer.watch.ElapsedMilliseconds;
            return (count * minute / time).ToString();
        }

        public static void UpdateWordPerMin(TextBox text, Label wpm)
        {
            wpm.Text = CalWordPerMin(text);
            wpm.Visible = true;
        }
    }
}
