namespace SuoniRepl
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
            btnPlay = new Button();
            btnStop = new Button();
            SuspendLayout();
            // 
            // BtnPlay
            // 
            btnPlay.Location = new Point(88, 80);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(283, 151);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // BtnStop
            // 
            btnStop.Location = new Point(600, 80);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(283, 151);
            btnStop.TabIndex = 1;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 391);
            Controls.Add(btnStop);
            Controls.Add(btnPlay);
            Name = "Form1";
            Text = "Riproduzione Suono";
            Load += btnPlay_Click;
            ResumeLayout(false);
        }

        #endregion

        private Button btnPlay;
        private Button btnStop;
    }
}