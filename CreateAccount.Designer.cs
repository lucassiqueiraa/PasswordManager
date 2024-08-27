namespace PasswordManager
{
    partial class CreateAccount
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
            this.textBoxCreateMasterPassword = new System.Windows.Forms.TextBox();
            this.textBox1CreateUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCreateEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.textBox2MasterPasswordConfirmation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCreateMasterPassword
            // 
            this.textBoxCreateMasterPassword.Location = new System.Drawing.Point(245, 251);
            this.textBoxCreateMasterPassword.Name = "textBoxCreateMasterPassword";
            this.textBoxCreateMasterPassword.PasswordChar = '*';
            this.textBoxCreateMasterPassword.Size = new System.Drawing.Size(311, 31);
            this.textBoxCreateMasterPassword.TabIndex = 7;
            this.textBoxCreateMasterPassword.UseSystemPasswordChar = true;
            // 
            // textBox1CreateUsername
            // 
            this.textBox1CreateUsername.Location = new System.Drawing.Point(245, 145);
            this.textBox1CreateUsername.Name = "textBox1CreateUsername";
            this.textBox1CreateUsername.Size = new System.Drawing.Size(311, 31);
            this.textBox1CreateUsername.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Master Password";
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // textBoxCreateEmail
            // 
            this.textBoxCreateEmail.Location = new System.Drawing.Point(245, 469);
            this.textBoxCreateEmail.Name = "textBoxCreateEmail";
            this.textBoxCreateEmail.PasswordChar = '*';
            this.textBoxCreateEmail.Size = new System.Drawing.Size(311, 31);
            this.textBoxCreateEmail.TabIndex = 9;
            this.textBoxCreateEmail.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(300, 545);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(153, 51);
            this.buttonCreate.TabIndex = 10;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // textBox2MasterPasswordConfirmation
            // 
            this.textBox2MasterPasswordConfirmation.Location = new System.Drawing.Point(245, 368);
            this.textBox2MasterPasswordConfirmation.Name = "textBox2MasterPasswordConfirmation";
            this.textBox2MasterPasswordConfirmation.PasswordChar = '*';
            this.textBox2MasterPasswordConfirmation.Size = new System.Drawing.Size(311, 31);
            this.textBox2MasterPasswordConfirmation.TabIndex = 12;
            this.textBox2MasterPasswordConfirmation.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Master Password Confirmation";
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 934);
            this.Controls.Add(this.textBox2MasterPasswordConfirmation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxCreateEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCreateMasterPassword);
            this.Controls.Add(this.textBox1CreateUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateAccount";
            this.Text = "CreateAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCreateMasterPassword;
        private System.Windows.Forms.TextBox textBox1CreateUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCreateEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox textBox2MasterPasswordConfirmation;
        private System.Windows.Forms.Label label4;
    }
}