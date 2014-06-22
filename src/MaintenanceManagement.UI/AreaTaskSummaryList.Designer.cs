namespace MaintenanceManagement.UI
{
    using MaintenanceManagement.UI.Core;

    partial class AreaTaskSummaryList
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.areaTasksGridView = new MmDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.assignedArea = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.editTask = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Assignee_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Progress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualendDateText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaTasksGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 462);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.areaTasksGridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(978, 366);
            this.panel3.TabIndex = 21;
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
            this.Status,
            this.Progress,
            this.DaysRemaining,
            this.DueDate,
            this.ActualendDateText});
            this.areaTasksGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.areaTasksGridView.Location = new System.Drawing.Point(0, 0);
            this.areaTasksGridView.Name = "areaTasksGridView";
            this.areaTasksGridView.Size = new System.Drawing.Size(978, 366);
            this.areaTasksGridView.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.assignedArea);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 34);
            this.panel1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Obszar";
            // 
            // assignedArea
            // 
            this.assignedArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.assignedArea.Location = new System.Drawing.Point(82, 8);
            this.assignedArea.Name = "assignedArea";
            this.assignedArea.ReadOnly = true;
            this.assignedArea.Size = new System.Drawing.Size(159, 22);
            this.assignedArea.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.editTask);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 415);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(978, 44);
            this.panel2.TabIndex = 20;
            // 
            // editTask
            // 
            this.editTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editTask.Location = new System.Drawing.Point(738, 12);
            this.editTask.Name = "editTask";
            this.editTask.Size = new System.Drawing.Size(75, 23);
            this.editTask.TabIndex = 18;
            this.editTask.Text = "Edytuj";
            this.editTask.UseVisualStyleBackColor = true;
            this.editTask.Click += new System.EventHandler(this.editTask_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(900, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Anuluj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(819, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
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
            // Status
            // 
            this.Status.DataPropertyName = "StatusName";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 62;
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
            // AreaTaskSummaryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AreaTaskSummaryList";
            this.Text = "Lista wszystkich zadań";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.areaTasksGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private MmDataGrid areaTasksGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox assignedArea;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button editTask;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assignee_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Progress;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysRemaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualendDateText;
    }
}