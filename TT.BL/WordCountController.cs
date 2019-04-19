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
        public static int GetWordCount(RichTextBox text)
        {
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            string typedText = text.Text;
            int count = typedText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
            return count;
        }

        //inserting the word count from GetWordCount to wordCount label
        public static void UpdateWordCount(RichTextBox text, Label wordCount)
        {
            int count = GetWordCount(text);
            wordCount.Text = count.ToString();
        }
    }
}
