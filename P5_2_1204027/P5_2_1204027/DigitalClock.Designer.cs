namespace P5_2_1204027
{
    partial class DigitalClock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LocalTimerLabel = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LocalTimerLabel
            // 
            this.LocalTimerLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LocalTimerLabel.Location = new System.Drawing.Point(3, 54);
            this.LocalTimerLabel.Name = "LocalTimerLabel";
            this.LocalTimerLabel.Size = new System.Drawing.Size(133, 27);
            this.LocalTimerLabel.TabIndex = 0;
            this.LocalTimerLabel.Text = "\"\"";
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // DigitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LocalTimerLabel);
            this.Name = "DigitalClock";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LocalTimerLabel;
        private System.Windows.Forms.Timer Timer1;
    }
}
