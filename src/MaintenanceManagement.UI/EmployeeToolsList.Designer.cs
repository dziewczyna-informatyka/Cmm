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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolEndReasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeToolsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceManagementDataSet = new MaintenanceManagement.UI.MaintenanceManagementDataSet();
            this.employeeToolsTableAdapter = new MaintenanceManagement.UI.MaintenanceManagementDataSetTableAdapters.EmployeeToolsTableAdapter();
            this.newTool = new System.Windows.Forms.Button();
            this.editTool = new System.Windows.Forms.Button();
            this.deleteTool = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeToolsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.toolTypeIdDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.toolEndReasonDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeToolsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 374);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolTypeIdDataGridViewTextBoxColumn
            // 
            this.toolTypeIdDataGridViewTextBoxColumn.DataPropertyName = "ToolType_Id";
            this.toolTypeIdDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.toolTypeIdDataGridViewTextBoxColumn.Name = "toolTypeIdDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Ilość";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "Data wydania";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "Data zwrotu";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // toolEndReasonDataGridViewTextBoxColumn
            // 
            this.toolEndReasonDataGridViewTextBoxColumn.DataPropertyName = "ToolEndReason";
            this.toolEndReasonDataGridViewTextBoxColumn.HeaderText = "Przyczyna zwrotu";
            this.toolEndReasonDataGridViewTextBoxColumn.Name = "toolEndReasonDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Uwagi";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
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
            this.newTool.Location = new System.Drawing.Point(684, 12);
            this.newTool.Name = "newTool";
            this.newTool.Size = new System.Drawing.Size(75, 23);
            this.newTool.TabIndex = 1;
            this.newTool.Text = "Nowe";
            this.newTool.UseVisualStyleBackColor = true;
            this.newTool.Click += new System.EventHandler(this.newTool_Click);
            // 
            // editTool
            // 
            this.editTool.Location = new System.Drawing.Point(684, 41);
            this.editTool.Name = "editTool";
            this.editTool.Size = new System.Drawing.Size(75, 23);
            this.editTool.TabIndex = 2;
            this.editTool.Text = "Edytuj";
            this.editTool.UseVisualStyleBackColor = true;
            this.editTool.Click += new System.EventHandler(this.editTool_Click);
            // 
            // deleteTool
            // 
            this.deleteTool.Location = new System.Drawing.Point(684, 70);
            this.deleteTool.Name = "deleteTool";
            this.deleteTool.Size = new System.Drawing.Size(75, 23);
            this.deleteTool.TabIndex = 3;
            this.deleteTool.Text = "Usuń";
            this.deleteTool.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button5.Location = new System.Drawing.Point(700, 398);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Anuluj";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button6.Location = new System.Drawing.Point(619, 398);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "OK";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // EmployeeToolsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 433);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.deleteTool);
            this.Controls.Add(this.editTool);
            this.Controls.Add(this.newTool);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmployeeToolsList";
            this.Text = "Lista narzędzi pracownika";
            //this.Load += new System.EventHandler(this.EmployeeToolsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeToolsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceManagementDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MaintenanceManagementDataSet maintenanceManagementDataSet;
        private System.Windows.Forms.BindingSource employeeToolsBindingSource;
        private MaintenanceManagementDataSetTableAdapters.EmployeeToolsTableAdapter employeeToolsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolEndReasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button newTool;
        private System.Windows.Forms.Button editTool;
        private System.Windows.Forms.Button deleteTool;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}