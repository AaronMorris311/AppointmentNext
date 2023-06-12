
namespace AaronMorris_C969_Task1.Forms
{
    partial class UserForm
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
            this.UserDGV = new System.Windows.Forms.DataGridView();
            this.UserFormCancelButton = new System.Windows.Forms.Button();
            this.UserFormSaveButton = new System.Windows.Forms.Button();
            this.UserFormDeleteButton = new System.Windows.Forms.Button();
            this.UserFormAddButton = new System.Windows.Forms.Button();
            this.UserFormModifyButton = new System.Windows.Forms.Button();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UserDGV
            // 
            this.UserDGV.AllowUserToAddRows = false;
            this.UserDGV.AllowUserToDeleteRows = false;
            this.UserDGV.AutoGenerateColumns = false;
            this.UserDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn});
            this.UserDGV.DataSource = this.userBindingSource;
            this.UserDGV.Location = new System.Drawing.Point(12, 22);
            this.UserDGV.MultiSelect = false;
            this.UserDGV.Name = "UserDGV";
            this.UserDGV.ReadOnly = true;
            this.UserDGV.RowHeadersVisible = false;
            this.UserDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserDGV.Size = new System.Drawing.Size(294, 126);
            this.UserDGV.TabIndex = 0;
            this.UserDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDGV_CellClick);
            this.UserDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.UserDGV_DataBindingComplete);
            // 
            // UserFormCancelButton
            // 
            this.UserFormCancelButton.Location = new System.Drawing.Point(336, 172);
            this.UserFormCancelButton.Name = "UserFormCancelButton";
            this.UserFormCancelButton.Size = new System.Drawing.Size(75, 23);
            this.UserFormCancelButton.TabIndex = 1;
            this.UserFormCancelButton.Text = "Cancel";
            this.UserFormCancelButton.UseVisualStyleBackColor = true;
            this.UserFormCancelButton.Click += new System.EventHandler(this.UserFormCancelButton_Click);
            // 
            // UserFormSaveButton
            // 
            this.UserFormSaveButton.Location = new System.Drawing.Point(251, 172);
            this.UserFormSaveButton.Name = "UserFormSaveButton";
            this.UserFormSaveButton.Size = new System.Drawing.Size(75, 23);
            this.UserFormSaveButton.TabIndex = 2;
            this.UserFormSaveButton.Text = "Save";
            this.UserFormSaveButton.UseVisualStyleBackColor = true;
            this.UserFormSaveButton.Click += new System.EventHandler(this.UserFormSaveButton_Click);
            // 
            // UserFormDeleteButton
            // 
            this.UserFormDeleteButton.Location = new System.Drawing.Point(336, 100);
            this.UserFormDeleteButton.Name = "UserFormDeleteButton";
            this.UserFormDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.UserFormDeleteButton.TabIndex = 3;
            this.UserFormDeleteButton.Text = "Delete";
            this.UserFormDeleteButton.UseVisualStyleBackColor = true;
            this.UserFormDeleteButton.Click += new System.EventHandler(this.UserFormDeleteButton_Click);
            // 
            // UserFormAddButton
            // 
            this.UserFormAddButton.Location = new System.Drawing.Point(336, 42);
            this.UserFormAddButton.Name = "UserFormAddButton";
            this.UserFormAddButton.Size = new System.Drawing.Size(75, 23);
            this.UserFormAddButton.TabIndex = 4;
            this.UserFormAddButton.Text = "Add";
            this.UserFormAddButton.UseVisualStyleBackColor = true;
            this.UserFormAddButton.Click += new System.EventHandler(this.UserFormAddButton_Click);
            // 
            // UserFormModifyButton
            // 
            this.UserFormModifyButton.Location = new System.Drawing.Point(336, 71);
            this.UserFormModifyButton.Name = "UserFormModifyButton";
            this.UserFormModifyButton.Size = new System.Drawing.Size(75, 23);
            this.UserFormModifyButton.TabIndex = 5;
            this.UserFormModifyButton.Text = "Edit";
            this.UserFormModifyButton.UseVisualStyleBackColor = true;
            this.UserFormModifyButton.Click += new System.EventHandler(this.UserFormModifyButton_Click);
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "userId";
            this.userIdDataGridViewTextBoxColumn.FillWeight = 10F;
            this.userIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "userName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(AaronMorris_C969_Task1.Models.User);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 207);
            this.Controls.Add(this.UserFormModifyButton);
            this.Controls.Add(this.UserFormAddButton);
            this.Controls.Add(this.UserFormDeleteButton);
            this.Controls.Add(this.UserFormSaveButton);
            this.Controls.Add(this.UserFormCancelButton);
            this.Controls.Add(this.UserDGV);
            this.Name = "UserForm";
            this.Text = "Users";
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UserDGV;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Button UserFormCancelButton;
        private System.Windows.Forms.Button UserFormSaveButton;
        private System.Windows.Forms.Button UserFormDeleteButton;
        private System.Windows.Forms.Button UserFormAddButton;
        private System.Windows.Forms.Button UserFormModifyButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
    }
}