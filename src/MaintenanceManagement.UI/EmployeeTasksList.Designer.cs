namespace MaintenanceManagement.UI
{
    partial class EmployeeTasksList
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.employeeTasksGridView = new System.Windows.Forms.DataGridView();
            this.employeeTasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceManagementDataSet = new MaintenanceManagement.UI.MaintenanceManagementDataSet();
            this.responsibleEmployee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tasksStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeTasksTableAdapter = new MaintenanceManagement.UI.MaintenanceManagementDataSetTableAdapters.EmployeeTasksTableAdapter();
            this.editTask = new System.Windows.Forms.Button();
            this.Assignee_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Progress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTasksGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(702, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(783, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Anuluj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // employeeTasksGridView
            // 
            this.employeeTasksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeTasksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Assignee_Id,
            this.AreaName,
            this.Subject,
            this.Actions,
            this.Progress,
            this.DaysRemaining,
            this.DueDate});
            this.employeeTasksGridView.Location = new System.Drawing.Point(12, 36);
            this.employeeTasksGridView.Name = "employeeTasksGridView";
            this.employeeTasksGridView.Size = new System.Drawing.Size(846, 252);
            this.employeeTasksGridView.TabIndex = 3;
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
            // responsibleEmployee
            // 
            this.responsibleEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.responsibleEmployee.Location = new System.Drawing.Point(88, 6);
            this.responsibleEmployee.Name = "responsibleEmployee";
            this.responsibleEmployee.ReadOnly = true;
            this.responsibleEmployee.Size = new System.Drawing.Size(159, 22);
            this.responsibleEmployee.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pracownik";
            // 
            // tasksStatus
            // 
            this.tasksStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tasksStatus.Location = new System.Drawing.Point(349, 6);
            this.tasksStatus.Name = "tasksStatus";
            this.tasksStatus.ReadOnly = true;
            this.tasksStatus.Size = new System.Drawing.Size(159, 22);
            this.tasksStatus.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Status";
            // 
            // employeeTasksTableAdapter
            // 
            this.employeeTasksTableAdapter.ClearBeforeFill = true;
            // 
            // editTask
            // 
            this.editTask.Location = new System.Drawing.Point(621, 296);
            this.editTask.Name = "editTask";
            this.editTask.Size = new System.Drawing.Size(75, 23);
            this.editTask.TabIndex = 10;
            this.editTask.Text = "Edytuj";
            this.editTask.UseVisualStyleBackColor = true;
            this.editTask.Click += new System.EventHandler(this.editTask_Click);
            // 
            // Assignee_Id
            // 
            this.Assignee_Id.DataPropertyName = "AssigneeName";
            this.Assignee_Id.HeaderText = "Osoba odpowiedzialna";
            this.Assignee_Id.Name = "Assignee_Id";
            // 
            // AreaName
            // 
            this.AreaName.DataPropertyName = "AreaName";
            this.AreaName.HeaderText = "Obszar";
            this.AreaName.Name = "AreaName";
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
            // EmployeeTasksList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 343);
            this.Controls.Add(this.editTask);
            this.Controls.Add(this.tasksStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.responsibleEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.employeeTasksGridView);
            this.Name = "EmployeeTasksList";
            this.Text = "Lista zadań pracownika";
            ((System.ComponentModel.ISupportInitialize)(this.employeeTasksGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceManagementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView employeeTasksGridView;
        private System.Windows.Forms.TextBox responsibleEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tasksStatus;
        private System.Windows.Forms.Label label1;
        private MaintenanceManagementDataSet maintenanceManagementDataSet;
        private System.Windows.Forms.BindingSource employeeTasksBindingSource;
        private MaintenanceManagementDataSetTableAdapters.EmployeeTasksTableAdapter employeeTasksTableAdapter;


        private System.Windows.Forms.Button editTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assignee_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Progress;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysRemaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
    }
}