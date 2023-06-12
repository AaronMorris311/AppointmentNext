
namespace AaronMorris_C969_Task1
{
    partial class AddressForm
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
            this.CustPhoneTextbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CustPostalTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CustAddr2Textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CustAddrTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CustInfoCancelButton = new System.Windows.Forms.Button();
            this.CustInfoSaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustPhoneTextbox
            // 
            this.CustPhoneTextbox.Location = new System.Drawing.Point(258, 93);
            this.CustPhoneTextbox.Name = "CustPhoneTextbox";
            this.CustPhoneTextbox.Size = new System.Drawing.Size(162, 20);
            this.CustPhoneTextbox.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(211, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Phone:";
            // 
            // CustPostalTextbox
            // 
            this.CustPostalTextbox.Location = new System.Drawing.Point(112, 93);
            this.CustPostalTextbox.Name = "CustPostalTextbox";
            this.CustPostalTextbox.Size = new System.Drawing.Size(75, 20);
            this.CustPostalTextbox.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Postal code:";
            // 
            // CustAddr2Textbox
            // 
            this.CustAddr2Textbox.Location = new System.Drawing.Point(451, 56);
            this.CustAddr2Textbox.Name = "CustAddr2Textbox";
            this.CustAddr2Textbox.Size = new System.Drawing.Size(75, 20);
            this.CustAddr2Textbox.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Apt/Unit #:";
            // 
            // CustAddrTextbox
            // 
            this.CustAddrTextbox.Location = new System.Drawing.Point(101, 56);
            this.CustAddrTextbox.Name = "CustAddrTextbox";
            this.CustAddrTextbox.Size = new System.Drawing.Size(245, 20);
            this.CustAddrTextbox.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Street Address:";
            // 
            // CustInfoCancelButton
            // 
            this.CustInfoCancelButton.Location = new System.Drawing.Point(467, 154);
            this.CustInfoCancelButton.Name = "CustInfoCancelButton";
            this.CustInfoCancelButton.Size = new System.Drawing.Size(75, 23);
            this.CustInfoCancelButton.TabIndex = 32;
            this.CustInfoCancelButton.Text = "Cancel";
            this.CustInfoCancelButton.UseVisualStyleBackColor = true;
            this.CustInfoCancelButton.Click += new System.EventHandler(this.CustInfoCancelButton_Click);
            // 
            // CustInfoSaveButton
            // 
            this.CustInfoSaveButton.Location = new System.Drawing.Point(386, 154);
            this.CustInfoSaveButton.Name = "CustInfoSaveButton";
            this.CustInfoSaveButton.Size = new System.Drawing.Size(75, 23);
            this.CustInfoSaveButton.TabIndex = 31;
            this.CustInfoSaveButton.Text = "Save";
            this.CustInfoSaveButton.UseVisualStyleBackColor = true;
            this.CustInfoSaveButton.Click += new System.EventHandler(this.CustInfoSaveButton_Click);
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 196);
            this.Controls.Add(this.CustInfoCancelButton);
            this.Controls.Add(this.CustInfoSaveButton);
            this.Controls.Add(this.CustPhoneTextbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CustPostalTextbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CustAddr2Textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CustAddrTextbox);
            this.Controls.Add(this.label4);
            this.Name = "AddressForm";
            this.Text = "AddressForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CustPhoneTextbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CustPostalTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CustAddr2Textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CustAddrTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CustInfoCancelButton;
        private System.Windows.Forms.Button CustInfoSaveButton;
    }
}