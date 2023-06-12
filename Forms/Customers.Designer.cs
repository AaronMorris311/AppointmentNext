
namespace AaronMorris_C969_Task1.Forms
{
    partial class Customers
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
            this.components = new System.ComponentModel.Container();
            this.CustomerDGV = new System.Windows.Forms.DataGridView();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.AddCustButton = new System.Windows.Forms.Button();
            this.ModifyCustButton = new System.Windows.Forms.Button();
            this.DeleteCustButton = new System.Windows.Forms.Button();
            this.CloseCustButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerDGV
            // 
            this.CustomerDGV.AllowUserToAddRows = false;
            this.CustomerDGV.AllowUserToDeleteRows = false;
            this.CustomerDGV.AllowUserToOrderColumns = true;
            this.CustomerDGV.AutoGenerateColumns = false;
            this.CustomerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.fullName,
            this.Address,
            this.activeDataGridViewCheckBoxColumn});
            this.CustomerDGV.DataSource = this.customerBindingSource;
            this.CustomerDGV.Location = new System.Drawing.Point(46, 51);
            this.CustomerDGV.MultiSelect = false;
            this.CustomerDGV.Name = "CustomerDGV";
            this.CustomerDGV.ReadOnly = true;
            this.CustomerDGV.RowHeadersVisible = false;
            this.CustomerDGV.Size = new System.Drawing.Size(563, 348);
            this.CustomerDGV.TabIndex = 0;
            this.CustomerDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDGV_CellClick);
            this.CustomerDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerDGV_CellDoubleClick);
            this.CustomerDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.CustomerDGV_DataBindingComplete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customers";
            // 
            // AddCustButton
            // 
            this.AddCustButton.Location = new System.Drawing.Point(645, 51);
            this.AddCustButton.Name = "AddCustButton";
            this.AddCustButton.Size = new System.Drawing.Size(99, 33);
            this.AddCustButton.TabIndex = 2;
            this.AddCustButton.Text = "Add";
            this.AddCustButton.UseVisualStyleBackColor = true;
            this.AddCustButton.Click += new System.EventHandler(this.AddCustButton_Click);
            // 
            // ModifyCustButton
            // 
            this.ModifyCustButton.Location = new System.Drawing.Point(645, 102);
            this.ModifyCustButton.Name = "ModifyCustButton";
            this.ModifyCustButton.Size = new System.Drawing.Size(99, 33);
            this.ModifyCustButton.TabIndex = 3;
            this.ModifyCustButton.Text = "Modify";
            this.ModifyCustButton.UseVisualStyleBackColor = true;
            this.ModifyCustButton.Click += new System.EventHandler(this.ModifyCustButton_Click);
            // 
            // DeleteCustButton
            // 
            this.DeleteCustButton.Location = new System.Drawing.Point(645, 152);
            this.DeleteCustButton.Name = "DeleteCustButton";
            this.DeleteCustButton.Size = new System.Drawing.Size(99, 33);
            this.DeleteCustButton.TabIndex = 4;
            this.DeleteCustButton.Text = "Delete";
            this.DeleteCustButton.UseVisualStyleBackColor = true;
            this.DeleteCustButton.Click += new System.EventHandler(this.DeleteCustButton_Click);
            // 
            // CloseCustButton
            // 
            this.CloseCustButton.Location = new System.Drawing.Point(645, 366);
            this.CloseCustButton.Name = "CloseCustButton";
            this.CloseCustButton.Size = new System.Drawing.Size(99, 33);
            this.CloseCustButton.TabIndex = 5;
            this.CloseCustButton.Text = "Done";
            this.CloseCustButton.UseVisualStyleBackColor = true;
            this.CloseCustButton.Click += new System.EventHandler(this.CloseCustButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn1.HeaderText = "Address";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn2.FillWeight = 6F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Address";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 224;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn3.FillWeight = 6F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 259;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn4.FillWeight = 6F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Address";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 286;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn5.FillWeight = 6F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Address";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 286;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn6.FillWeight = 6F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Address";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 286;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(AaronMorris_C969_Task1.Models.Customer);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "customerId";
            this.ID.FillWeight = 0.75F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // fullName
            // 
            this.fullName.DataPropertyName = "customerName";
            this.fullName.FillWeight = 3F;
            this.fullName.HeaderText = "Name";
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "addressToString";
            this.Address.FillWeight = 6F;
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "active";
            this.activeDataGridViewCheckBoxColumn.FillWeight = 1F;
            this.activeDataGridViewCheckBoxColumn.HeaderText = "active";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseCustButton);
            this.Controls.Add(this.DeleteCustButton);
            this.Controls.Add(this.ModifyCustButton);
            this.Controls.Add(this.AddCustButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerDGV);
            this.Name = "Customers";
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddCustButton;
        private System.Windows.Forms.Button ModifyCustButton;
        private System.Windows.Forms.Button DeleteCustButton;
        private System.Windows.Forms.Button CloseCustButton;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
    }
}