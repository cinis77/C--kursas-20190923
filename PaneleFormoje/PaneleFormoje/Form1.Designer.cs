namespace PaneleFormoje
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
            this.DidelePanele = new System.Windows.Forms.Panel();
            this.MazaPanele = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // DidelePanele
            // 
            this.DidelePanele.Location = new System.Drawing.Point(639, 57);
            this.DidelePanele.Name = "DidelePanele";
            this.DidelePanele.Size = new System.Drawing.Size(807, 827);
            this.DidelePanele.TabIndex = 0;
            // 
            // MazaPanele
            // 
            this.MazaPanele.Location = new System.Drawing.Point(27, 57);
            this.MazaPanele.Name = "MazaPanele";
            this.MazaPanele.Size = new System.Drawing.Size(545, 354);
            this.MazaPanele.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 941);
            this.Controls.Add(this.MazaPanele);
            this.Controls.Add(this.DidelePanele);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DidelePanele;
        private System.Windows.Forms.Panel MazaPanele;
    }
}

