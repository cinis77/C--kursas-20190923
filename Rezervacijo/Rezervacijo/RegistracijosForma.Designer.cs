namespace Rezervacijo
{
    partial class RegistracijosForma
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
            this.UserNameText = new System.Windows.Forms.TextBox();
            this.PassWordName = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.SurnameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RegistruotisMygtukas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserNameText
            // 
            this.UserNameText.Location = new System.Drawing.Point(167, 25);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(169, 29);
            this.UserNameText.TabIndex = 0;
            // 
            // PassWordName
            // 
            this.PassWordName.Location = new System.Drawing.Point(167, 78);
            this.PassWordName.Name = "PassWordName";
            this.PassWordName.PasswordChar = '*';
            this.PassWordName.Size = new System.Drawing.Size(169, 29);
            this.PassWordName.TabIndex = 1;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(167, 131);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(169, 29);
            this.NameText.TabIndex = 2;
            // 
            // SurnameText
            // 
            this.SurnameText.Location = new System.Drawing.Point(167, 184);
            this.SurnameText.Name = "SurnameText";
            this.SurnameText.Size = new System.Drawing.Size(169, 29);
            this.SurnameText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vardas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pavarde";
            // 
            // RegistruotisMygtukas
            // 
            this.RegistruotisMygtukas.Location = new System.Drawing.Point(187, 288);
            this.RegistruotisMygtukas.Name = "RegistruotisMygtukas";
            this.RegistruotisMygtukas.Size = new System.Drawing.Size(149, 83);
            this.RegistruotisMygtukas.TabIndex = 8;
            this.RegistruotisMygtukas.Text = "Registruotis";
            this.RegistruotisMygtukas.UseVisualStyleBackColor = true;
            this.RegistruotisMygtukas.Click += new System.EventHandler(this.RegistruotisMygtukas_Click);
            // 
            // RegistracijosForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 460);
            this.Controls.Add(this.RegistruotisMygtukas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SurnameText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.PassWordName);
            this.Controls.Add(this.UserNameText);
            this.Name = "RegistracijosForma";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistracijosForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameText;
        private System.Windows.Forms.TextBox PassWordName;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox SurnameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RegistruotisMygtukas;
    }
}