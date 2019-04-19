using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TT.BL;

namespace TT.UI
{
    public partial class TypingTest : Form
    {
        bool reset;
        //Sets reset to false for TextBox_TextChanged fuction to start timer when user start typing
        public TypingTest()
        {
            InitializeComponent();
            reset = false;
            TimerController.UpdateTimer(timer);
        }

        //Detect when ever user type something in textBox. 
        //When resetBtn is clicked, only run reset sequence
        //Trigger timer when it is not running
        //Stops the timer and disable textBox when length of textBox is same as length of sampleText
        //Disables textBox when user is done typing
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            WordCountController.UpdateWordCount(textBox, wordCount);
            if (reset)
            {
                TimerController.UpdateTimer(timer);
                reset = false;
                return;
            }
            else
            {
                if (!MyTimer.watch.IsRunning)
                {
                    TimerController.StartTimer(time);
                }
                if (textBox.Text.Length == sampleText.Text.Length)
                {
                    TimerController.StopTimer(time);
                    TextBoxController.SetReadOnly(textBox, true);
                    WordPerMinController.UpdateWordPerMin(textBox, wordPerMin, wordPerMinLabel);
                    accuracyController.UpdateErrorPercentage(accuracy, textBox, sampleText);
                }
            }
        }

        //UpdateTimer when timer is running
        private void Time_Tick(object sender, EventArgs e)
        {
            TimerController.UpdateTimer(timer);
        }

        //Clicking ResetBtn will set reset to true so that when textBox change, it will not start timer again
        //This will reset the timer, clear the textBox, set readOnly for textBox to false, and switch visiblity of wordPerMin to false
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            reset = true;
            TimerController.ResetTimer(time);
            TextBoxController.ClearTextBox(textBox);
            TextBoxController.SetReadOnly(textBox, false);
            accuracyController.SetVisibility(accuracy, false);
            WordPerMinController.SetVisibility(wordPerMinLabel, false);
            WordPerMinController.SetVisibility(wordPerMin, false);
        }
    }
}
