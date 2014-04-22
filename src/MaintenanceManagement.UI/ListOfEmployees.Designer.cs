namespace MaintenanceManagement.UI
{
    partial class ListOfEmployees
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
            this.previewOfEmployee = new System.Windows.Forms.Button();
            this.editEmployee = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.newEmployee = new System.Windows.Forms.Button();
            this.deleteEmployee = new System.Windows.Forms.Button();
            this.employeesList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // previewOfEmployee
            // 
            this.previewOfEmployee.Location = new System.Drawing.Point(281, 80);
            this.previewOfEmployee.Name = "previewOfEmployee";
            this.previewOfEmployee.Size = new System.Drawing.Size(75, 23);
            this.previewOfEmployee.TabIndex = 2;
            this.previewOfEmployee.Text = "Podgląd";
            this.previewOfEmployee.UseVisualStyleBackColor = true;
            this.previewOfEmployee.Click += new System.EventHandler(this.previewOfEmployee_Click);
            // 
            // editEmployee
            // 
            this.editEmployee.Location = new System.Drawing.Point(281, 109);
            this.editEmployee.Name = "editEmployee";
            this.editEmployee.Size = new System.Drawing.Size(75, 23);
            this.editEmployee.TabIndex = 3;
            this.editEmployee.Text = "Edycja";
            this.editEmployee.UseVisualStyleBackColor = true;
            this.editEmployee.Click += new System.EventHandler(this.editEmployee_Click);
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button3.Location = new System.Drawing.Point(200, 356);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.Location = new System.Drawing.Point(281, 356);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Anuluj";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // newEmployee
            // 
            this.newEmployee.Location = new System.Drawing.Point(281, 12);
            this.newEmployee.Name = "newEmployee";
            this.newEmployee.Size = new System.Drawing.Size(75, 23);
            this.newEmployee.TabIndex = 6;
            this.newEmployee.Text = "Nowy";
            this.newEmployee.UseVisualStyleBackColor = true;
            this.newEmployee.Click += new System.EventHandler(this.newEmployee_Click);
            // 
            // deleteEmployee
            // 
            this.deleteEmployee.Location = new System.Drawing.Point(281, 138);
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.Size = new System.Drawing.Size(75, 23);
            this.deleteEmployee.TabIndex = 18;
            this.deleteEmployee.Text = "Usuń";
            this.deleteEmployee.UseVisualStyleBackColor = true;
            // 
            // employeesList
            // 
            this.employeesList.FormattingEnabled = true;
            this.employeesList.Location = new System.Drawing.Point(12, 8);
            this.employeesList.Name = "employeesList";
            this.employeesList.Size = new System.Drawing.Size(263, 342);
            this.employeesList.TabIndex = 19;
            // 
            // ListOfEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 391);
            this.Controls.Add(this.employeesList);
            this.Controls.Add(this.deleteEmployee);
            this.Controls.Add(this.newEmployee);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.editEmployee);
            this.Controls.Add(this.previewOfEmployee);
            this.Name = "ListOfEmployees";
            this.Text = "Lista pracowników";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button previewOfEmployee;
        private System.Windows.Forms.Button editEmployee;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button newEmployee;
        private System.Windows.Forms.Button deleteEmployee;
        private System.Windows.Forms.ListBox employeesList;

    }
}