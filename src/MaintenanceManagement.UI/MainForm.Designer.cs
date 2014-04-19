namespace MaintenanceManagement.UI
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zadaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oczekujaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktualneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zrealizowaneToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bibliotekiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pracownicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maszynyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urlopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.harmonogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNew = new System.Windows.Forms.Button();
            this.toolTypeName = new System.Windows.Forms.TextBox();
            this.toolTypes = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(734, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 50);
            this.panel1.TabIndex = 14;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.zadaniaToolStripMenuItem,
            this.bibliotekiToolStripMenuItem,
            this.urlopyToolStripMenuItem,
            this.harmonogramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // zadaniaToolStripMenuItem
            // 
            this.zadaniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noweToolStripMenuItem,
            this.oczekujaceToolStripMenuItem,
            this.aktualneToolStripMenuItem,
            this.zrealizowaneToolStripMenuItem1});
            this.zadaniaToolStripMenuItem.Name = "zadaniaToolStripMenuItem";
            this.zadaniaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.zadaniaToolStripMenuItem.Text = "Zadania";
            // 
            // noweToolStripMenuItem
            // 
            this.noweToolStripMenuItem.Name = "noweToolStripMenuItem";
            this.noweToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.noweToolStripMenuItem.Text = "Nowe";
            // 
            // oczekujaceToolStripMenuItem
            // 
            this.oczekujaceToolStripMenuItem.Name = "oczekujaceToolStripMenuItem";
            this.oczekujaceToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.oczekujaceToolStripMenuItem.Text = "Oczekujące";
            // 
            // aktualneToolStripMenuItem
            // 
            this.aktualneToolStripMenuItem.Name = "aktualneToolStripMenuItem";
            this.aktualneToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.aktualneToolStripMenuItem.Text = "Aktualne";
            // 
            // zrealizowaneToolStripMenuItem1
            // 
            this.zrealizowaneToolStripMenuItem1.Name = "zrealizowaneToolStripMenuItem1";
            this.zrealizowaneToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.zrealizowaneToolStripMenuItem1.Text = "Zrealizowane";
            // 
            // bibliotekiToolStripMenuItem
            // 
            this.bibliotekiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pracownicyToolStripMenuItem,
            this.maszynyToolStripMenuItem});
            this.bibliotekiToolStripMenuItem.Name = "bibliotekiToolStripMenuItem";
            this.bibliotekiToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.bibliotekiToolStripMenuItem.Text = "Biblioteki";
            // 
            // pracownicyToolStripMenuItem
            // 
            this.pracownicyToolStripMenuItem.Name = "pracownicyToolStripMenuItem";
            this.pracownicyToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.pracownicyToolStripMenuItem.Text = "Pracownicy";
            // 
            // maszynyToolStripMenuItem
            // 
            this.maszynyToolStripMenuItem.Name = "maszynyToolStripMenuItem";
            this.maszynyToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.maszynyToolStripMenuItem.Text = "Maszyny";
            // 
            // urlopyToolStripMenuItem
            // 
            this.urlopyToolStripMenuItem.Name = "urlopyToolStripMenuItem";
            this.urlopyToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.urlopyToolStripMenuItem.Text = "Urlopy";
            // 
            // harmonogramToolStripMenuItem
            // 
            this.harmonogramToolStripMenuItem.Name = "harmonogramToolStripMenuItem";
            this.harmonogramToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.harmonogramToolStripMenuItem.Text = "Harmonogram";
            // 
            // addNew
            // 
            this.addNew.Location = new System.Drawing.Point(417, 140);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(75, 23);
            this.addNew.TabIndex = 17;
            this.addNew.Text = "Dodaj";
            this.addNew.UseVisualStyleBackColor = true;
            this.addNew.Click += new System.EventHandler(this.addNew_Click);
            // 
            // toolTypeName
            // 
            this.toolTypeName.Location = new System.Drawing.Point(218, 140);
            this.toolTypeName.Name = "toolTypeName";
            this.toolTypeName.Size = new System.Drawing.Size(193, 20);
            this.toolTypeName.TabIndex = 18;
            // 
            // toolTypes
            // 
            this.toolTypes.FormattingEnabled = true;
            this.toolTypes.Location = new System.Drawing.Point(218, 185);
            this.toolTypes.Name = "toolTypes";
            this.toolTypes.Size = new System.Drawing.Size(274, 238);
            this.toolTypes.TabIndex = 19;
            this.toolTypes.DoubleClick += new System.EventHandler(this.toolTypes_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Usuń";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(834, 512);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolTypes);
            this.Controls.Add(this.toolTypeName);
            this.Controls.Add(this.addNew);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Maintenance management";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zadaniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oczekujaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktualneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bibliotekiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noweToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zrealizowaneToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pracownicyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maszynyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urlopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem harmonogramToolStripMenuItem;
        private System.Windows.Forms.Button addNew;
        private System.Windows.Forms.TextBox toolTypeName;
        private System.Windows.Forms.ListBox toolTypes;
        private System.Windows.Forms.Button button1;
    }
}

