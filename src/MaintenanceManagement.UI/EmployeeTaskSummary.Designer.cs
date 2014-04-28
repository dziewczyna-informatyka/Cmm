namespace MaintenanceManagement.UI
{
    partial class EmployeeTaskSummary
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
            this.plannedTasks = new System.Windows.Forms.Button();
            this.actualTasks = new System.Windows.Forms.Button();
            this.responsibleEmployee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.plannedTasksAmount = new System.Windows.Forms.TextBox();
            this.actualTasksAmount = new System.Windows.Forms.TextBox();
            this.newTasksCreator = new System.Windows.Forms.Button();
            this.employeeTools = new System.Windows.Forms.Button();
            this.doneTasks = new System.Windows.Forms.Button();
            this.doneTasksAmount = new System.Windows.Forms.TextBox();
            this.totalTasksAmount = new System.Windows.Forms.TextBox();
            this.allTasks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plannedTasks
            // 
            this.plannedTasks.Location = new System.Drawing.Point(15, 64);
            this.plannedTasks.Name = "plannedTasks";
            this.plannedTasks.Size = new System.Drawing.Size(85, 23);
            this.plannedTasks.TabIndex = 0;
            this.plannedTasks.Text = "Zaplanowane";
            this.plannedTasks.UseVisualStyleBackColor = true;
            this.plannedTasks.Click += new System.EventHandler(this.plannedTasks_Click);
            // 
            // actualTasks
            // 
            this.actualTasks.Location = new System.Drawing.Point(15, 101);
            this.actualTasks.Name = "actualTasks";
            this.actualTasks.Size = new System.Drawing.Size(85, 23);
            this.actualTasks.TabIndex = 1;
            this.actualTasks.Text = "W realizacji";
            this.actualTasks.UseVisualStyleBackColor = true;
            this.actualTasks.Click += new System.EventHandler(this.actualTasks_Click);
            // 
            // responsibleEmployee
            // 
            this.responsibleEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.responsibleEmployee.Location = new System.Drawing.Point(15, 28);
            this.responsibleEmployee.Name = "responsibleEmployee";
            this.responsibleEmployee.ReadOnly = true;
            this.responsibleEmployee.Size = new System.Drawing.Size(159, 22);
            this.responsibleEmployee.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pracownik";
            // 
            // button5
            // 
            this.button5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button5.Location = new System.Drawing.Point(242, 227);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Anuluj";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button6.Location = new System.Drawing.Point(161, 227);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "OK";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // plannedTasksAmount
            // 
            this.plannedTasksAmount.Location = new System.Drawing.Point(138, 64);
            this.plannedTasksAmount.Name = "plannedTasksAmount";
            this.plannedTasksAmount.ReadOnly = true;
            this.plannedTasksAmount.Size = new System.Drawing.Size(36, 20);
            this.plannedTasksAmount.TabIndex = 12;
            // 
            // actualTasksAmount
            // 
            this.actualTasksAmount.Location = new System.Drawing.Point(138, 102);
            this.actualTasksAmount.Name = "actualTasksAmount";
            this.actualTasksAmount.ReadOnly = true;
            this.actualTasksAmount.Size = new System.Drawing.Size(36, 20);
            this.actualTasksAmount.TabIndex = 13;
            // 
            // newTasksCreator
            // 
            this.newTasksCreator.Location = new System.Drawing.Point(221, 28);
            this.newTasksCreator.Name = "newTasksCreator";
            this.newTasksCreator.Size = new System.Drawing.Size(96, 35);
            this.newTasksCreator.TabIndex = 15;
            this.newTasksCreator.Text = "Nowe zadanie";
            this.newTasksCreator.UseVisualStyleBackColor = true;
            this.newTasksCreator.Click += new System.EventHandler(this.newTasksCreator_Click);
            // 
            // employeeTools
            // 
            this.employeeTools.Location = new System.Drawing.Point(221, 110);
            this.employeeTools.Name = "employeeTools";
            this.employeeTools.Size = new System.Drawing.Size(96, 35);
            this.employeeTools.TabIndex = 16;
            this.employeeTools.Text = "Narzędzia";
            this.employeeTools.UseVisualStyleBackColor = true;
            this.employeeTools.Click += new System.EventHandler(this.employeeTools_Click);
            // 
            // doneTasks
            // 
            this.doneTasks.Location = new System.Drawing.Point(15, 138);
            this.doneTasks.Name = "doneTasks";
            this.doneTasks.Size = new System.Drawing.Size(85, 23);
            this.doneTasks.TabIndex = 2;
            this.doneTasks.Text = "Zakończone";
            this.doneTasks.UseVisualStyleBackColor = true;
            this.doneTasks.Click += new System.EventHandler(this.doneTasks_Click);
            // 
            // doneTasksAmount
            // 
            this.doneTasksAmount.Location = new System.Drawing.Point(138, 140);
            this.doneTasksAmount.Name = "doneTasksAmount";
            this.doneTasksAmount.ReadOnly = true;
            this.doneTasksAmount.Size = new System.Drawing.Size(36, 20);
            this.doneTasksAmount.TabIndex = 14;
            // 
            // totalTasksAmount
            // 
            this.totalTasksAmount.Location = new System.Drawing.Point(138, 178);
            this.totalTasksAmount.Name = "totalTasksAmount";
            this.totalTasksAmount.ReadOnly = true;
            this.totalTasksAmount.Size = new System.Drawing.Size(36, 20);
            this.totalTasksAmount.TabIndex = 18;
            // 
            // allTasks
            // 
            this.allTasks.Location = new System.Drawing.Point(15, 175);
            this.allTasks.Name = "allTasks";
            this.allTasks.Size = new System.Drawing.Size(85, 23);
            this.allTasks.TabIndex = 17;
            this.allTasks.Text = "Wszystkie";
            this.allTasks.UseVisualStyleBackColor = true;
            this.allTasks.Click += new System.EventHandler(this.allTasks_Click);
            // 
            // EmployeeTaskSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 264);
            this.Controls.Add(this.totalTasksAmount);
            this.Controls.Add(this.allTasks);
            this.Controls.Add(this.employeeTools);
            this.Controls.Add(this.newTasksCreator);
            this.Controls.Add(this.doneTasksAmount);
            this.Controls.Add(this.actualTasksAmount);
            this.Controls.Add(this.plannedTasksAmount);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.responsibleEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.doneTasks);
            this.Controls.Add(this.actualTasks);
            this.Controls.Add(this.plannedTasks);
            this.Name = "EmployeeTaskSummary";
            this.Text = "Podsumowanie zadań pracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plannedTasks;
        private System.Windows.Forms.Button actualTasks;
        private System.Windows.Forms.TextBox responsibleEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox plannedTasksAmount;
        private System.Windows.Forms.TextBox actualTasksAmount;
        private System.Windows.Forms.Button newTasksCreator;
        private System.Windows.Forms.Button employeeTools;
        private System.Windows.Forms.Button doneTasks;
        private System.Windows.Forms.TextBox doneTasksAmount;
        private System.Windows.Forms.TextBox totalTasksAmount;
        private System.Windows.Forms.Button allTasks;

    }
}