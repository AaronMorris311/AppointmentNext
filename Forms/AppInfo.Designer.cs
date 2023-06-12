
namespace AaronMorris_C969_Task1.Forms
{
    partial class AppInfo
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
            this.AppInfoTypeDropdown = new System.Windows.Forms.ComboBox();
            this.AppInfoCustDropdown = new System.Windows.Forms.ComboBox();
            this.AppInfoDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AppInfoUserDropdown = new System.Windows.Forms.ComboBox();
            this.AppDetails = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AppInfoNotes = new System.Windows.Forms.TextBox();
            this.AppInfoSaveButton = new System.Windows.Forms.Button();
            this.AppInfoCancelButton = new System.Windows.Forms.Button();
            this.AppInfoDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AppInfoTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AppInfoLocation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AppInfoTypeDropdown
            // 
            this.AppInfoTypeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AppInfoTypeDropdown.FormattingEnabled = true;
            this.AppInfoTypeDropdown.Location = new System.Drawing.Point(178, 95);
            this.AppInfoTypeDropdown.Name = "AppInfoTypeDropdown";
            this.AppInfoTypeDropdown.Size = new System.Drawing.Size(121, 21);
            this.AppInfoTypeDropdown.TabIndex = 0;
            // 
            // AppInfoCustDropdown
            // 
            this.AppInfoCustDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AppInfoCustDropdown.FormattingEnabled = true;
            this.AppInfoCustDropdown.Location = new System.Drawing.Point(178, 122);
            this.AppInfoCustDropdown.Name = "AppInfoCustDropdown";
            this.AppInfoCustDropdown.Size = new System.Drawing.Size(121, 21);
            this.AppInfoCustDropdown.TabIndex = 1;
            // 
            // AppInfoDatePicker
            // 
            this.AppInfoDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AppInfoDatePicker.Location = new System.Drawing.Point(178, 159);
            this.AppInfoDatePicker.Name = "AppInfoDatePicker";
            this.AppInfoDatePicker.Size = new System.Drawing.Size(165, 20);
            this.AppInfoDatePicker.TabIndex = 2;
            // 
            // AppInfoUserDropdown
            // 
            this.AppInfoUserDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AppInfoUserDropdown.FormattingEnabled = true;
            this.AppInfoUserDropdown.Location = new System.Drawing.Point(178, 231);
            this.AppInfoUserDropdown.Name = "AppInfoUserDropdown";
            this.AppInfoUserDropdown.Size = new System.Drawing.Size(121, 21);
            this.AppInfoUserDropdown.TabIndex = 3;
            // 
            // AppDetails
            // 
            this.AppDetails.AutoSize = true;
            this.AppDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppDetails.Location = new System.Drawing.Point(28, 28);
            this.AppDetails.Name = "AppDetails";
            this.AppDetails.Size = new System.Drawing.Size(177, 24);
            this.AppDetails.TabIndex = 5;
            this.AppDetails.Text = "Appointment Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Type of Appointment:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Customer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Start:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "User:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Additional Notes:";
            // 
            // AppInfoNotes
            // 
            this.AppInfoNotes.Location = new System.Drawing.Point(448, 64);
            this.AppInfoNotes.Multiline = true;
            this.AppInfoNotes.Name = "AppInfoNotes";
            this.AppInfoNotes.Size = new System.Drawing.Size(269, 226);
            this.AppInfoNotes.TabIndex = 12;
            // 
            // AppInfoSaveButton
            // 
            this.AppInfoSaveButton.Location = new System.Drawing.Point(584, 307);
            this.AppInfoSaveButton.Name = "AppInfoSaveButton";
            this.AppInfoSaveButton.Size = new System.Drawing.Size(75, 23);
            this.AppInfoSaveButton.TabIndex = 13;
            this.AppInfoSaveButton.Text = "Save";
            this.AppInfoSaveButton.UseVisualStyleBackColor = true;
            this.AppInfoSaveButton.Click += new System.EventHandler(this.AppInfoSaveButton_Click);
            // 
            // AppInfoCancelButton
            // 
            this.AppInfoCancelButton.Location = new System.Drawing.Point(665, 307);
            this.AppInfoCancelButton.Name = "AppInfoCancelButton";
            this.AppInfoCancelButton.Size = new System.Drawing.Size(75, 23);
            this.AppInfoCancelButton.TabIndex = 14;
            this.AppInfoCancelButton.Text = "Cancel";
            this.AppInfoCancelButton.UseVisualStyleBackColor = true;
            this.AppInfoCancelButton.Click += new System.EventHandler(this.AppInfoCancelButton_Click);
            // 
            // AppInfoDateTimePicker2
            // 
            this.AppInfoDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AppInfoDateTimePicker2.Location = new System.Drawing.Point(178, 185);
            this.AppInfoDateTimePicker2.Name = "AppInfoDateTimePicker2";
            this.AppInfoDateTimePicker2.Size = new System.Drawing.Size(165, 20);
            this.AppInfoDateTimePicker2.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "End:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Title of Appointment:";
            // 
            // AppInfoTitle
            // 
            this.AppInfoTitle.Location = new System.Drawing.Point(178, 61);
            this.AppInfoTitle.Name = "AppInfoTitle";
            this.AppInfoTitle.Size = new System.Drawing.Size(139, 20);
            this.AppInfoTitle.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Location:";
            // 
            // AppInfoLocation
            // 
            this.AppInfoLocation.Location = new System.Drawing.Point(178, 274);
            this.AppInfoLocation.Name = "AppInfoLocation";
            this.AppInfoLocation.Size = new System.Drawing.Size(139, 20);
            this.AppInfoLocation.TabIndex = 20;
            // 
            // AppInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.AppInfoLocation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AppInfoTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AppInfoDateTimePicker2);
            this.Controls.Add(this.AppInfoCancelButton);
            this.Controls.Add(this.AppInfoSaveButton);
            this.Controls.Add(this.AppInfoNotes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AppDetails);
            this.Controls.Add(this.AppInfoUserDropdown);
            this.Controls.Add(this.AppInfoDatePicker);
            this.Controls.Add(this.AppInfoCustDropdown);
            this.Controls.Add(this.AppInfoTypeDropdown);
            this.Name = "AppInfo";
            this.Text = "Appointment Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AppInfoTypeDropdown;
        private System.Windows.Forms.ComboBox AppInfoCustDropdown;
        private System.Windows.Forms.DateTimePicker AppInfoDatePicker;
        private System.Windows.Forms.ComboBox AppInfoUserDropdown;
        private System.Windows.Forms.Label AppDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AppInfoNotes;
        private System.Windows.Forms.Button AppInfoSaveButton;
        private System.Windows.Forms.Button AppInfoCancelButton;
        private System.Windows.Forms.DateTimePicker AppInfoDateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AppInfoTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AppInfoLocation;
    }
}