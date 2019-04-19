namespace TT.UI
{
    partial class TypingTest
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox = new System.Windows.Forms.TextBox();
            this.sampleText = new System.Windows.Forms.TextBox();
            this.instruction = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Label();
            this.wordCountLabel = new System.Windows.Forms.Label();
            this.wordCount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.sampleText);
            this.panel1.Location = new System.Drawing.Point(13, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 117);
            this.panel1.TabIndex = 0;
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox.Location = new System.Drawing.Point(13, 158);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(398, 131);
            this.textBox.TabIndex = 1;
            // 
            // sampleText
            // 
            this.sampleText.BackColor = System.Drawing.SystemColors.Control;
            this.sampleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sampleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sampleText.Location = new System.Drawing.Point(3, 4);
            this.sampleText.Multiline = true;
            this.sampleText.Name = "sampleText";
            this.sampleText.ShortcutsEnabled = false;
            this.sampleText.Size = new System.Drawing.Size(403, 106);
            this.sampleText.TabIndex = 0;
            this.sampleText.Text = "As long as you keep going, you\'ll keep getting better. And as you get better, you" +
    " gain more confidence. That alone is success.";
            // 
            // instruction
            // 
            this.instruction.AutoSize = true;
            this.instruction.Location = new System.Drawing.Point(444, 35);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(177, 13);
            this.instruction.TabIndex = 2;
            this.instruction.Text = "Start typing sample text to begin test";
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timer.Location = new System.Drawing.Point(430, 73);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(206, 37);
            this.timer.TabIndex = 3;
            this.timer.Text = "00:00:00.000";
            // 
            // wordCountLabel
            // 
            this.wordCountLabel.AutoSize = true;
            this.wordCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.wordCountLabel.Location = new System.Drawing.Point(479, 132);
            this.wordCountLabel.Name = "wordCountLabel";
            this.wordCountLabel.Size = new System.Drawing.Size(102, 20);
            this.wordCountLabel.TabIndex = 4;
            this.wordCountLabel.Text = "Word Count :";
            // 
            // wordCount
            // 
            this.wordCount.AutoSize = true;
            this.wordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.wordCount.Location = new System.Drawing.Point(505, 160);
            this.wordCount.Name = "wordCount";
            this.wordCount.Size = new System.Drawing.Size(36, 26);
            this.wordCount.TabIndex = 5;
            this.wordCount.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 301);
            this.Controls.Add(this.wordCount);
            this.Controls.Add(this.wordCountLabel);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox sampleText;
        private System.Windows.Forms.Label instruction;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Label wordCountLabel;
        private System.Windows.Forms.Label wordCount;
    }
}

