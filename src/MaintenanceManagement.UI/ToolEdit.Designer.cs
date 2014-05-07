namespace MaintenanceManagement.UI
{
    partial class ToolEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStartDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.toolComment = new System.Windows.Forms.TextBox();
            this.toolEndDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolOwner = new System.Windows.Forms.ComboBox();
            this.toolTypeComboBox = new System.Windows.Forms.ComboBox();
            this.toolEndReason = new System.Windows.Forms.ComboBox();
            this.cbToolReturned = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pracownik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rodzaj narzędzia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ilość";
            // 
            // toolQuantity
            // 
            this.toolQuantity.Location = new System.Drawing.Point(109, 68);
            this.toolQuantity.Name = "toolQuantity";
            this.toolQuantity.Size = new System.Drawing.Size(163, 20);
            this.toolQuantity.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data wydania";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data zwrotu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Przyczyna zwrotu";
            // 
            // toolStartDate
            // 
            this.toolStartDate.CustomFormat = "0000-00-00";
            this.toolStartDate.Location = new System.Drawing.Point(109, 94);
            this.toolStartDate.Name = "toolStartDate";
            this.toolStartDate.Size = new System.Drawing.Size(163, 20);
            this.toolStartDate.TabIndex = 12;
            this.toolStartDate.Value = new System.DateTime(2014, 4, 25, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Uwagi";
            // 
            // toolComment
            // 
            this.toolComment.Location = new System.Drawing.Point(109, 120);
            this.toolComment.Multiline = true;
            this.toolComment.Name = "toolComment";
            this.toolComment.Size = new System.Drawing.Size(163, 78);
            this.toolComment.TabIndex = 13;
            // 
            // toolEndDate
            // 
            this.toolEndDate.Cursor = System.Windows.Forms.Cursors.No;
            this.toolEndDate.CustomFormat = "0000-00-00";
            this.toolEndDate.Enabled = false;
            this.toolEndDate.Location = new System.Drawing.Point(109, 247);
            this.toolEndDate.Name = "toolEndDate";
            this.toolEndDate.Size = new System.Drawing.Size(163, 20);
            this.toolEndDate.TabIndex = 15;
            this.toolEndDate.Value = new System.DateTime(2014, 5, 7, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(196, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Anuluj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(115, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Zapisz";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // toolOwner
            // 
            this.toolOwner.FormattingEnabled = true;
            this.toolOwner.Location = new System.Drawing.Point(109, 15);
            this.toolOwner.Name = "toolOwner";
            this.toolOwner.Size = new System.Drawing.Size(163, 21);
            this.toolOwner.TabIndex = 18;
            // 
            // toolTypeComboBox
            // 
            this.toolTypeComboBox.FormattingEnabled = true;
            this.toolTypeComboBox.Location = new System.Drawing.Point(109, 42);
            this.toolTypeComboBox.Name = "toolTypeComboBox";
            this.toolTypeComboBox.Size = new System.Drawing.Size(163, 21);
            this.toolTypeComboBox.TabIndex = 19;
            // 
            // toolEndReason
            // 
            this.toolEndReason.Enabled = false;
            this.toolEndReason.FormattingEnabled = true;
            this.toolEndReason.Location = new System.Drawing.Point(108, 273);
            this.toolEndReason.Name = "toolEndReason";
            this.toolEndReason.Size = new System.Drawing.Size(163, 21);
            this.toolEndReason.TabIndex = 20;
            // 
            // cbToolReturned
            // 
            this.cbToolReturned.AutoSize = true;
            this.cbToolReturned.Location = new System.Drawing.Point(109, 224);
            this.cbToolReturned.Name = "cbToolReturned";
            this.cbToolReturned.Size = new System.Drawing.Size(122, 17);
            this.cbToolReturned.TabIndex = 22;
            this.cbToolReturned.Text = "Narzedzie zwrócono";
            this.cbToolReturned.UseVisualStyleBackColor = true;
            this.cbToolReturned.CheckedChanged += new System.EventHandler(this.cbToolReturned_CheckedChanged);
            // 
            // ToolEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 337);
            this.Controls.Add(this.cbToolReturned);
            this.Controls.Add(this.toolEndReason);
            this.Controls.Add(this.toolTypeComboBox);
            this.Controls.Add(this.toolOwner);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolEndDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.toolComment);
            this.Controls.Add(this.toolStartDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toolQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ToolEdit";
            this.Text = "Narzędzie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox toolQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker toolStartDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox toolComment;
        private System.Windows.Forms.DateTimePicker toolEndDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox toolOwner;
        private System.Windows.Forms.ComboBox toolTypeComboBox;
        private System.Windows.Forms.ComboBox toolEndReason;
        private System.Windows.Forms.CheckBox cbToolReturned;
    }
}