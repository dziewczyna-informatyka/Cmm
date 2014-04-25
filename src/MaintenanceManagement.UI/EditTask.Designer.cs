namespace MaintenanceManagement.UI
{
    partial class EditTask
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
            this.taskResponsibleEmployee = new System.Windows.Forms.TextBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceManagementDataSet = new MaintenanceManagement.UI.MaintenanceManagementDataSet();
            this.taskArea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.taskSubject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.taskActions = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.taskDueDate = new System.Windows.Forms.DateTimePicker();
            this.saveTask = new System.Windows.Forms.Button();
            this.cancelTask = new System.Windows.Forms.Button();
            this.employeesTableAdapter = new MaintenanceManagement.UI.MaintenanceManagementDataSetTableAdapters.EmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Osoba odpowiedzialna";
            // 
            // taskResponsibleEmployee
            // 
            this.taskResponsibleEmployee.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.employeesBindingSource, "Surname", true));
            this.taskResponsibleEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taskResponsibleEmployee.Location = new System.Drawing.Point(203, 6);
            this.taskResponsibleEmployee.Name = "taskResponsibleEmployee";
            this.taskResponsibleEmployee.Size = new System.Drawing.Size(200, 21);
            this.taskResponsibleEmployee.TabIndex = 1;
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
            // taskArea
            // 
            this.taskArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taskArea.Location = new System.Drawing.Point(203, 35);
            this.taskArea.Name = "taskArea";
            this.taskArea.Size = new System.Drawing.Size(200, 21);
            this.taskArea.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Obszar";
            // 
            // taskSubject
            // 
            this.taskSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taskSubject.Location = new System.Drawing.Point(203, 61);
            this.taskSubject.Multiline = true;
            this.taskSubject.Name = "taskSubject";
            this.taskSubject.Size = new System.Drawing.Size(200, 49);
            this.taskSubject.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Temat";
            // 
            // taskActions
            // 
            this.taskActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taskActions.Location = new System.Drawing.Point(203, 116);
            this.taskActions.Multiline = true;
            this.taskActions.Name = "taskActions";
            this.taskActions.Size = new System.Drawing.Size(200, 110);
            this.taskActions.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Czynności";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Planowana data zakończenia";
            // 
            // taskDueDate
            // 
            this.taskDueDate.Location = new System.Drawing.Point(203, 232);
            this.taskDueDate.Name = "taskDueDate";
            this.taskDueDate.Size = new System.Drawing.Size(200, 20);
            this.taskDueDate.TabIndex = 9;
            // 
            // saveTask
            // 
            this.saveTask.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveTask.Location = new System.Drawing.Point(247, 269);
            this.saveTask.Name = "saveTask";
            this.saveTask.Size = new System.Drawing.Size(75, 23);
            this.saveTask.TabIndex = 10;
            this.saveTask.Text = "Zapisz";
            this.saveTask.UseVisualStyleBackColor = true;
            // 
            // cancelTask
            // 
            this.cancelTask.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelTask.Location = new System.Drawing.Point(328, 269);
            this.cancelTask.Name = "cancelTask";
            this.cancelTask.Size = new System.Drawing.Size(75, 23);
            this.cancelTask.TabIndex = 11;
            this.cancelTask.Text = "Anuluj";
            this.cancelTask.UseVisualStyleBackColor = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // EditTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 302);
            this.Controls.Add(this.cancelTask);
            this.Controls.Add(this.saveTask);
            this.Controls.Add(this.taskDueDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.taskActions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.taskSubject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.taskArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.taskResponsibleEmployee);
            this.Controls.Add(this.label1);
            this.Name = "EditTask";
            this.Text = "Zadanie";
            this.Load += new System.EventHandler(this.NewEmployeeTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceManagementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox taskResponsibleEmployee;
        private System.Windows.Forms.TextBox taskArea;
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
        private MaintenanceManagementDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
    }
}