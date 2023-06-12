
namespace AaronMorris_C969_Task1.Forms
{
    partial class CityForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.CustInfoCancelButton = new System.Windows.Forms.Button();
            this.CustInfoSaveButton = new System.Windows.Forms.Button();
            this.CustCityTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "City:";
            // 
            // CustInfoCancelButton
            // 
            this.CustInfoCancelButton.Location = new System.Drawing.Point(194, 97);
            this.CustInfoCancelButton.Name = "CustInfoCancelButton";
            this.CustInfoCancelButton.Size = new System.Drawing.Size(75, 23);
            this.CustInfoCancelButton.TabIndex = 36;
            this.CustInfoCancelButton.Text = "Cancel";
            this.CustInfoCancelButton.UseVisualStyleBackColor = true;
            this.CustInfoCancelButton.Click += new System.EventHandler(this.CustInfoCancelButton_Click);
            // 
            // CustInfoSaveButton
            // 
            this.CustInfoSaveButton.Location = new System.Drawing.Point(113, 97);
            this.CustInfoSaveButton.Name = "CustInfoSaveButton";
            this.CustInfoSaveButton.Size = new System.Drawing.Size(75, 23);
            this.CustInfoSaveButton.TabIndex = 35;
            this.CustInfoSaveButton.Text = "Save";
            this.CustInfoSaveButton.UseVisualStyleBackColor = true;
            this.CustInfoSaveButton.Click += new System.EventHandler(this.CustInfoSaveButton_Click);
            // 
            // CustCityTextbox
            // 
            this.CustCityTextbox.Location = new System.Drawing.Point(61, 59);
            this.CustCityTextbox.Name = "CustCityTextbox";
            this.CustCityTextbox.Size = new System.Drawing.Size(208, 20);
            this.CustCityTextbox.TabIndex = 37;
            // 
            // CityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 137);
            this.Controls.Add(this.CustCityTextbox);
            this.Controls.Add(this.CustInfoCancelButton);
            this.Controls.Add(this.CustInfoSaveButton);
            this.Controls.Add(this.label7);
            this.Name = "CityForm";
            this.Text = "CityForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CustInfoCancelButton;
        private System.Windows.Forms.Button CustInfoSaveButton;
        private System.Windows.Forms.TextBox CustCityTextbox;
    }
}