namespace MaintenanceManagement.UI
{
    partial class AreasList
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.editArea = new System.Windows.Forms.Button();
            this.deleteArea = new System.Windows.Forms.Button();
            this.areaList = new System.Windows.Forms.ListBox();
            this.areaName = new System.Windows.Forms.TextBox();
            this.addNewArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(211, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Anuluj";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(130, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // editArea
            // 
            this.editArea.Location = new System.Drawing.Point(211, 68);
            this.editArea.Name = "editArea";
            this.editArea.Size = new System.Drawing.Size(75, 23);
            this.editArea.TabIndex = 32;
            this.editArea.Text = "Edycja";
            this.editArea.UseVisualStyleBackColor = true;
            this.editArea.Click += new System.EventHandler(this.editArea_Click);
            // 
            // deleteArea
            // 
            this.deleteArea.Location = new System.Drawing.Point(211, 117);
            this.deleteArea.Name = "deleteArea";
            this.deleteArea.Size = new System.Drawing.Size(75, 23);
            this.deleteArea.TabIndex = 31;
            this.deleteArea.Text = "Usuń";
            this.deleteArea.UseVisualStyleBackColor = true;
            this.deleteArea.Click += new System.EventHandler(this.deleteArea_Click);
            // 
            // areaList
            // 
            this.areaList.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.areaList.FormattingEnabled = true;
            this.areaList.Location = new System.Drawing.Point(12, 48);
            this.areaList.Name = "areaList";
            this.areaList.Size = new System.Drawing.Size(193, 303);
            this.areaList.TabIndex = 30;
            this.areaList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.areaList_DoubleClick);
            // 
            // areaName
            // 
            this.areaName.Location = new System.Drawing.Point(12, 19);
            this.areaName.Name = "areaName";
            this.areaName.Size = new System.Drawing.Size(193, 20);
            this.areaName.TabIndex = 29;
            // 
            // addNewArea
            // 
            this.addNewArea.Location = new System.Drawing.Point(211, 19);
            this.addNewArea.Name = "addNewArea";
            this.addNewArea.Size = new System.Drawing.Size(75, 23);
            this.addNewArea.TabIndex = 28;
            this.addNewArea.Text = "Dodaj";
            this.addNewArea.UseVisualStyleBackColor = true;
            this.addNewArea.Click += new System.EventHandler(this.addNewArea_Click);
            // 
            // AreasList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 396);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editArea);
            this.Controls.Add(this.deleteArea);
            this.Controls.Add(this.areaList);
            this.Controls.Add(this.areaName);
            this.Controls.Add(this.addNewArea);
            this.Name = "AreasList";
            this.Text = "Lista obszarów";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button editArea;
        private System.Windows.Forms.Button deleteArea;
        private System.Windows.Forms.ListBox areaList;
        private System.Windows.Forms.TextBox areaName;
        private System.Windows.Forms.Button addNewArea;

    }
}