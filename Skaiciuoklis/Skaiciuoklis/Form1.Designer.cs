namespace Skaiciuoklis
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
            this.PirmasSkaicius = new System.Windows.Forms.TextBox();
            this.zenklas = new System.Windows.Forms.ComboBox();
            this.AntrasSkaicius = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.atsakymas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PirmasSkaicius
            // 
            this.PirmasSkaicius.Location = new System.Drawing.Point(28, 56);
            this.PirmasSkaicius.Name = "PirmasSkaicius";
            this.PirmasSkaicius.Size = new System.Drawing.Size(100, 29);
            this.PirmasSkaicius.TabIndex = 0;
            // 
            // zenklas
            // 
            this.zenklas.FormattingEnabled = true;
            this.zenklas.Location = new System.Drawing.Point(147, 53);
            this.zenklas.Name = "zenklas";
            this.zenklas.Size = new System.Drawing.Size(121, 32);
            this.zenklas.TabIndex = 1;
            // 
            // AntrasSkaicius
            // 
            this.AntrasSkaicius.Location = new System.Drawing.Point(289, 56);
            this.AntrasSkaicius.Name = "AntrasSkaicius";
            this.AntrasSkaicius.Size = new System.Drawing.Size(100, 29);
            this.AntrasSkaicius.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // atsakymas
            // 
            this.atsakymas.AutoSize = true;
            this.atsakymas.Location = new System.Drawing.Point(490, 56);
            this.atsakymas.Name = "atsakymas";
            this.atsakymas.Size = new System.Drawing.Size(106, 25);
            this.atsakymas.TabIndex = 4;
            this.atsakymas.Text = "atsakymas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.atsakymas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AntrasSkaicius);
            this.Controls.Add(this.zenklas);
            this.Controls.Add(this.PirmasSkaicius);
            this.Name = "Form1";
            this.Text = "Skaiciuotuvas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PirmasSkaicius;
        private System.Windows.Forms.ComboBox zenklas;
        private System.Windows.Forms.TextBox AntrasSkaicius;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label atsakymas;
    }
}

