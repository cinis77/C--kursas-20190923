namespace SkaiciausKeitimasTekstoViduryje
{
    partial class IvedimasSkaciaus
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
            this.Ivestis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Ivestis
            // 
            this.Ivestis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Ivestis.Location = new System.Drawing.Point(13, 38);
            this.Ivestis.Name = "Ivestis";
            this.Ivestis.Size = new System.Drawing.Size(299, 55);
            this.Ivestis.TabIndex = 0;
            this.Ivestis.TextChanged += new System.EventHandler(this.Ivestis_TextChanged);
            // 
            // IvedimasSkaciaus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ivestis);
            this.Name = "IvedimasSkaciaus";
            this.Text = "IvedimasSkaciaus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Ivestis;
    }
}