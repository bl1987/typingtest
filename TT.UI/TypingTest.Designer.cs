﻿namespace TT.UI
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sampleText = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.instruction = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Label();
            this.wordCountLabel = new System.Windows.Forms.Label();
            this.wordCount = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.sampleTextLabel = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.wordPerMinLabel = new System.Windows.Forms.Label();
            this.wordPerMin = new System.Windows.Forms.Label();
            this.accuracy = new System.Windows.Forms.Label();
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
            // sampleText
            // 
            this.sampleText.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.sampleText.BackColor = System.Drawing.SystemColors.Control;
            this.sampleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sampleText.CausesValidation = false;
            this.sampleText.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sampleText.Location = new System.Drawing.Point(3, 4);
            this.sampleText.Multiline = true;
            this.sampleText.Name = "sampleText";
            this.sampleText.ReadOnly = true;
            this.sampleText.ShortcutsEnabled = false;
            this.sampleText.Size = new System.Drawing.Size(393, 106);
            this.sampleText.TabIndex = 1;
            this.sampleText.TabStop = false;
            this.sampleText.Text = "As long as you keep going, you\'ll keep getting better. And as you get better, you" +
    " gain more confidence. That alone is success.";
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(13, 158);
            this.textBox.Name = "textBox";
            this.textBox.ShortcutsEnabled = false;
            this.textBox.Size = new System.Drawing.Size(398, 131);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "";
            this.textBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // instruction
            // 
            this.instruction.AutoSize = true;
            this.instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.instruction.Location = new System.Drawing.Point(434, 41);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(202, 15);
            this.instruction.TabIndex = 2;
            this.instruction.Text = "Start typing sample text to begin test";
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timer.Location = new System.Drawing.Point(452, 67);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(161, 37);
            this.timer.TabIndex = 3;
            this.timer.Text = "00:00.000";
            // 
            // wordCountLabel
            // 
            this.wordCountLabel.AutoSize = true;
            this.wordCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.wordCountLabel.Location = new System.Drawing.Point(482, 111);
            this.wordCountLabel.Name = "wordCountLabel";
            this.wordCountLabel.Size = new System.Drawing.Size(102, 20);
            this.wordCountLabel.TabIndex = 4;
            this.wordCountLabel.Text = "Word Count :";
            // 
            // wordCount
            // 
            this.wordCount.AutoSize = true;
            this.wordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.wordCount.Location = new System.Drawing.Point(513, 131);
            this.wordCount.Name = "wordCount";
            this.wordCount.Size = new System.Drawing.Size(36, 26);
            this.wordCount.TabIndex = 5;
            this.wordCount.Text = "00";
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.resetBtn.Location = new System.Drawing.Point(546, 257);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 32);
            this.resetBtn.TabIndex = 1;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // sampleTextLabel
            // 
            this.sampleTextLabel.AutoSize = true;
            this.sampleTextLabel.Location = new System.Drawing.Point(12, 19);
            this.sampleTextLabel.Name = "sampleTextLabel";
            this.sampleTextLabel.Size = new System.Drawing.Size(66, 13);
            this.sampleTextLabel.TabIndex = 6;
            this.sampleTextLabel.Text = "Sample Text";
            // 
            // time
            // 
            this.time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // wordPerMinLabel
            // 
            this.wordPerMinLabel.AutoSize = true;
            this.wordPerMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.wordPerMinLabel.Location = new System.Drawing.Point(464, 164);
            this.wordPerMinLabel.Name = "wordPerMinLabel";
            this.wordPerMinLabel.Size = new System.Drawing.Size(135, 20);
            this.wordPerMinLabel.TabIndex = 7;
            this.wordPerMinLabel.Text = "Word Per Minute :";
            this.wordPerMinLabel.Visible = false;
            // 
            // wordPerMin
            // 
            this.wordPerMin.AutoSize = true;
            this.wordPerMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.wordPerMin.Location = new System.Drawing.Point(513, 184);
            this.wordPerMin.Name = "wordPerMin";
            this.wordPerMin.Size = new System.Drawing.Size(36, 26);
            this.wordPerMin.TabIndex = 8;
            this.wordPerMin.Text = "00";
            this.wordPerMin.Visible = false;
            // 
            // accuracy
            // 
            this.accuracy.AutoSize = true;
            this.accuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.accuracy.Location = new System.Drawing.Point(432, 212);
            this.accuracy.Name = "accuracy";
            this.accuracy.Size = new System.Drawing.Size(194, 26);
            this.accuracy.TabIndex = 9;
            this.accuracy.Text = "Accuracy : 100.0%";
            this.accuracy.Visible = false;
            // 
            // TypingTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 301);
            this.Controls.Add(this.accuracy);
            this.Controls.Add(this.wordPerMin);
            this.Controls.Add(this.wordPerMinLabel);
            this.Controls.Add(this.sampleTextLabel);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.wordCount);
            this.Controls.Add(this.wordCountLabel);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.panel1);
            this.Name = "TypingTest";
            this.Text = "Typing Test";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.TextBox sampleText;
        private System.Windows.Forms.Label instruction;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Label wordCountLabel;
        private System.Windows.Forms.Label wordCount;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label sampleTextLabel;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Label wordPerMinLabel;
        private System.Windows.Forms.Label wordPerMin;
        private System.Windows.Forms.Label accuracy;
    }
}

