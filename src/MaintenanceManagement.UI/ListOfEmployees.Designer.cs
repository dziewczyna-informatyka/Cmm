namespace MaintenanceManagement.UI
{
    partial class ListOfEmployees
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
            this.previewOfEmployee = new System.Windows.Forms.Button();
            this.editEmployee = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.newEmployee = new System.Windows.Forms.Button();
            this.deleteEmployee = new System.Windows.Forms.Button();
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceManagementDataSet = new MaintenanceManagement.UI.MaintenanceManagementDataSet();
            this.employeesTableAdapter = new MaintenanceManagement.UI.MaintenanceManagementDataSetTableAdapters.EmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // previewOfEmployee
            // 
            this.previewOfEmployee.Location = new System.Drawing.Point(500, 79);
            this.previewOfEmployee.Name = "previewOfEmployee";
            this.previewOfEmployee.Size = new System.Drawing.Size(75, 23);
            this.previewOfEmployee.TabIndex = 2;
            this.previewOfEmployee.Text = "Podgląd";
            this.previewOfEmployee.UseVisualStyleBackColor = true;
            this.previewOfEmployee.Click += new System.EventHandler(this.previewOfEmployee_Click);
            // 
            // editEmployee
            // 
            this.editEmployee.Location = new System.Drawing.Point(500, 108);
            this.editEmployee.Name = "editEmployee";
            this.editEmployee.Size = new System.Drawing.Size(75, 23);
            this.editEmployee.TabIndex = 3;
            this.editEmployee.Text = "Edycja";
            this.editEmployee.UseVisualStyleBackColor = true;
            this.editEmployee.Click += new System.EventHandler(this.editEmployee_Click);
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button3.Location = new System.Drawing.Point(419, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.Location = new System.Drawing.Point(500, 355);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Anuluj";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // newEmployee
            // 
            this.newEmployee.Location = new System.Drawing.Point(500, 11);
            this.newEmployee.Name = "newEmployee";
            this.newEmployee.Size = new System.Drawing.Size(75, 23);
            this.newEmployee.TabIndex = 6;
            this.newEmployee.Text = "Nowy";
            this.newEmployee.UseVisualStyleBackColor = true;
            this.newEmployee.Click += new System.EventHandler(this.newEmployee_Click);
            // 
            // deleteEmployee
            // 
            this.deleteEmployee.Location = new System.Drawing.Point(500, 137);
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.Size = new System.Drawing.Size(75, 23);
            this.deleteEmployee.TabIndex = 18;
            this.deleteEmployee.Text = "Usuń";
            this.deleteEmployee.UseVisualStyleBackColor = true;
            this.deleteEmployee.Click += new System.EventHandler(this.deleteEmployee_Click);
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.AllowUserToAddRows = false;
            this.employeesDataGridView.AllowUserToDeleteRows = false;
            this.employeesDataGridView.AllowUserToOrderColumns = true;
            this.employeesDataGridView.AutoGenerateColumns = false;
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.personalNumberDataGridViewTextBoxColumn});
            this.employeesDataGridView.DataSource = this.employeesBindingSource;
            this.employeesDataGridView.Location = new System.Drawing.Point(12, 11);
            this.employeesDataGridView.MultiSelect = false;
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.ReadOnly = true;
            this.employeesDataGridView.Size = new System.Drawing.Size(482, 339);
            this.employeesDataGridView.TabIndex = 19;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Imię";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personalNumberDataGridViewTextBoxColumn
            // 
            this.personalNumberDataGridViewTextBoxColumn.DataPropertyName = "PersonalNumber";
            this.personalNumberDataGridViewTextBoxColumn.HeaderText = "Nr personalny";
            this.personalNumberDataGridViewTextBoxColumn.Name = "personalNumberDataGridViewTextBoxColumn";
            this.personalNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.maintenanceManagementDataSet;
            // 
            // maintenanceManagementDataSet
            // 
            this.maintenanceManagementDataSet.DataSetName = "MaintenanceManagementDataSet";
            this.maintenanceManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // ListOfEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 391);
            this.Controls.Add(this.employeesDataGridView);
            this.Controls.Add(this.deleteEmployee);
            this.Controls.Add(this.newEmployee);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.editEmployee);
            this.Controls.Add(this.previewOfEmployee);
            this.Name = "ListOfEmployees";
            this.Text = "Lista pracowników";
            this.Load += new System.EventHandler(this.ListOfEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceManagementDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button previewOfEmployee;
        private System.Windows.Forms.Button editEmployee;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button newEmployee;
        private System.Windows.Forms.Button deleteEmployee;
        private System.Windows.Forms.DataGridView employeesDataGridView;
        private MaintenanceManagementDataSet maintenanceManagementDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private MaintenanceManagementDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalNumberDataGridViewTextBoxColumn;

    }
}