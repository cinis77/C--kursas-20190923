namespace WindowsFormsApp1
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
            this.Tabai = new System.Windows.Forms.TabControl();
            this.PirmasTab = new System.Windows.Forms.TabPage();
            this.NewTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Tabai.SuspendLayout();
            this.PirmasTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabai
            // 
            this.Tabai.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.Tabai.Controls.Add(this.PirmasTab);
            this.Tabai.Controls.Add(this.NewTab);
            this.Tabai.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.Tabai.Location = new System.Drawing.Point(35, 23);
            this.Tabai.Name = "Tabai";
            this.Tabai.SelectedIndex = 0;
            this.Tabai.Size = new System.Drawing.Size(1870, 900);
            this.Tabai.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Tabai.TabIndex = 0;
            this.Tabai.SelectedIndexChanged += new System.EventHandler(this.Tabai_SelectedIndexChanged);
            // 
            // PirmasTab
            // 
            this.PirmasTab.BackColor = System.Drawing.SystemColors.Control;
            this.PirmasTab.Controls.Add(this.button1);
            this.PirmasTab.Location = new System.Drawing.Point(4, 4);
            this.PirmasTab.Name = "PirmasTab";
            this.PirmasTab.Padding = new System.Windows.Forms.Padding(3);
            this.PirmasTab.Size = new System.Drawing.Size(1862, 863);
            this.PirmasTab.TabIndex = 0;
            this.PirmasTab.Text = "Pirmas";
            // 
            // NewTab
            // 
            this.NewTab.Location = new System.Drawing.Point(4, 4);
            this.NewTab.Name = "NewTab";
            this.NewTab.Padding = new System.Windows.Forms.Padding(3);
            this.NewTab.Size = new System.Drawing.Size(1862, 863);
            this.NewTab.TabIndex = 1;
            this.NewTab.Text = "Naujas";
            this.NewTab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 102);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1984, 1008);
            this.Controls.Add(this.Tabai);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Tabai.ResumeLayout(false);
            this.PirmasTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabai;
        private System.Windows.Forms.TabPage PirmasTab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage NewTab;
    }
}

