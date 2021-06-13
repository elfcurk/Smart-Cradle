namespace arduinohaberlesme
{
    partial class Anasayfa
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
            this.components = new System.ComponentModel.Container();
            this.arduino = new System.IO.Ports.SerialPort(this.components);
            this.mesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // arduino
            // 
            this.arduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Ardu_DataReceived);
            // 
            // mesaj
            // 
            this.mesaj.AutoSize = true;
            this.mesaj.Location = new System.Drawing.Point(12, 9);
            this.mesaj.Name = "mesaj";
            this.mesaj.Size = new System.Drawing.Size(35, 13);
            this.mesaj.TabIndex = 0;
            this.mesaj.Text = "label1";
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 477);
            this.Controls.Add(this.mesaj);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort arduino;
        private System.Windows.Forms.Label mesaj;
    }
}

