namespace Zadatak01
{
    partial class Task01
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.digitalClock1 = new Zadatak01.DigitalClock();
            this.digitalClock2 = new Zadatak01.DigitalClock();
            this.digitalClock3 = new Zadatak01.DigitalClock();
            this.SuspendLayout();
            // 
            // digitalClock1
            // 
            this.digitalClock1.BackColor = System.Drawing.Color.Firebrick;
            this.digitalClock1.BackgroundColor = System.Drawing.Color.Firebrick;
            this.digitalClock1.Location = new System.Drawing.Point(119, 27);
            this.digitalClock1.Name = "digitalClock1";
            this.digitalClock1.NumbersColor = System.Drawing.Color.Yellow;
            this.digitalClock1.ShowHundreds = true;
            this.digitalClock1.Size = new System.Drawing.Size(596, 165);
            this.digitalClock1.TabIndex = 0;
            // 
            // digitalClock2
            // 
            this.digitalClock2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.digitalClock2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.digitalClock2.Location = new System.Drawing.Point(183, 246);
            this.digitalClock2.Name = "digitalClock2";
            this.digitalClock2.NumbersColor = System.Drawing.SystemColors.ControlText;
            this.digitalClock2.ShowHundreds = false;
            this.digitalClock2.Size = new System.Drawing.Size(476, 162);
            this.digitalClock2.TabIndex = 1;
            // 
            // digitalClock3
            // 
            this.digitalClock3.BackgroundColor = System.Drawing.Color.Empty;
            this.digitalClock3.Location = new System.Drawing.Point(140, 91);
            this.digitalClock3.Name = "digitalClock3";
            this.digitalClock3.NumbersColor = System.Drawing.SystemColors.ControlText;
            this.digitalClock3.ShowHundreds = false;
            this.digitalClock3.Size = new System.Drawing.Size(609, 271);
            this.digitalClock3.TabIndex = 0;
            // 
            // Task01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 495);
            this.Controls.Add(this.digitalClock3);
            this.Name = "Task01";
            this.Text = "Task01";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DigitalClock digitalClock1;
        private DigitalClock digitalClock2;
        private DigitalClock digitalClock3;
    }
}

