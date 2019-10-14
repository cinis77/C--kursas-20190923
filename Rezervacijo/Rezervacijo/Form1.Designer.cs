namespace Rezervacijo
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
            this.UserNameText = new System.Windows.Forms.TextBox();
            this.PassWordText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.Registruotis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserNameText
            // 
            this.UserNameText.Location = new System.Drawing.Point(356, 63);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(264, 29);
            this.UserNameText.TabIndex = 0;
            // 
            // PassWordText
            // 
            this.PassWordText.Location = new System.Drawing.Point(356, 119);
            this.PassWordText.Name = "PassWordText";
            this.PassWordText.PasswordChar = '#';
            this.PassWordText.Size = new System.Drawing.Size(264, 29);
            this.PassWordText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vartotojo vardas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Slaptažodis";
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(423, 261);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(185, 85);
            this.Connect.TabIndex = 4;
            this.Connect.Text = "Prisijungti";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Registruotis
            // 
            this.Registruotis.Location = new System.Drawing.Point(140, 261);
            this.Registruotis.Name = "Registruotis";
            this.Registruotis.Size = new System.Drawing.Size(177, 85);
            this.Registruotis.TabIndex = 5;
            this.Registruotis.Text = "Registruotis";
            this.Registruotis.UseVisualStyleBackColor = true;
            this.Registruotis.Click += new System.EventHandler(this.Registruotis_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(703, 387);
            this.Controls.Add(this.Registruotis);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassWordText);
            this.Controls.Add(this.UserNameText);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameText;
        private System.Windows.Forms.TextBox PassWordText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button Registruotis;
    }
}

