
namespace AaronMorris_C969_Task1.Forms
{
    partial class CustomerInfo
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
            this.CustIDTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CustNameTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CustAddrTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CustAddr2Textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CustCityTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CustPostalTextbox = new System.Windows.Forms.TextBox();
            this.CustCountryTextbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CustPhoneTextbox = new System.Windows.Forms.TextBox();
            this.CustInfoSaveButton = new System.Windows.Forms.Button();
            this.CustInfoCancelButton = new System.Windows.Forms.Button();
            this.EditAddressBtn = new System.Windows.Forms.Button();
            this.EditCityBtn = new System.Windows.Forms.Button();
            this.EditCountryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustIDTextbox
            // 
            this.CustIDTextbox.Enabled = false;
            this.CustIDTextbox.Location = new System.Drawing.Point(107, 68);
            this.CustIDTextbox.Name = "CustIDTextbox";
            this.CustIDTextbox.ReadOnly = true;
            this.CustIDTextbox.Size = new System.Drawing.Size(129, 20);
            this.CustIDTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer Name:";
            // 
            // CustNameTextbox
            // 
            this.CustNameTextbox.Location = new System.Drawing.Point(353, 68);
            this.CustNameTextbox.Name = "CustNameTextbox";
            this.CustNameTextbox.Size = new System.Drawing.Size(172, 20);
            this.CustNameTextbox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Street Address:";
            // 
            // CustAddrTextbox
            // 
            this.CustAddrTextbox.Location = new System.Drawing.Point(89, 135);
            this.CustAddrTextbox.Name = "CustAddrTextbox";
            this.CustAddrTextbox.ReadOnly = true;
            this.CustAddrTextbox.Size = new System.Drawing.Size(206, 20);
            this.CustAddrTextbox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Apt/Unit #:";
            // 
            // CustAddr2Textbox
            // 
            this.CustAddr2Textbox.Location = new System.Drawing.Point(376, 135);
            this.CustAddr2Textbox.Name = "CustAddr2Textbox";
            this.CustAddr2Textbox.ReadOnly = true;
            this.CustAddr2Textbox.Size = new System.Drawing.Size(43, 20);
            this.CustAddr2Textbox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "City:";
            // 
            // CustCityTextbox
            // 
            this.CustCityTextbox.Location = new System.Drawing.Point(68, 210);
            this.CustCityTextbox.Name = "CustCityTextbox";
            this.CustCityTextbox.ReadOnly = true;
            this.CustCityTextbox.Size = new System.Drawing.Size(162, 20);
            this.CustCityTextbox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Postal code:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(271, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Country:";
            // 
            // CustPostalTextbox
            // 
            this.CustPostalTextbox.Location = new System.Drawing.Point(137, 165);
            this.CustPostalTextbox.Name = "CustPostalTextbox";
            this.CustPostalTextbox.ReadOnly = true;
            this.CustPostalTextbox.Size = new System.Drawing.Size(75, 20);
            this.CustPostalTextbox.TabIndex = 15;
            // 
            // CustCountryTextbox
            // 
            this.CustCountryTextbox.Location = new System.Drawing.Point(323, 210);
            this.CustCountryTextbox.Name = "CustCountryTextbox";
            this.CustCountryTextbox.ReadOnly = true;
            this.CustCountryTextbox.Size = new System.Drawing.Size(162, 20);
            this.CustCountryTextbox.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(242, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Phone:";
            // 
            // CustPhoneTextbox
            // 
            this.CustPhoneTextbox.Location = new System.Drawing.Point(289, 165);
            this.CustPhoneTextbox.Name = "CustPhoneTextbox";
            this.CustPhoneTextbox.ReadOnly = true;
            this.CustPhoneTextbox.Size = new System.Drawing.Size(130, 20);
            this.CustPhoneTextbox.TabIndex = 18;
            // 
            // CustInfoSaveButton
            // 
            this.CustInfoSaveButton.Location = new System.Drawing.Point(369, 279);
            this.CustInfoSaveButton.Name = "CustInfoSaveButton";
            this.CustInfoSaveButton.Size = new System.Drawing.Size(75, 23);
            this.CustInfoSaveButton.TabIndex = 19;
            this.CustInfoSaveButton.Text = "Save";
            this.CustInfoSaveButton.UseVisualStyleBackColor = true;
            this.CustInfoSaveButton.Click += new System.EventHandler(this.CustInfoSaveButton_Click);
            // 
            // CustInfoCancelButton
            // 
            this.CustInfoCancelButton.Location = new System.Drawing.Point(450, 279);
            this.CustInfoCancelButton.Name = "CustInfoCancelButton";
            this.CustInfoCancelButton.Size = new System.Drawing.Size(75, 23);
            this.CustInfoCancelButton.TabIndex = 20;
            this.CustInfoCancelButton.Text = "Cancel";
            this.CustInfoCancelButton.UseVisualStyleBackColor = true;
            this.CustInfoCancelButton.Click += new System.EventHandler(this.CustInfoCancelButton_Click);
            // 
            // EditAddressBtn
            // 
            this.EditAddressBtn.Location = new System.Drawing.Point(440, 135);
            this.EditAddressBtn.Name = "EditAddressBtn";
            this.EditAddressBtn.Size = new System.Drawing.Size(75, 50);
            this.EditAddressBtn.TabIndex = 21;
            this.EditAddressBtn.Text = "Edit Address";
            this.EditAddressBtn.UseVisualStyleBackColor = true;
            this.EditAddressBtn.Click += new System.EventHandler(this.EditAddressBtn_Click);
            // 
            // EditCityBtn
            // 
            this.EditCityBtn.Location = new System.Drawing.Point(97, 236);
            this.EditCityBtn.Name = "EditCityBtn";
            this.EditCityBtn.Size = new System.Drawing.Size(75, 23);
            this.EditCityBtn.TabIndex = 22;
            this.EditCityBtn.Text = "Edit City";
            this.EditCityBtn.UseVisualStyleBackColor = true;
            this.EditCityBtn.Click += new System.EventHandler(this.EditCityBtn_Click);
            // 
            // EditCountryBtn
            // 
            this.EditCountryBtn.Location = new System.Drawing.Point(360, 236);
            this.EditCountryBtn.Name = "EditCountryBtn";
            this.EditCountryBtn.Size = new System.Drawing.Size(75, 23);
            this.EditCountryBtn.TabIndex = 23;
            this.EditCountryBtn.Text = "Edit Country";
            this.EditCountryBtn.UseVisualStyleBackColor = true;
            this.EditCountryBtn.Click += new System.EventHandler(this.EditCountryBtn_Click);
            // 
            // CustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 314);
            this.Controls.Add(this.EditCountryBtn);
            this.Controls.Add(this.EditCityBtn);
            this.Controls.Add(this.EditAddressBtn);
            this.Controls.Add(this.CustInfoCancelButton);
            this.Controls.Add(this.CustInfoSaveButton);
            this.Controls.Add(this.CustPhoneTextbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CustCountryTextbox);
            this.Controls.Add(this.CustPostalTextbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CustCityTextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CustAddr2Textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CustAddrTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CustNameTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustIDTextbox);
            this.Name = "CustomerInfo";
            this.Text = "Customer Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CustIDTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CustNameTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CustAddrTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CustAddr2Textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CustCityTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CustPostalTextbox;
        private System.Windows.Forms.TextBox CustCountryTextbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CustPhoneTextbox;
        private System.Windows.Forms.Button CustInfoSaveButton;
        private System.Windows.Forms.Button CustInfoCancelButton;
        private System.Windows.Forms.Button EditAddressBtn;
        private System.Windows.Forms.Button EditCityBtn;
        private System.Windows.Forms.Button EditCountryBtn;
    }
}