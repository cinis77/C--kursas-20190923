namespace PaneleFormoje
{
    partial class Form2
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
            this.Tekstas1 = new System.Windows.Forms.TextBox();
            this.Tekstas2 = new System.Windows.Forms.TextBox();
            this.Mygtukas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tekstas1
            // 
            this.Tekstas1.Location = new System.Drawing.Point(105, 70);
            this.Tekstas1.Name = "Tekstas1";
            this.Tekstas1.Size = new System.Drawing.Size(215, 29);
            this.Tekstas1.TabIndex = 0;
            // 
            // Tekstas2
            // 
            this.Tekstas2.Location = new System.Drawing.Point(411, 70);
            this.Tekstas2.Name = "Tekstas2";
            this.Tekstas2.Size = new System.Drawing.Size(164, 29);
            this.Tekstas2.TabIndex = 1;
            // 
            // Mygtukas
            // 
            this.Mygtukas.Location = new System.Drawing.Point(478, 304);
            this.Mygtukas.Name = "Mygtukas";
            this.Mygtukas.Size = new System.Drawing.Size(163, 81);
            this.Mygtukas.TabIndex = 2;
            this.Mygtukas.Text = "Skaiciuoti";
            this.Mygtukas.UseVisualStyleBackColor = true;
            this.Mygtukas.Click += new System.EventHandler(this.Mygtukas_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mygtukas);
            this.Controls.Add(this.Tekstas2);
            this.Controls.Add(this.Tekstas1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tekstas1;
        private System.Windows.Forms.TextBox Tekstas2;
        private System.Windows.Forms.Button Mygtukas;
    }
}