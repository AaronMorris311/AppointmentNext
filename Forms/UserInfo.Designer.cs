
namespace AaronMorris_C969_Task1.Forms
{
    partial class UserInfo
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
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.UserInfoSaveButton = new System.Windows.Forms.Button();
            this.UserInfoCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(102, 47);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(157, 20);
            this.UsernameTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(102, 73);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(157, 20);
            this.PasswordTextbox.TabIndex = 2;
            this.PasswordTextbox.UseSystemPasswordChar = true;
            // 
            // UserInfoSaveButton
            // 
            this.UserInfoSaveButton.Location = new System.Drawing.Point(127, 116);
            this.UserInfoSaveButton.Name = "UserInfoSaveButton";
            this.UserInfoSaveButton.Size = new System.Drawing.Size(75, 23);
            this.UserInfoSaveButton.TabIndex = 4;
            this.UserInfoSaveButton.Text = "Save";
            this.UserInfoSaveButton.UseVisualStyleBackColor = true;
            this.UserInfoSaveButton.Click += new System.EventHandler(this.UserInfoSaveButton_Click);
            // 
            // UserInfoCancelButton
            // 
            this.UserInfoCancelButton.Location = new System.Drawing.Point(208, 116);
            this.UserInfoCancelButton.Name = "UserInfoCancelButton";
            this.UserInfoCancelButton.Size = new System.Drawing.Size(75, 23);
            this.UserInfoCancelButton.TabIndex = 5;
            this.UserInfoCancelButton.Text = "Cancel";
            this.UserInfoCancelButton.UseVisualStyleBackColor = true;
            this.UserInfoCancelButton.Click += new System.EventHandler(this.UserInfoCancelButton_Click);
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 151);
            this.Controls.Add(this.UserInfoCancelButton);
            this.Controls.Add(this.UserInfoSaveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsernameTextbox);
            this.Name = "UserInfo";
            this.Text = "User Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Button UserInfoSaveButton;
        private System.Windows.Forms.Button UserInfoCancelButton;
    }
}