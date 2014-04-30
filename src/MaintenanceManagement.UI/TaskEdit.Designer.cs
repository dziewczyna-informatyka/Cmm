namespace MaintenanceManagement.UI
{
    partial class TaskEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceManagementDataSet = new MaintenanceManagement.UI.MaintenanceManagementDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.taskSubject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.taskActions = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.taskDueDate = new System.Windows.Forms.DateTimePicker();
            this.saveTask = new System.Windows.Forms.Button();
            this.cancelTask = new System.Windows.Forms.Button();
            this.taskAssignee = new System.Windows.Forms.ComboBox();
            this.taskStatus = new System.Windows.Forms.ComboBox();
            this.employeeTasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.employeeTasksTableAdapter = new MaintenanceManagement.UI.MaintenanceManagementDataSetTableAdapters.EmployeeTasksTableAdapter();
            this.taskProgress = new System.Windows.Forms.TextBox();
            this.taskArea = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTasksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Osoba odpowiedzialna";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Obszar";
            // 
            // taskSubject
            // 
            this.taskSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taskSubject.Location = new System.Drawing.Point(203, 67);
            this.taskSubject.Multiline = true;
            this.taskSubject.Name = "taskSubject";
            this.taskSubject.Size = new System.Drawing.Size(200, 49);
            this.taskSubject.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Temat";
            // 
            // taskActions
            // 
            this.taskActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taskActions.Location = new System.Drawing.Point(203, 124);
            this.taskActions.Multiline = true;
            this.taskActions.Name = "taskActions";
            this.taskActions.Size = new System.Drawing.Size(200, 110);
            this.taskActions.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Czynności";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Planowana data zakończenia";
            // 
            // taskDueDate
            // 
            this.taskDueDate.CustomFormat = "0000-00-00";
            this.taskDueDate.Location = new System.Drawing.Point(203, 242);
            this.taskDueDate.Name = "taskDueDate";
            this.taskDueDate.Size = new System.Drawing.Size(200, 20);
            this.taskDueDate.TabIndex = 9;
            // 
            // saveTask
            // 
            this.saveTask.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveTask.Location = new System.Drawing.Point(247, 375);
            this.saveTask.Name = "saveTask";
            this.saveTask.Size = new System.Drawing.Size(75, 23);
            this.saveTask.TabIndex = 10;
            this.saveTask.Text = "Zapisz";
            this.saveTask.UseVisualStyleBackColor = true;
            this.saveTask.Click += new System.EventHandler(this.saveTask_Click);
            // 
            // cancelTask
            // 
            this.cancelTask.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelTask.Location = new System.Drawing.Point(328, 375);
            this.cancelTask.Name = "cancelTask";
            this.cancelTask.Size = new System.Drawing.Size(75, 23);
            this.cancelTask.TabIndex = 11;
            this.cancelTask.Text = "Anuluj";
            this.cancelTask.UseVisualStyleBackColor = true;
            // 
            // taskAssignee
            // 
            this.taskAssignee.FormattingEnabled = true;
            this.taskAssignee.Location = new System.Drawing.Point(203, 9);
            this.taskAssignee.Name = "taskAssignee";
            this.taskAssignee.Size = new System.Drawing.Size(200, 21);
            this.taskAssignee.TabIndex = 48;
            // 
            // taskStatus
            // 
            this.taskStatus.DataSource = this.employeeTasksBindingSource;
            this.taskStatus.FormattingEnabled = true;
            this.taskStatus.Location = new System.Drawing.Point(203, 270);
            this.taskStatus.Name = "taskStatus";
            this.taskStatus.Size = new System.Drawing.Size(200, 21);
            this.taskStatus.TabIndex = 50;
            // 
            // employeeTasksBindingSource
            // 
            this.employeeTasksBindingSource.DataMember = "EmployeeTasks";
            this.employeeTasksBindingSource.DataSource = this.maintenanceManagementDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 49;
            this.label6.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(12, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 51;
            this.label7.Text = "Wykonanie";
            // 
            // employeeTasksTableAdapter
            // 
            this.employeeTasksTableAdapter.ClearBeforeFill = true;
            // 
            // taskProgress
            // 
            this.taskProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taskProgress.Location = new System.Drawing.Point(203, 299);
            this.taskProgress.Name = "taskProgress";
            this.taskProgress.Size = new System.Drawing.Size(200, 21);
            this.taskProgress.TabIndex = 52;
            // 
            // taskArea
            // 
            this.taskArea.FormattingEnabled = true;
            this.taskArea.Location = new System.Drawing.Point(203, 38);
            this.taskArea.Name = "taskArea";
            this.taskArea.Size = new System.Drawing.Size(200, 21);
            this.taskArea.TabIndex = 53;
            // 
            // TaskEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 410);
            this.Controls.Add(this.taskArea);
            this.Controls.Add(this.taskProgress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.taskStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.taskAssignee);
            this.Controls.Add(this.cancelTask);
            this.Controls.Add(this.saveTask);
            this.Controls.Add(this.taskDueDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.taskActions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.taskSubject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TaskEdit";
            this.Text = "Zadanie";
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTasksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox taskSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox taskActions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker taskDueDate;
        private System.Windows.Forms.Button saveTask;
        private System.Windows.Forms.Button cancelTask;
        private MaintenanceManagementDataSet maintenanceManagementDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private System.Windows.Forms.ComboBox taskAssignee;
        private System.Windows.Forms.ComboBox taskStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource employeeTasksBindingSource;
        private MaintenanceManagementDataSetTableAdapters.EmployeeTasksTableAdapter employeeTasksTableAdapter;
        private System.Windows.Forms.TextBox taskProgress;
        private System.Windows.Forms.ComboBox taskArea;
    }
}