namespace MaintenanceManagement.UI
{
    partial class TasksList
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
            this.taskListDataGrid = new System.Windows.Forms.DataGridView();
            this.employeeTasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceManagementDataSet = new MaintenanceManagement.UI.MaintenanceManagementDataSet();
            this.employeeTasksTableAdapter = new MaintenanceManagement.UI.MaintenanceManagementDataSetTableAdapters.EmployeeTasksTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tasksStatus = new System.Windows.Forms.TextBox();
            this.AssigneeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Progress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.taskListDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // taskListDataGrid
            // 
            this.taskListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskListDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssigneeId,
            this.AreaId,
            this.Subject,
            this.Actions,
            this.Progress,
            this.DaysRemaining,
            this.DueDate});
            this.taskListDataGrid.Location = new System.Drawing.Point(12, 45);
            this.taskListDataGrid.Name = "taskListDataGrid";
            this.taskListDataGrid.Size = new System.Drawing.Size(846, 252);
            this.taskListDataGrid.TabIndex = 0;
            // 
            // employeeTasksBindingSource
            // 
            this.employeeTasksBindingSource.DataMember = "EmployeeTasks";
            this.employeeTasksBindingSource.DataSource = this.maintenanceManagementDataSet;
            // 
            // maintenanceManagementDataSet
            // 
            this.maintenanceManagementDataSet.DataSetName = "MaintenanceManagementDataSet";
            this.maintenanceManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTasksTableAdapter
            // 
            this.employeeTasksTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(783, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Anuluj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(702, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status";
            // 
            // tasksStatus
            // 
            this.tasksStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tasksStatus.Location = new System.Drawing.Point(64, 13);
            this.tasksStatus.Name = "tasksStatus";
            this.tasksStatus.ReadOnly = true;
            this.tasksStatus.Size = new System.Drawing.Size(100, 22);
            this.tasksStatus.TabIndex = 4;
            // 
            // AssigneeId
            // 
            this.AssigneeId.DataPropertyName = "AssigneeName";
            this.AssigneeId.HeaderText = "Osoba odpowiedzialna";
            this.AssigneeId.Name = "AssigneeId";
            // 
            // AreaId
            // 
            this.AreaId.DataPropertyName = "AreaName";
            this.AreaId.HeaderText = "Obszar";
            this.AreaId.Name = "AreaId";
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.HeaderText = "Temat";
            this.Subject.Name = "Subject";
            // 
            // Actions
            // 
            this.Actions.DataPropertyName = "Actions";
            this.Actions.HeaderText = "Czynności";
            this.Actions.Name = "Actions";
            // 
            // Progress
            // 
            this.Progress.DataPropertyName = "Progress";
            this.Progress.HeaderText = "Wykonanie";
            this.Progress.Name = "Progress";
            // 
            // DaysRemaining
            // 
            this.DaysRemaining.DataPropertyName = "DaysRemaining";
            this.DaysRemaining.HeaderText = "Pozostalo Dni";
            this.DaysRemaining.Name = "DaysRemaining";
            // 
            // DueDate
            // 
            this.DueDate.DataPropertyName = "DueDateText";
            this.DueDate.HeaderText = "Data zakończenia";
            this.DueDate.Name = "DueDate";
            // 
            // TasksList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 340);
            this.Controls.Add(this.tasksStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.taskListDataGrid);
            this.Name = "TasksList";
            this.Text = "Lista zadań";
            ((System.ComponentModel.ISupportInitialize)(this.taskListDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceManagementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView taskListDataGrid;
        private MaintenanceManagementDataSet maintenanceManagementDataSet;
        private System.Windows.Forms.BindingSource employeeTasksBindingSource;
        private MaintenanceManagementDataSetTableAdapters.EmployeeTasksTableAdapter employeeTasksTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tasksStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssigneeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Progress;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysRemaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
    }
}