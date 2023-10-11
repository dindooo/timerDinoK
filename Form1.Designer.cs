namespace timerDinoK
{
    partial class Form1
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
            this.lblTrenutno = new System.Windows.Forms.Label();
            this.lblVrijeme = new System.Windows.Forms.Label();
            this.tmrSad = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTrenutno
            // 
            this.lblTrenutno.AutoSize = true;
            this.lblTrenutno.Location = new System.Drawing.Point(40, 42);
            this.lblTrenutno.Name = "lblTrenutno";
            this.lblTrenutno.Size = new System.Drawing.Size(95, 13);
            this.lblTrenutno.TabIndex = 0;
            this.lblTrenutno.Text = "Trenutno vrijeme : ";
            // 
            // lblVrijeme
            // 
            this.lblVrijeme.AutoSize = true;
            this.lblVrijeme.Location = new System.Drawing.Point(40, 83);
            this.lblVrijeme.Name = "lblVrijeme";
            this.lblVrijeme.Size = new System.Drawing.Size(35, 13);
            this.lblVrijeme.TabIndex = 1;
            this.lblVrijeme.Text = "label2";
            // 
            // tmrSad
            // 
            this.tmrSad.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVrijeme);
            this.Controls.Add(this.lblTrenutno);
            this.Name = "Form1";
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrenutno;
        private System.Windows.Forms.Label lblVrijeme;
        private System.Windows.Forms.Timer tmrSad;
    }
}

