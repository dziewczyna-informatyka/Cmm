namespace MaintenanceManagement.UI
{
    partial class ListOfTools
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
            this.deleteTool = new System.Windows.Forms.Button();
            this.toolTypesList = new System.Windows.Forms.ListBox();
            this.toolTypeName = new System.Windows.Forms.TextBox();
            this.addNewTool = new System.Windows.Forms.Button();
            this.editTool = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deleteTool
            // 
            this.deleteTool.Location = new System.Drawing.Point(211, 117);
            this.deleteTool.Name = "deleteTool";
            this.deleteTool.Size = new System.Drawing.Size(75, 23);
            this.deleteTool.TabIndex = 24;
            this.deleteTool.Text = "Usuń";
            this.deleteTool.UseVisualStyleBackColor = true;
            this.deleteTool.Click += new System.EventHandler(this.deleteTool_Click);
            // 
            // toolTypesList
            // 
            this.toolTypesList.FormattingEnabled = true;
            this.toolTypesList.Location = new System.Drawing.Point(12, 48);
            this.toolTypesList.Name = "toolTypesList";
            this.toolTypesList.Size = new System.Drawing.Size(193, 303);
            this.toolTypesList.TabIndex = 23;
            this.toolTypesList.DoubleClick += new System.EventHandler(this.toolTypesList_DoubleClick);
            // 
            // toolTypeName
            // 
            this.toolTypeName.Location = new System.Drawing.Point(12, 19);
            this.toolTypeName.Name = "toolTypeName";
            this.toolTypeName.Size = new System.Drawing.Size(193, 20);
            this.toolTypeName.TabIndex = 22;
            // 
            // addNewTool
            // 
            this.addNewTool.Location = new System.Drawing.Point(211, 19);
            this.addNewTool.Name = "addNewTool";
            this.addNewTool.Size = new System.Drawing.Size(75, 23);
            this.addNewTool.TabIndex = 21;
            this.addNewTool.Text = "Dodaj";
            this.addNewTool.UseVisualStyleBackColor = true;
            this.addNewTool.Click += new System.EventHandler(this.addNewTool_Click);
            // 
            // editTool
            // 
            this.editTool.Location = new System.Drawing.Point(211, 68);
            this.editTool.Name = "editTool";
            this.editTool.Size = new System.Drawing.Size(75, 23);
            this.editTool.TabIndex = 25;
            this.editTool.Text = "Edycja";
            this.editTool.UseVisualStyleBackColor = true;
            this.editTool.Click += new System.EventHandler(this.editTool_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(12, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(211, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Anuluj";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ListOfTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 396);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editTool);
            this.Controls.Add(this.deleteTool);
            this.Controls.Add(this.toolTypesList);
            this.Controls.Add(this.toolTypeName);
            this.Controls.Add(this.addNewTool);
            this.Name = "ListOfTools";
            this.Text = "Tools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteTool;
        private System.Windows.Forms.ListBox toolTypesList;
        private System.Windows.Forms.TextBox toolTypeName;
        private System.Windows.Forms.Button addNewTool;
        private System.Windows.Forms.Button editTool;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}