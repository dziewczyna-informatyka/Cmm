namespace MaintenanceManagement.UI
{
    partial class TasksSummaryList
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
            this.tasksListDataGrid = new System.Windows.Forms.DataGridView();
            this.employeeTasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceManagementDataSet = new MaintenanceManagement.UI.MaintenanceManagementDataSet();
            this.employeeTasksTableAdapter = new MaintenanceManagement.UI.MaintenanceManagementDataSetTableAdapters.EmployeeTasksTableAdapter();
            this.doneTasksAmount = new System.Windows.Forms.TextBox();
            this.actualTasksAmount = new System.Windows.Forms.TextBox();
            this.plannedTasksAmount = new System.Windows.Forms.TextBox();
            this.doneTasks = new System.Windows.Forms.Button();
            this.actualTasks = new System.Windows.Forms.Button();
            this.plannedTasks = new System.Windows.Forms.Button();
            this.totalTasksAmount = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AsigneeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Progress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualendDateText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tasksListDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(714, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(795, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Anuluj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tasksListDataGrid
            // 
            this.tasksListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tasksListDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AsigneeId,
            this.Area,
            this.Subject,
            this.Actions,
            this.Status,
            this.Progress,
            this.DueDate,
            this.ActualendDateText});
            this.tasksListDataGrid.Location = new System.Drawing.Point(12, 48);
            this.tasksListDataGrid.Name = "tasksListDataGrid";
            this.tasksListDataGrid.Size = new System.Drawing.Size(858, 452);
            this.tasksListDataGrid.TabIndex = 3;
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
            // doneTasksAmount
            // 
            this.doneTasksAmount.Location = new System.Drawing.Point(417, 12);
            this.doneTasksAmount.Name = "doneTasksAmount";
            this.doneTasksAmount.ReadOnly = true;
            this.doneTasksAmount.Size = new System.Drawing.Size(36, 20);
            this.doneTasksAmount.TabIndex = 24;
            // 
            // actualTasksAmount
            // 
            this.actualTasksAmount.Location = new System.Drawing.Point(260, 12);
            this.actualTasksAmount.Name = "actualTasksAmount";
            this.actualTasksAmount.ReadOnly = true;
            this.actualTasksAmount.Size = new System.Drawing.Size(36, 20);
            this.actualTasksAmount.TabIndex = 23;
            // 
            // plannedTasksAmount
            // 
            this.plannedTasksAmount.Location = new System.Drawing.Point(103, 12);
            this.plannedTasksAmount.Name = "plannedTasksAmount";
            this.plannedTasksAmount.ReadOnly = true;
            this.plannedTasksAmount.Size = new System.Drawing.Size(36, 20);
            this.plannedTasksAmount.TabIndex = 22;
            // 
            // doneTasks
            // 
            this.doneTasks.Location = new System.Drawing.Point(326, 10);
            this.doneTasks.Name = "doneTasks";
            this.doneTasks.Size = new System.Drawing.Size(85, 23);
            this.doneTasks.TabIndex = 21;
            this.doneTasks.Text = "Zakończone";
            this.doneTasks.UseVisualStyleBackColor = true;
            this.doneTasks.Click += new System.EventHandler(this.doneTasks_Click);
            // 
            // actualTasks
            // 
            this.actualTasks.Location = new System.Drawing.Point(169, 10);
            this.actualTasks.Name = "actualTasks";
            this.actualTasks.Size = new System.Drawing.Size(85, 23);
            this.actualTasks.TabIndex = 20;
            this.actualTasks.Text = "W realizacji";
            this.actualTasks.UseVisualStyleBackColor = true;
            this.actualTasks.Click += new System.EventHandler(this.actualTasks_Click);
            // 
            // plannedTasks
            // 
            this.plannedTasks.Location = new System.Drawing.Point(12, 10);
            this.plannedTasks.Name = "plannedTasks";
            this.plannedTasks.Size = new System.Drawing.Size(85, 23);
            this.plannedTasks.TabIndex = 19;
            this.plannedTasks.Text = "Zaplanowane";
            this.plannedTasks.UseVisualStyleBackColor = true;
            this.plannedTasks.Click += new System.EventHandler(this.plannedTasks_Click);
            // 
            // totalTasksAmount
            // 
            this.totalTasksAmount.Location = new System.Drawing.Point(574, 12);
            this.totalTasksAmount.Name = "totalTasksAmount";
            this.totalTasksAmount.ReadOnly = true;
            this.totalTasksAmount.Size = new System.Drawing.Size(36, 20);
            this.totalTasksAmount.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(492, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(67, 20);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "Sumarycznie";
            // 
            // AsigneeId
            // 
            this.AsigneeId.DataPropertyName = "AssigneeName";
            this.AsigneeId.HeaderText = "Osoba odpowiedzialna";
            this.AsigneeId.Name = "AsigneeId";
            this.AsigneeId.ReadOnly = true;
            // 
            // Area
            // 
            this.Area.DataPropertyName = "AreaName";
            this.Area.HeaderText = "Obszar";
            this.Area.Name = "Area";
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
            // Status
            // 
            this.Status.DataPropertyName = "StatusName";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Progress
            // 
            this.Progress.DataPropertyName = "Progress";
            this.Progress.HeaderText = "Wykonanie";
            this.Progress.Name = "Progress";
            // 
            // DueDate
            // 
            this.DueDate.DataPropertyName = "DueDateText";
            this.DueDate.HeaderText = "Data zakończenia";
            this.DueDate.Name = "DueDate";
            // 
            // ActualendDateText
            // 
            this.ActualendDateText.DataPropertyName = "ActualendDateText";
            this.ActualendDateText.HeaderText = "Faktyczne zakonczenie";
            this.ActualendDateText.Name = "ActualendDateText";
            // 
            // TasksSummaryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 541);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.totalTasksAmount);
            this.Controls.Add(this.doneTasksAmount);
            this.Controls.Add(this.actualTasksAmount);
            this.Controls.Add(this.plannedTasksAmount);
            this.Controls.Add(this.doneTasks);
            this.Controls.Add(this.actualTasks);
            this.Controls.Add(this.plannedTasks);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tasksListDataGrid);
            this.Name = "TasksSummaryList";
            this.Text = "Lista wszystkich zadań";
            ((System.ComponentModel.ISupportInitialize)(this.tasksListDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceManagementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tasksListDataGrid;
        private MaintenanceManagementDataSet maintenanceManagementDataSet;
        private System.Windows.Forms.BindingSource employeeTasksBindingSource;
        private MaintenanceManagementDataSetTableAdapters.EmployeeTasksTableAdapter employeeTasksTableAdapter;
        private System.Windows.Forms.TextBox doneTasksAmount;
        private System.Windows.Forms.TextBox actualTasksAmount;
        private System.Windows.Forms.TextBox plannedTasksAmount;
        private System.Windows.Forms.Button doneTasks;
        private System.Windows.Forms.Button actualTasks;
        private System.Windows.Forms.Button plannedTasks;
        private System.Windows.Forms.TextBox totalTasksAmount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AsigneeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Progress;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualendDateText;
    }
}