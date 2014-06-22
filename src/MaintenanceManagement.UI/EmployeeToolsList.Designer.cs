namespace MaintenanceManagement.UI
{
    using MaintenanceManagement.UI.Core;

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
            this.toolsListDataGrid = new MmDataGrid();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ToolType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.toolsListDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeToolsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceManagementDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.toolsListDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolsListDataGrid.Location = new System.Drawing.Point(0, 0);
            this.toolsListDataGrid.Name = "toolsListDataGrid";
            this.toolsListDataGrid.Size = new System.Drawing.Size(885, 366);
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
            this.newTool.Location = new System.Drawing.Point(3, 3);
            this.newTool.Name = "newTool";
            this.newTool.Size = new System.Drawing.Size(75, 23);
            this.newTool.TabIndex = 1;
            this.newTool.Text = "Nowe";
            this.newTool.UseVisualStyleBackColor = true;
            this.newTool.Click += new System.EventHandler(this.newTool_Click);
            // 
            // editTool
            // 
            this.editTool.Location = new System.Drawing.Point(3, 32);
            this.editTool.Name = "editTool";
            this.editTool.Size = new System.Drawing.Size(75, 23);
            this.editTool.TabIndex = 2;
            this.editTool.Text = "Edytuj";
            this.editTool.UseVisualStyleBackColor = true;
            this.editTool.Click += new System.EventHandler(this.editTool_Click);
            // 
            // deleteTool
            // 
            this.deleteTool.Location = new System.Drawing.Point(3, 61);
            this.deleteTool.Name = "deleteTool";
            this.deleteTool.Size = new System.Drawing.Size(75, 23);
            this.deleteTool.TabIndex = 3;
            this.deleteTool.Text = "Usuń";
            this.deleteTool.UseVisualStyleBackColor = true;
            this.deleteTool.Click += new System.EventHandler(this.deleteTool_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button5.Location = new System.Drawing.Point(801, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Anuluj";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button6.Location = new System.Drawing.Point(720, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "OK";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // toolOwner
            // 
            this.toolOwner.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.toolOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolOwner.Location = new System.Drawing.Point(3, 7);
            this.toolOwner.Name = "toolOwner";
            this.toolOwner.ReadOnly = true;
            this.toolOwner.Size = new System.Drawing.Size(159, 22);
            this.toolOwner.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pracownik";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolsListDataGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(96, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 366);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolOwner);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(96, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 34);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(96, 415);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(885, 44);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.newTool);
            this.panel4.Controls.Add(this.editTool);
            this.panel4.Controls.Add(this.deleteTool);
            this.panel4.Location = new System.Drawing.Point(3, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(87, 100);
            this.panel4.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 462);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // ToolType
            // 
            this.ToolType.DataPropertyName = "ToolTypeName";
            this.ToolType.HeaderText = "Rodzaj narzędzia";
            this.ToolType.Name = "ToolType";
            this.ToolType.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Ilość sztuk";
            this.Quantity.Name = "Quantity";
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDateText";
            this.StartDate.HeaderText = "Data wydania";
            this.StartDate.Name = "StartDate";
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDateText";
            this.EndDate.HeaderText = "Data zwrotu";
            this.EndDate.Name = "EndDate";
            // 
            // EndReason
            // 
            this.EndReason.DataPropertyName = "EndReasonName";
            this.EndReason.HeaderText = "Przyczyna zwrotu";
            this.EndReason.Name = "EndReason";
            this.EndReason.Width = 150;
            // 
            // Comment
            // 
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "Uwagi";
            this.Comment.Name = "Comment";
            this.Comment.Width = 150;
            // 
            // EmployeeToolsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EmployeeToolsList";
            this.Text = "Lista narzędzi pracownika";
            ((System.ComponentModel.ISupportInitialize)(this.toolsListDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeToolsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceManagementDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MmDataGrid toolsListDataGrid;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToolType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
    }
}