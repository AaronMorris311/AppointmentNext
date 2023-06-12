
namespace AaronMorris_C969_Task1.Forms
{
    partial class CountryForm
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
            this.CustCountryTextbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.client_scheduleDataSet1 = new AaronMorris_C969_Task1.client_scheduleDataSet();
            this.CntrySaveBtn = new System.Windows.Forms.Button();
            this.CntryCnclBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.client_scheduleDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustCountryTextbox
            // 
            this.CustCountryTextbox.Location = new System.Drawing.Point(75, 58);
            this.CustCountryTextbox.Name = "CustCountryTextbox";
            this.CustCountryTextbox.Size = new System.Drawing.Size(162, 20);
            this.CustCountryTextbox.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Country:";
            // 
            // client_scheduleDataSet1
            // 
            this.client_scheduleDataSet1.DataSetName = "client_scheduleDataSet";
            this.client_scheduleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CntrySaveBtn
            // 
            this.CntrySaveBtn.Location = new System.Drawing.Point(126, 112);
            this.CntrySaveBtn.Name = "CntrySaveBtn";
            this.CntrySaveBtn.Size = new System.Drawing.Size(75, 23);
            this.CntrySaveBtn.TabIndex = 35;
            this.CntrySaveBtn.Text = "Save";
            this.CntrySaveBtn.UseVisualStyleBackColor = true;
            this.CntrySaveBtn.Click += new System.EventHandler(this.CntrySaveBtn_Click);
            // 
            // CntryCnclBtn
            // 
            this.CntryCnclBtn.Location = new System.Drawing.Point(207, 112);
            this.CntryCnclBtn.Name = "CntryCnclBtn";
            this.CntryCnclBtn.Size = new System.Drawing.Size(75, 23);
            this.CntryCnclBtn.TabIndex = 36;
            this.CntryCnclBtn.Text = "Cancel";
            this.CntryCnclBtn.UseVisualStyleBackColor = true;
            this.CntryCnclBtn.Click += new System.EventHandler(this.CntryCnclBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "Enter the country:";
            // 
            // CountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 147);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CntryCnclBtn);
            this.Controls.Add(this.CntrySaveBtn);
            this.Controls.Add(this.CustCountryTextbox);
            this.Controls.Add(this.label9);
            this.Name = "CountryForm";
            this.Text = "Country";
            ((System.ComponentModel.ISupportInitialize)(this.client_scheduleDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CustCountryTextbox;
        private System.Windows.Forms.Label label9;
        private client_scheduleDataSet client_scheduleDataSet1;
        private System.Windows.Forms.Button CntrySaveBtn;
        private System.Windows.Forms.Button CntryCnclBtn;
        private System.Windows.Forms.Label label1;
    }
}