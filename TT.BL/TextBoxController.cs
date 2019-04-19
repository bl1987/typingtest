using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TT.BL
{
    public class TextBoxController
    {
        //Sets readOnly property of text box
        public static void SetReadOnly(RichTextBox text, bool set)
        {
            text.ReadOnly = set;
        }
        //Clears text box
        public static void ClearTextBox(RichTextBox text)
        {
            text.Clear();
        }
        //Compares char in textBox and sampleText and change the font color to red
        //Returns number of error made
        public static int ErrorCheck(RichTextBox text, TextBox sampleText)
        {
            int errorCount = 0;
            for (int i = 0; i < text.Text.Length - 1; i++)
            {
                if (text.Text[i] != sampleText.Text[i])
                {
                    text.Select(i, 1);
                    text.SelectionColor = Color.Red;
                    text.DeselectAll();
                    errorCount++;
                }
            }
            return errorCount;
        }
    }
}
