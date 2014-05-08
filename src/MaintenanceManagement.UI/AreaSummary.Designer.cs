namespace MaintenanceManagement.UI
{
    partial class AreaSummary
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
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceManagementDataSet = new MaintenanceManagement.UI.MaintenanceManagementDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.employeesArea = new System.Windows.Forms.TextBox();
            this.employeesTableAdapter = new MaintenanceManagement.UI.MaintenanceManagementDataSetTableAdapters.EmployeesTableAdapter();
            this.employeeTasksDetails = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.totalTasksAmount = new System.Windows.Forms.TextBox();
            this.allTasks = new System.Windows.Forms.Button();
            this.newTasksCreator = new System.Windows.Forms.Button();
            this.doneTasksAmount = new System.Windows.Forms.TextBox();
            this.actualTasksAmount = new System.Windows.Forms.TextBox();
            this.plannedTasksAmount = new System.Windows.Forms.TextBox();
            this.doneTasks = new System.Windows.Forms.Button();
            this.actualTasks = new System.Windows.Forms.Button();
            this.plannedTasks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceManagementDataSet)).BeginInit();
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
            this.employeesDataGridView.Location = new System.Drawing.Point(204, 58);
            this.employeesDataGridView.MultiSelect = false;
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.ReadOnly = true;
            this.employeesDataGridView.Size = new System.Drawing.Size(354, 261);
            this.employeesDataGridView.TabIndex = 20;
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
            this.employeesArea.Size = new System.Drawing.Size(133, 20);
            this.employeesArea.TabIndex = 22;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTasksDetails
            // 
            this.employeeTasksDetails.Location = new System.Drawing.Point(15, 271);
            this.employeeTasksDetails.Name = "employeeTasksDetails";
            this.employeeTasksDetails.Size = new System.Drawing.Size(85, 48);
            this.employeeTasksDetails.TabIndex = 23;
            this.employeeTasksDetails.Text = "Szczegóły zadań pracownika";
            this.employeeTasksDetails.UseVisualStyleBackColor = true;
            this.employeeTasksDetails.Click += new System.EventHandler(this.employeeTasksDetails_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(483, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Anuluj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(402, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // totalTasksAmount
            // 
            this.totalTasksAmount.Location = new System.Drawing.Point(138, 172);
            this.totalTasksAmount.Name = "totalTasksAmount";
            this.totalTasksAmount.ReadOnly = true;
            this.totalTasksAmount.Size = new System.Drawing.Size(36, 20);
            this.totalTasksAmount.TabIndex = 34;
            // 
            // allTasks
            // 
            this.allTasks.Location = new System.Drawing.Point(15, 169);
            this.allTasks.Name = "allTasks";
            this.allTasks.Size = new System.Drawing.Size(85, 23);
            this.allTasks.TabIndex = 33;
            this.allTasks.Text = "Wszystkie";
            this.allTasks.UseVisualStyleBackColor = true;
            this.allTasks.Click += new System.EventHandler(this.allTasks_Click);
            // 
            // newTasksCreator
            // 
            this.newTasksCreator.Location = new System.Drawing.Point(15, 219);
            this.newTasksCreator.Name = "newTasksCreator";
            this.newTasksCreator.Size = new System.Drawing.Size(85, 35);
            this.newTasksCreator.TabIndex = 32;
            this.newTasksCreator.Text = "Nowe zadanie";
            this.newTasksCreator.UseVisualStyleBackColor = true;
            this.newTasksCreator.Click += new System.EventHandler(this.newTasksCreator_Click);
            // 
            // doneTasksAmount
            // 
            this.doneTasksAmount.Location = new System.Drawing.Point(138, 134);
            this.doneTasksAmount.Name = "doneTasksAmount";
            this.doneTasksAmount.ReadOnly = true;
            this.doneTasksAmount.Size = new System.Drawing.Size(36, 20);
            this.doneTasksAmount.TabIndex = 31;
            // 
            // actualTasksAmount
            // 
            this.actualTasksAmount.Location = new System.Drawing.Point(138, 96);
            this.actualTasksAmount.Name = "actualTasksAmount";
            this.actualTasksAmount.ReadOnly = true;
            this.actualTasksAmount.Size = new System.Drawing.Size(36, 20);
            this.actualTasksAmount.TabIndex = 30;
            // 
            // plannedTasksAmount
            // 
            this.plannedTasksAmount.Location = new System.Drawing.Point(138, 58);
            this.plannedTasksAmount.Name = "plannedTasksAmount";
            this.plannedTasksAmount.ReadOnly = true;
            this.plannedTasksAmount.Size = new System.Drawing.Size(36, 20);
            this.plannedTasksAmount.TabIndex = 29;
            // 
            // doneTasks
            // 
            this.doneTasks.Location = new System.Drawing.Point(15, 132);
            this.doneTasks.Name = "doneTasks";
            this.doneTasks.Size = new System.Drawing.Size(85, 23);
            this.doneTasks.TabIndex = 28;
            this.doneTasks.Text = "Zakończone";
            this.doneTasks.UseVisualStyleBackColor = true;
            this.doneTasks.Click += new System.EventHandler(this.doneTasks_Click);
            // 
            // actualTasks
            // 
            this.actualTasks.Location = new System.Drawing.Point(15, 95);
            this.actualTasks.Name = "actualTasks";
            this.actualTasks.Size = new System.Drawing.Size(85, 23);
            this.actualTasks.TabIndex = 27;
            this.actualTasks.Text = "W realizacji";
            this.actualTasks.UseVisualStyleBackColor = true;
            this.actualTasks.Click += new System.EventHandler(this.actualTasks_Click);
            // 
            // plannedTasks
            // 
            this.plannedTasks.Location = new System.Drawing.Point(15, 58);
            this.plannedTasks.Name = "plannedTasks";
            this.plannedTasks.Size = new System.Drawing.Size(85, 23);
            this.plannedTasks.TabIndex = 26;
            this.plannedTasks.Text = "Zaplanowane";
            this.plannedTasks.UseVisualStyleBackColor = true;
            this.plannedTasks.Click += new System.EventHandler(this.plannedTasks_Click);
            // 
            // AreaSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 356);
            this.Controls.Add(this.totalTasksAmount);
            this.Controls.Add(this.allTasks);
            this.Controls.Add(this.newTasksCreator);
            this.Controls.Add(this.doneTasksAmount);
            this.Controls.Add(this.actualTasksAmount);
            this.Controls.Add(this.plannedTasksAmount);
            this.Controls.Add(this.doneTasks);
            this.Controls.Add(this.actualTasks);
            this.Controls.Add(this.plannedTasks);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.employeeTasksDetails);
            this.Controls.Add(this.employeesArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeesDataGridView);
            this.Name = "AreaSummary";
            this.Text = "Podsumowanie obszaru";
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceManagementDataSet)).EndInit();
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
        private System.Windows.Forms.TextBox totalTasksAmount;
        private System.Windows.Forms.Button allTasks;
        private System.Windows.Forms.Button newTasksCreator;
        private System.Windows.Forms.TextBox doneTasksAmount;
        private System.Windows.Forms.TextBox actualTasksAmount;
        private System.Windows.Forms.TextBox plannedTasksAmount;
        private System.Windows.Forms.Button doneTasks;
        private System.Windows.Forms.Button actualTasks;
        private System.Windows.Forms.Button plannedTasks;
    }
}