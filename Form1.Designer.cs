namespace Feed_Rate_Adjuster
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            buttonBrowse = new Button();
            buttonRun = new Button();
            openFileDialog1 = new OpenFileDialog();
            labelCopyright = new Label();
            labelSelectFile = new Label();
            labelEnterFeedRate = new Label();
            textBoxFeedRate = new TextBox();
            labelInfoOne = new Label();
            labelInfoTwo = new Label();
            title = new Label();
            labelVersionNumber = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 46);
            label1.TabIndex = 10;
            // 
            // buttonBrowse
            // 
            buttonBrowse.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBrowse.Location = new Point(269, 162);
            buttonBrowse.Margin = new Padding(5, 6, 5, 6);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(129, 46);
            buttonBrowse.TabIndex = 1;
            buttonBrowse.Text = "Browse...";
            buttonBrowse.UseVisualStyleBackColor = true;
            // 
            // buttonRun
            // 
            buttonRun.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRun.Location = new Point(194, 322);
            buttonRun.Margin = new Padding(5, 6, 5, 6);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(129, 46);
            buttonRun.TabIndex = 2;
            buttonRun.Text = "Run";
            buttonRun.UseVisualStyleBackColor = true;
            // 
            // labelCopyright
            // 
            labelCopyright.AutoSize = true;
            labelCopyright.Font = new Font("Segoe UI Light", 8.142858F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCopyright.Location = new Point(355, 408);
            labelCopyright.Margin = new Padding(5, 0, 5, 0);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new Size(190, 28);
            labelCopyright.TabIndex = 4;
            labelCopyright.Text = "© 2025 Ashley Booth";
            // 
            // labelSelectFile
            // 
            labelSelectFile.AutoSize = true;
            labelSelectFile.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSelectFile.Location = new Point(41, 170);
            labelSelectFile.Margin = new Padding(5, 0, 5, 0);
            labelSelectFile.Name = "labelSelectFile";
            labelSelectFile.Size = new Size(188, 30);
            labelSelectFile.TabIndex = 5;
            labelSelectFile.Text = "Select G-code File:";
            // 
            // labelEnterFeedRate
            // 
            labelEnterFeedRate.AutoSize = true;
            labelEnterFeedRate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEnterFeedRate.Location = new Point(41, 242);
            labelEnterFeedRate.Margin = new Padding(5, 0, 5, 0);
            labelEnterFeedRate.Name = "labelEnterFeedRate";
            labelEnterFeedRate.Size = new Size(218, 30);
            labelEnterFeedRate.TabIndex = 6;
            labelEnterFeedRate.Text = "Enter New Feed Rate:";
            // 
            // textBoxFeedRate
            // 
            textBoxFeedRate.Location = new Point(269, 239);
            textBoxFeedRate.Margin = new Padding(5, 6, 5, 6);
            textBoxFeedRate.Name = "textBoxFeedRate";
            textBoxFeedRate.Size = new Size(169, 35);
            textBoxFeedRate.TabIndex = 7;
            // 
            // labelInfoOne
            // 
            labelInfoOne.AutoSize = true;
            labelInfoOne.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelInfoOne.Location = new Point(41, 78);
            labelInfoOne.Margin = new Padding(5, 0, 5, 0);
            labelInfoOne.Name = "labelInfoOne";
            labelInfoOne.Size = new Size(459, 30);
            labelInfoOne.TabIndex = 8;
            labelInfoOne.Text = "This application automatically changes the feed rate";
            // 
            // labelInfoTwo
            // 
            labelInfoTwo.AutoSize = true;
            labelInfoTwo.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelInfoTwo.Location = new Point(41, 108);
            labelInfoTwo.Margin = new Padding(5, 0, 5, 0);
            labelInfoTwo.Name = "labelInfoTwo";
            labelInfoTwo.Size = new Size(301, 30);
            labelInfoTwo.TabIndex = 9;
            labelInfoTwo.Text = "for [G2] and [G3] lines in G-code.";
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(41, 18);
            title.Margin = new Padding(5, 0, 5, 0);
            title.Name = "title";
            title.Size = new Size(304, 38);
            title.TabIndex = 11;
            title.Text = "FEED RATE ADJUSTER";
            // 
            // labelVersionNumber
            // 
            labelVersionNumber.AutoSize = true;
            labelVersionNumber.Font = new Font("Segoe UI Light", 8.142858F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelVersionNumber.Location = new Point(14, 408);
            labelVersionNumber.Margin = new Padding(5, 0, 5, 0);
            labelVersionNumber.Name = "labelVersionNumber";
            labelVersionNumber.Size = new Size(45, 28);
            labelVersionNumber.TabIndex = 12;
            labelVersionNumber.Text = "V1.0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 452);
            Controls.Add(labelVersionNumber);
            Controls.Add(title);
            Controls.Add(labelInfoTwo);
            Controls.Add(labelInfoOne);
            Controls.Add(textBoxFeedRate);
            Controls.Add(labelEnterFeedRate);
            Controls.Add(labelSelectFile);
            Controls.Add(labelCopyright);
            Controls.Add(buttonRun);
            Controls.Add(buttonBrowse);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Feed Rate Adjuster";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonBrowse;
        private Button buttonRun;
        private OpenFileDialog openFileDialog1;
        private Label labelCopyright;
        private Label labelSelectFile;
        private Label labelEnterFeedRate;
        private TextBox textBoxFeedRate;
        private Label labelInfoOne;
        private Label labelInfoTwo;
        private Label title;
        private Label labelVersionNumber;
    }
}
