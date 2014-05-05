namespace MaintenanceManagement.UI
{
    partial class EmployeeToolsList
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
            this.toolsListDataGrid = new System.Windows.Forms.DataGridView();
            this.employeeToolsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceManagementDataSet = new MaintenanceManagement.UI.MaintenanceManagementDataSet();
            this.employeeToolsTableAdapter = new MaintenanceManagement.UI.MaintenanceManagementDataSetTableAdapters.EmployeeToolsTableAdapter();
            this.newTool = new System.Windows.Forms.Button();
            this.editTool = new System.Windows.Forms.Button();
            this.deleteTool = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.toolOwner = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ToolType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.toolsListDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeToolsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolsListDataGrid
            // 
            this.toolsListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toolsListDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ToolType,
            this.Quantity,
            this.StartDate,
            this.EndDate,
            this.EndReason,
            this.Comment});
            this.toolsListDataGrid.Location = new System.Drawing.Point(12, 40);
            this.toolsListDataGrid.Name = "toolsListDataGrid";
            this.toolsListDataGrid.Size = new System.Drawing.Size(643, 374);
            this.toolsListDataGrid.TabIndex = 0;
            // 
            // employeeToolsBindingSource
            // 
            this.employeeToolsBindingSource.DataMember = "EmployeeTools";
            this.employeeToolsBindingSource.DataSource = this.maintenanceManagementDataSet;
            // 
            // maintenanceManagementDataSet
            // 
            this.maintenanceManagementDataSet.DataSetName = "MaintenanceManagementDataSet";
            this.maintenanceManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeToolsTableAdapter
            // 
            this.employeeToolsTableAdapter.ClearBeforeFill = true;
            // 
            // newTool
            // 
            this.newTool.Location = new System.Drawing.Point(684, 40);
            this.newTool.Name = "newTool";
            this.newTool.Size = new System.Drawing.Size(75, 23);
            this.newTool.TabIndex = 1;
            this.newTool.Text = "Nowe";
            this.newTool.UseVisualStyleBackColor = true;
            this.newTool.Click += new System.EventHandler(this.newTool_Click);
            // 
            // editTool
            // 
            this.editTool.Location = new System.Drawing.Point(684, 69);
            this.editTool.Name = "editTool";
            this.editTool.Size = new System.Drawing.Size(75, 23);
            this.editTool.TabIndex = 2;
            this.editTool.Text = "Edytuj";
            this.editTool.UseVisualStyleBackColor = true;
            this.editTool.Click += new System.EventHandler(this.editTool_Click);
            // 
            // deleteTool
            // 
            this.deleteTool.Location = new System.Drawing.Point(684, 98);
            this.deleteTool.Name = "deleteTool";
            this.deleteTool.Size = new System.Drawing.Size(75, 23);
            this.deleteTool.TabIndex = 3;
            this.deleteTool.Text = "Usuń";
            this.deleteTool.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button5.Location = new System.Drawing.Point(684, 431);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Anuluj";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button6.Location = new System.Drawing.Point(603, 431);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "OK";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // toolOwner
            // 
            this.toolOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolOwner.Location = new System.Drawing.Point(85, 6);
            this.toolOwner.Name = "toolOwner";
            this.toolOwner.ReadOnly = true;
            this.toolOwner.Size = new System.Drawing.Size(159, 22);
            this.toolOwner.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pracownik";
            // 
            // ToolType
            // 
            this.ToolType.DataPropertyName = "ToolTypeName";
            this.ToolType.HeaderText = "Rodzaj narzędzia";
            this.ToolType.Name = "ToolType";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Ilość sztuk";
            this.Quantity.Name = "Quantity";
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.HeaderText = "Data wydania";
            this.StartDate.Name = "StartDate";
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.HeaderText = "Data zwrotu";
            this.EndDate.Name = "EndDate";
            // 
            // EndReason
            // 
            this.EndReason.DataPropertyName = "EndReason";
            this.EndReason.HeaderText = "Przyczyna zwrotu";
            this.EndReason.Name = "EndReason";
            // 
            // Comment
            // 
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "Uwagi";
            this.Comment.Name = "Comment";
            // 
            // EmployeeToolsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 469);
            this.Controls.Add(this.toolOwner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.deleteTool);
            this.Controls.Add(this.editTool);
            this.Controls.Add(this.newTool);
            this.Controls.Add(this.toolsListDataGrid);
            this.Name = "EmployeeToolsList";
            this.Text = "Lista narzędzi pracownika";
            ((System.ComponentModel.ISupportInitialize)(this.toolsListDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeToolsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceManagementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView toolsListDataGrid;
        private MaintenanceManagementDataSet maintenanceManagementDataSet;
        private System.Windows.Forms.BindingSource employeeToolsBindingSource;
        private MaintenanceManagementDataSetTableAdapters.EmployeeToolsTableAdapter employeeToolsTableAdapter;
        private System.Windows.Forms.Button newTool;
        private System.Windows.Forms.Button editTool;
        private System.Windows.Forms.Button deleteTool;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox toolOwner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToolType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
    }
}