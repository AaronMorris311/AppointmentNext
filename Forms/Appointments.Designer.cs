
namespace AaronMorris_C969_Task1.Forms
{
    partial class Appointments
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
            this.AppointmentsDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UserDropdown = new System.Windows.Forms.ComboBox();
            this.CustomerDropdown = new System.Windows.Forms.ComboBox();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.ShowWeekButton = new System.Windows.Forms.Button();
            this.ShowMonthButton = new System.Windows.Forms.Button();
            this.CustomersButton = new System.Windows.Forms.Button();
            this.CreateAppButton = new System.Windows.Forms.Button();
            this.ModifyAppButton = new System.Windows.Forms.Button();
            this.DeleteAppButton = new System.Windows.Forms.Button();
            this.CategoryDropdown = new System.Windows.Forms.ComboBox();
            this.MonthDropdown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.UserButton = new System.Windows.Forms.Button();
            this.UpdateGridButton = new System.Windows.Forms.Button();
            this.UpdateCustViewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentsDGV
            // 
            this.AppointmentsDGV.AllowUserToAddRows = false;
            this.AppointmentsDGV.AllowUserToDeleteRows = false;
            this.AppointmentsDGV.AllowUserToOrderColumns = true;
            this.AppointmentsDGV.AutoGenerateColumns = false;
            this.AppointmentsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AppointmentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.user,
            this.customer,
            this.startDataGridViewTextBoxColumn,
            this.endDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn});
            this.AppointmentsDGV.DataSource = this.appointmentBindingSource;
            this.AppointmentsDGV.Location = new System.Drawing.Point(72, 100);
            this.AppointmentsDGV.MultiSelect = false;
            this.AppointmentsDGV.Name = "AppointmentsDGV";
            this.AppointmentsDGV.ReadOnly = true;
            this.AppointmentsDGV.RowHeadersVisible = false;
            this.AppointmentsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AppointmentsDGV.Size = new System.Drawing.Size(763, 372);
            this.AppointmentsDGV.TabIndex = 0;
            this.AppointmentsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentsDGV_CellClick);
            this.AppointmentsDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.AppointmentsDGV_DataBindingComplete);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "appointmentId";
            this.Column1.FillWeight = 40F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // user
            // 
            this.user.DataPropertyName = "user";
            this.user.HeaderText = "user";
            this.user.Name = "user";
            this.user.ReadOnly = true;
            // 
            // customer
            // 
            this.customer.DataPropertyName = "customer";
            this.customer.HeaderText = "customer";
            this.customer.Name = "customer";
            this.customer.ReadOnly = true;
            // 
            // startDataGridViewTextBoxColumn
            // 
            this.startDataGridViewTextBoxColumn.DataPropertyName = "start";
            this.startDataGridViewTextBoxColumn.FillWeight = 120F;
            this.startDataGridViewTextBoxColumn.HeaderText = "Start Time";
            this.startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
            this.startDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDataGridViewTextBoxColumn
            // 
            this.endDataGridViewTextBoxColumn.DataPropertyName = "end";
            this.endDataGridViewTextBoxColumn.FillWeight = 120F;
            this.endDataGridViewTextBoxColumn.HeaderText = "End Time";
            this.endDataGridViewTextBoxColumn.Name = "endDataGridViewTextBoxColumn";
            this.endDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(AaronMorris_C969_Task1.Models.Appointment);
            // 
            // UserDropdown
            // 
            this.UserDropdown.FormattingEnabled = true;
            this.UserDropdown.Location = new System.Drawing.Point(365, 71);
            this.UserDropdown.Name = "UserDropdown";
            this.UserDropdown.Size = new System.Drawing.Size(121, 21);
            this.UserDropdown.TabIndex = 1;
            this.UserDropdown.Text = "[User]";
            // 
            // CustomerDropdown
            // 
            this.CustomerDropdown.FormattingEnabled = true;
            this.CustomerDropdown.Location = new System.Drawing.Point(598, 71);
            this.CustomerDropdown.Name = "CustomerDropdown";
            this.CustomerDropdown.Size = new System.Drawing.Size(156, 21);
            this.CustomerDropdown.TabIndex = 2;
            this.CustomerDropdown.Text = "[Customers]";
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Location = new System.Drawing.Point(72, 71);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(75, 23);
            this.ShowAllButton.TabIndex = 3;
            this.ShowAllButton.Text = "Show All";
            this.ShowAllButton.UseVisualStyleBackColor = true;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // ShowWeekButton
            // 
            this.ShowWeekButton.Location = new System.Drawing.Point(234, 71);
            this.ShowWeekButton.Name = "ShowWeekButton";
            this.ShowWeekButton.Size = new System.Drawing.Size(75, 23);
            this.ShowWeekButton.TabIndex = 4;
            this.ShowWeekButton.Text = "Show Week";
            this.ShowWeekButton.UseVisualStyleBackColor = true;
            this.ShowWeekButton.Click += new System.EventHandler(this.ShowWeekButton_Click);
            // 
            // ShowMonthButton
            // 
            this.ShowMonthButton.Location = new System.Drawing.Point(153, 71);
            this.ShowMonthButton.Name = "ShowMonthButton";
            this.ShowMonthButton.Size = new System.Drawing.Size(75, 23);
            this.ShowMonthButton.TabIndex = 5;
            this.ShowMonthButton.Text = "Show Month";
            this.ShowMonthButton.UseVisualStyleBackColor = true;
            this.ShowMonthButton.Click += new System.EventHandler(this.ShowMonthButton_Click);
            // 
            // CustomersButton
            // 
            this.CustomersButton.Location = new System.Drawing.Point(873, 100);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(75, 23);
            this.CustomersButton.TabIndex = 6;
            this.CustomersButton.Text = "Customers";
            this.CustomersButton.UseVisualStyleBackColor = true;
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // CreateAppButton
            // 
            this.CreateAppButton.Location = new System.Drawing.Point(873, 324);
            this.CreateAppButton.Name = "CreateAppButton";
            this.CreateAppButton.Size = new System.Drawing.Size(75, 37);
            this.CreateAppButton.TabIndex = 7;
            this.CreateAppButton.Text = "Create Appointment";
            this.CreateAppButton.UseVisualStyleBackColor = true;
            this.CreateAppButton.Click += new System.EventHandler(this.CreateAppButton_Click);
            // 
            // ModifyAppButton
            // 
            this.ModifyAppButton.Location = new System.Drawing.Point(873, 367);
            this.ModifyAppButton.Name = "ModifyAppButton";
            this.ModifyAppButton.Size = new System.Drawing.Size(75, 39);
            this.ModifyAppButton.TabIndex = 8;
            this.ModifyAppButton.Text = "Modify Appointment";
            this.ModifyAppButton.UseVisualStyleBackColor = true;
            this.ModifyAppButton.Click += new System.EventHandler(this.ModifyAppButton_Click);
            // 
            // DeleteAppButton
            // 
            this.DeleteAppButton.Location = new System.Drawing.Point(873, 412);
            this.DeleteAppButton.Name = "DeleteAppButton";
            this.DeleteAppButton.Size = new System.Drawing.Size(75, 39);
            this.DeleteAppButton.TabIndex = 9;
            this.DeleteAppButton.Text = "Delete Appointment";
            this.DeleteAppButton.UseVisualStyleBackColor = true;
            this.DeleteAppButton.Click += new System.EventHandler(this.DeleteAppButton_Click);
            // 
            // CategoryDropdown
            // 
            this.CategoryDropdown.FormattingEnabled = true;
            this.CategoryDropdown.Location = new System.Drawing.Point(234, 505);
            this.CategoryDropdown.Name = "CategoryDropdown";
            this.CategoryDropdown.Size = new System.Drawing.Size(121, 21);
            this.CategoryDropdown.TabIndex = 10;
            this.CategoryDropdown.Text = "[Category]";
            // 
            // MonthDropdown
            // 
            this.MonthDropdown.FormattingEnabled = true;
            this.MonthDropdown.Location = new System.Drawing.Point(445, 505);
            this.MonthDropdown.Name = "MonthDropdown";
            this.MonthDropdown.Size = new System.Drawing.Size(121, 21);
            this.MonthDropdown.TabIndex = 11;
            this.MonthDropdown.Text = "[Month]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "How many";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "in the month of";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "?";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(598, 503);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 15;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Appointments";
            // 
            // UserButton
            // 
            this.UserButton.Location = new System.Drawing.Point(873, 129);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(75, 23);
            this.UserButton.TabIndex = 17;
            this.UserButton.Text = "Users";
            this.UserButton.UseVisualStyleBackColor = true;
            this.UserButton.Click += new System.EventHandler(this.UserButton_Click);
            // 
            // UpdateGridButton
            // 
            this.UpdateGridButton.Location = new System.Drawing.Point(492, 71);
            this.UpdateGridButton.Name = "UpdateGridButton";
            this.UpdateGridButton.Size = new System.Drawing.Size(75, 21);
            this.UpdateGridButton.TabIndex = 18;
            this.UpdateGridButton.Text = "View";
            this.UpdateGridButton.UseVisualStyleBackColor = true;
            this.UpdateGridButton.Click += new System.EventHandler(this.UpdateGridButton_Click);
            // 
            // UpdateCustViewButton
            // 
            this.UpdateCustViewButton.Location = new System.Drawing.Point(760, 70);
            this.UpdateCustViewButton.Name = "UpdateCustViewButton";
            this.UpdateCustViewButton.Size = new System.Drawing.Size(75, 21);
            this.UpdateCustViewButton.TabIndex = 19;
            this.UpdateCustViewButton.Text = "View";
            this.UpdateCustViewButton.UseVisualStyleBackColor = true;
            this.UpdateCustViewButton.Click += new System.EventHandler(this.UpdateCustViewButton_Click);
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 560);
            this.Controls.Add(this.UpdateCustViewButton);
            this.Controls.Add(this.UpdateGridButton);
            this.Controls.Add(this.UserButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MonthDropdown);
            this.Controls.Add(this.CategoryDropdown);
            this.Controls.Add(this.DeleteAppButton);
            this.Controls.Add(this.ModifyAppButton);
            this.Controls.Add(this.CreateAppButton);
            this.Controls.Add(this.CustomersButton);
            this.Controls.Add(this.ShowMonthButton);
            this.Controls.Add(this.ShowWeekButton);
            this.Controls.Add(this.ShowAllButton);
            this.Controls.Add(this.CustomerDropdown);
            this.Controls.Add(this.UserDropdown);
            this.Controls.Add(this.AppointmentsDGV);
            this.Name = "Appointments";
            this.Text = "AppointmentNext";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Appointments_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AppointmentsDGV;
        private System.Windows.Forms.ComboBox UserDropdown;
        private System.Windows.Forms.ComboBox CustomerDropdown;
        private System.Windows.Forms.Button ShowAllButton;
        private System.Windows.Forms.Button ShowWeekButton;
        private System.Windows.Forms.Button ShowMonthButton;
        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.Button CreateAppButton;
        private System.Windows.Forms.Button ModifyAppButton;
        private System.Windows.Forms.Button DeleteAppButton;
        private System.Windows.Forms.ComboBox CategoryDropdown;
        private System.Windows.Forms.ComboBox MonthDropdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button UserButton;
        private System.Windows.Forms.Button UpdateGridButton;
        private System.Windows.Forms.Button UpdateCustViewButton;
    }
}