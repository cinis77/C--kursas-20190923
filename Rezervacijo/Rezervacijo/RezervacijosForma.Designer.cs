namespace Rezervacijo
{
    partial class RezervacijosForma
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.KryptisText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Search = new System.Windows.Forms.Button();
            this.Resultatas = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resultatas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Resultatas);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.KryptisText);
            this.panel1.Location = new System.Drawing.Point(13, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1538, 414);
            this.panel1.TabIndex = 0;
            // 
            // KryptisText
            // 
            this.KryptisText.Location = new System.Drawing.Point(123, 31);
            this.KryptisText.Name = "KryptisText";
            this.KryptisText.Size = new System.Drawing.Size(184, 29);
            this.KryptisText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kryptis";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(443, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(779, 12);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(222, 71);
            this.Search.TabIndex = 3;
            this.Search.Text = "Ieškoti";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Resultatas
            // 
            this.Resultatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Resultatas.Location = new System.Drawing.Point(22, 93);
            this.Resultatas.Name = "Resultatas";
            this.Resultatas.RowTemplate.Height = 31;
            this.Resultatas.Size = new System.Drawing.Size(1472, 281);
            this.Resultatas.TabIndex = 4;
            this.Resultatas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Resultatas_CellDoubleClick);
            // 
            // RezervacijosForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 833);
            this.Controls.Add(this.panel1);
            this.Name = "RezervacijosForma";
            this.Text = "RezervacijosForma";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resultatas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Resultatas;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KryptisText;
    }
}