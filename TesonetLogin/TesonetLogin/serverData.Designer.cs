namespace TesonetLogin
{
    partial class serverData
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
            this.Serveriai = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Serveriai)).BeginInit();
            this.SuspendLayout();
            // 
            // Serveriai
            // 
            this.Serveriai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Serveriai.Location = new System.Drawing.Point(62, 23);
            this.Serveriai.Name = "Serveriai";
            this.Serveriai.RowTemplate.Height = 31;
            this.Serveriai.Size = new System.Drawing.Size(667, 477);
            this.Serveriai.TabIndex = 0;
            // 
            // serverData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.Serveriai);
            this.Name = "serverData";
            this.Text = "serverData";
            this.Load += new System.EventHandler(this.serverData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Serveriai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Serveriai;
    }
}