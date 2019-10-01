namespace PaneleFormoje
{
    partial class Form3
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
            this.Atsakymas = new System.Windows.Forms.Label();
            this.Atsakymas2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Atsakymas
            // 
            this.Atsakymas.AutoSize = true;
            this.Atsakymas.Location = new System.Drawing.Point(139, 146);
            this.Atsakymas.Name = "Atsakymas";
            this.Atsakymas.Size = new System.Drawing.Size(109, 25);
            this.Atsakymas.TabIndex = 0;
            this.Atsakymas.Text = "Atsakymas";
            // 
            // Atsakymas2
            // 
            this.Atsakymas2.AutoSize = true;
            this.Atsakymas2.Location = new System.Drawing.Point(144, 238);
            this.Atsakymas2.Name = "Atsakymas2";
            this.Atsakymas2.Size = new System.Drawing.Size(109, 25);
            this.Atsakymas2.TabIndex = 1;
            this.Atsakymas2.Text = "Atsakymas";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Atsakymas2);
            this.Controls.Add(this.Atsakymas);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Atsakymas;
        private System.Windows.Forms.Label Atsakymas2;
    }
}