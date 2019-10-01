namespace SkaiciausKeitimasTekstoViduryje
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
            this.TekstoPanele = new System.Windows.Forms.Panel();
            this.IvedimoPanele = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TekstoPanele
            // 
            this.TekstoPanele.Location = new System.Drawing.Point(13, 13);
            this.TekstoPanele.Name = "TekstoPanele";
            this.TekstoPanele.Size = new System.Drawing.Size(826, 425);
            this.TekstoPanele.TabIndex = 0;
            // 
            // IvedimoPanele
            // 
            this.IvedimoPanele.Location = new System.Drawing.Point(845, 12);
            this.IvedimoPanele.Name = "IvedimoPanele";
            this.IvedimoPanele.Size = new System.Drawing.Size(473, 425);
            this.IvedimoPanele.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 450);
            this.Controls.Add(this.IvedimoPanele);
            this.Controls.Add(this.TekstoPanele);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TekstoPanele;
        private System.Windows.Forms.Panel IvedimoPanele;
    }
}

