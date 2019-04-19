using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TT.BL
{
    public class accuracyController
    {
        //Calculates error percentage and return percentage of charictors user typed right
        private static string CalErrorPercentage(RichTextBox text, TextBox sampleText)
        {
            decimal errors = (decimal)TextBoxController.ErrorCheck(text, sampleText);
            decimal totalText = (decimal)text.Text.Length;
            return Math.Round(100 - 100 * (errors / totalText), 1) + "%";
        }

        //Set visibility for errorPercentage
        public static void SetVisibility(Label label, bool set)
        {
            label.Visible = set;
        }
        public static void UpdateErrorPercentage(Label label, RichTextBox text, TextBox sampleText)
        {
            label.Text = "Accuracy : " + CalErrorPercentage(text, sampleText);
            SetVisibility(label, true);
        }
    }
}
