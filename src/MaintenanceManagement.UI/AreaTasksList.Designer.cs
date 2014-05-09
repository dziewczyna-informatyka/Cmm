namespace MaintenanceManagement.UI
{
    partial class AreaTasksList
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
            this.editTask = new System.Windows.Forms.Button();
            this.assignedArea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.areaTasksGridView = new System.Windows.Forms.DataGridView();
            this.Assignee_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Progress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualendDateText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasksStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.areaTasksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // editTask
            // 
            this.editTask.Location = new System.Drawing.Point(621, 299);
            this.editTask.Name = "editTask";
            this.editTask.Size = new System.Drawing.Size(75, 23);
            this.editTask.TabIndex = 18;
            this.editTask.Text = "Edytuj";
            this.editTask.UseVisualStyleBackColor = true;
            this.editTask.Click += new System.EventHandler(this.editTask_Click);
            // 
            // assignedArea
            // 
            this.assignedArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.assignedArea.Location = new System.Drawing.Point(88, 9);
            this.assignedArea.Name = "assignedArea";
            this.assignedArea.ReadOnly = true;
            this.assignedArea.Size = new System.Drawing.Size(159, 22);
            this.assignedArea.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Obszar";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(702, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(783, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Anuluj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // areaTasksGridView
            // 
            this.areaTasksGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.areaTasksGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.areaTasksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.areaTasksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Assignee_Id,
            this.Subject,
            this.Actions,
            this.Progress,
            this.DaysRemaining,
            this.DueDate,
            this.ActualendDateText});
            this.areaTasksGridView.Location = new System.Drawing.Point(12, 39);
            this.areaTasksGridView.Name = "areaTasksGridView";
            this.areaTasksGridView.Size = new System.Drawing.Size(846, 252);
            this.areaTasksGridView.TabIndex = 11;
            // 
            // Assignee_Id
            // 
            this.Assignee_Id.DataPropertyName = "AssigneeName";
            this.Assignee_Id.HeaderText = "Osoba odpowiedzialna";
            this.Assignee_Id.Name = "Assignee_Id";
            this.Assignee_Id.Width = 127;
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.HeaderText = "Temat";
            this.Subject.Name = "Subject";
            this.Subject.Width = 62;
            // 
            // Actions
            // 
            this.Actions.DataPropertyName = "Actions";
            this.Actions.HeaderText = "Czynności";
            this.Actions.Name = "Actions";
            this.Actions.Width = 80;
            // 
            // Progress
            // 
            this.Progress.DataPropertyName = "Progress";
            this.Progress.HeaderText = "Wykonanie";
            this.Progress.Name = "Progress";
            this.Progress.Width = 86;
            // 
            // DaysRemaining
            // 
            this.DaysRemaining.DataPropertyName = "DaysRemaining";
            this.DaysRemaining.HeaderText = "Pozostało dni";
            this.DaysRemaining.Name = "DaysRemaining";
            this.DaysRemaining.Width = 89;
            // 
            // DueDate
            // 
            this.DueDate.DataPropertyName = "DueDateText";
            this.DueDate.HeaderText = "Data zakończenia";
            this.DueDate.Name = "DueDate";
            this.DueDate.Width = 108;
            // 
            // ActualendDateText
            // 
            this.ActualendDateText.DataPropertyName = "ActualendDateText";
            this.ActualendDateText.HeaderText = "Faktyczne zakończenie";
            this.ActualendDateText.Name = "ActualendDateText";
            this.ActualendDateText.Width = 132;
            // 
            // tasksStatus
            // 
            this.tasksStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tasksStatus.Location = new System.Drawing.Point(349, 9);
            this.tasksStatus.Name = "tasksStatus";
            this.tasksStatus.ReadOnly = true;
            this.tasksStatus.Size = new System.Drawing.Size(159, 22);
            this.tasksStatus.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(299, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Status";
            // 
            // AreaTasksList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 329);
            this.Controls.Add(this.editTask);
            this.Controls.Add(this.tasksStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.assignedArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.areaTasksGridView);
            this.Name = "AreaTasksList";
            this.Text = "Lista zadań w obszarze";
            ((System.ComponentModel.ISupportInitialize)(this.areaTasksGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editTask;
        private System.Windows.Forms.TextBox assignedArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView areaTasksGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assignee_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Progress;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysRemaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualendDateText;
        private System.Windows.Forms.TextBox tasksStatus;
        private System.Windows.Forms.Label label1;
    }
}