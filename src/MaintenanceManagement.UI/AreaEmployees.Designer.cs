namespace MaintenanceManagement.UI
{
    partial class AreaEmployees
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
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.employeesArea = new System.Windows.Forms.TextBox();
            this.maintenanceManagementDataSet = new MaintenanceManagement.UI.MaintenanceManagementDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new MaintenanceManagement.UI.MaintenanceManagementDataSetTableAdapters.EmployeesTableAdapter();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeTasksDetails = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.employeesDataGridView.Location = new System.Drawing.Point(12, 41);
            this.employeesDataGridView.MultiSelect = false;
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.ReadOnly = true;
            this.employeesDataGridView.Size = new System.Drawing.Size(354, 310);
            this.employeesDataGridView.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Obszar";
            // 
            // employeesArea
            // 
            this.employeesArea.Location = new System.Drawing.Point(87, 8);
            this.employeesArea.Name = "employeesArea";
            this.employeesArea.ReadOnly = true;
            this.employeesArea.Size = new System.Drawing.Size(100, 20);
            this.employeesArea.TabIndex = 22;
            // 
            // maintenanceManagementDataSet
            // 
            this.maintenanceManagementDataSet.DataSetName = "MaintenanceManagementDataSet";
            this.maintenanceManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.maintenanceManagementDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
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
            // employeeTasksDetails
            // 
            this.employeeTasksDetails.Location = new System.Drawing.Point(419, 41);
            this.employeeTasksDetails.Name = "employeeTasksDetails";
            this.employeeTasksDetails.Size = new System.Drawing.Size(75, 23);
            this.employeeTasksDetails.TabIndex = 23;
            this.employeeTasksDetails.Text = "Szczegóły";
            this.employeeTasksDetails.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(431, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Anuluj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(350, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AreaEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 392);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.employeeTasksDetails);
            this.Controls.Add(this.employeesArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeesDataGridView);
            this.Name = "AreaEmployees";
            this.Text = "Pracownicy obszaru";
            this.Load += new System.EventHandler(this.AreaEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox employeesArea;
        private MaintenanceManagementDataSet maintenanceManagementDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private MaintenanceManagementDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button employeeTasksDetails;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}