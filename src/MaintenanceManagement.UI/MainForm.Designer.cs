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
            this.zaplanowaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktualneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zrealizowaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zestawienieZbiorczeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bibliotekiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pracownicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.narzedziaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obszaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeExample = new System.Windows.Forms.Button();
            this.zleceniaWarsztatoweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.harmonogramUrlopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(703, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 60);
            this.panel1.TabIndex = 14;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.zadaniaToolStripMenuItem,
            this.bibliotekiToolStripMenuItem,
            this.zleceniaWarsztatoweToolStripMenuItem,
            this.harmonogramUrlopyToolStripMenuItem});
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
            this.zaplanowaneToolStripMenuItem,
            this.aktualneToolStripMenuItem,
            this.zrealizowaneToolStripMenuItem,
            this.zestawienieZbiorczeToolStripMenuItem});
            this.zadaniaToolStripMenuItem.Name = "zadaniaToolStripMenuItem";
            this.zadaniaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.zadaniaToolStripMenuItem.Text = "Zadania";
            // 
            // noweToolStripMenuItem
            // 
            this.noweToolStripMenuItem.Name = "noweToolStripMenuItem";
            this.noweToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.noweToolStripMenuItem.Text = "Nowe";
            this.noweToolStripMenuItem.Click += new System.EventHandler(this.noweToolStripMenuItem_Click);
            // 
            // zaplanowaneToolStripMenuItem
            // 
            this.zaplanowaneToolStripMenuItem.Name = "zaplanowaneToolStripMenuItem";
            this.zaplanowaneToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.zaplanowaneToolStripMenuItem.Text = "Zaplanowane";
            this.zaplanowaneToolStripMenuItem.Click += new System.EventHandler(this.zaplanowaneToolStripMenuItem_Click);
            // 
            // aktualneToolStripMenuItem
            // 
            this.aktualneToolStripMenuItem.Name = "aktualneToolStripMenuItem";
            this.aktualneToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.aktualneToolStripMenuItem.Text = "Aktualne";
            this.aktualneToolStripMenuItem.Click += new System.EventHandler(this.aktualneToolStripMenuItem_Click);
            // 
            // zrealizowaneToolStripMenuItem
            // 
            this.zrealizowaneToolStripMenuItem.Name = "zrealizowaneToolStripMenuItem";
            this.zrealizowaneToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.zrealizowaneToolStripMenuItem.Text = "Zrealizowane";
            this.zrealizowaneToolStripMenuItem.Click += new System.EventHandler(this.zrealizowaneToolStripMenuItem_Click);
            // 
            // zestawienieZbiorczeToolStripMenuItem
            // 
            this.zestawienieZbiorczeToolStripMenuItem.Name = "zestawienieZbiorczeToolStripMenuItem";
            this.zestawienieZbiorczeToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.zestawienieZbiorczeToolStripMenuItem.Text = "Zestawienie zbiorcze";
            this.zestawienieZbiorczeToolStripMenuItem.Click += new System.EventHandler(this.zestawienieZbiorczeToolStripMenuItem_Click);
            // 
            // bibliotekiToolStripMenuItem
            // 
            this.bibliotekiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pracownicyToolStripMenuItem,
            this.narzedziaToolStripMenuItem,
            this.obszaryToolStripMenuItem});
            this.bibliotekiToolStripMenuItem.Name = "bibliotekiToolStripMenuItem";
            this.bibliotekiToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.bibliotekiToolStripMenuItem.Text = "Biblioteki";
            // 
            // pracownicyToolStripMenuItem
            // 
            this.pracownicyToolStripMenuItem.Name = "pracownicyToolStripMenuItem";
            this.pracownicyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pracownicyToolStripMenuItem.Text = "Pracownicy";
            this.pracownicyToolStripMenuItem.Click += new System.EventHandler(this.pracownicyToolStripMenuItem_Click);
            // 
            // narzedziaToolStripMenuItem
            // 
            this.narzedziaToolStripMenuItem.Name = "narzedziaToolStripMenuItem";
            this.narzedziaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.narzedziaToolStripMenuItem.Text = "Narzędzia";
            this.narzedziaToolStripMenuItem.Click += new System.EventHandler(this.narzToolStripMenuItem_Click);
            // 
            // obszaryToolStripMenuItem
            // 
            this.obszaryToolStripMenuItem.Name = "obszaryToolStripMenuItem";
            this.obszaryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.obszaryToolStripMenuItem.Text = "Obszary";
            this.obszaryToolStripMenuItem.Click += new System.EventHandler(this.obszaryToolStripMenuItem_Click);
            // 
            // employeeExample
            // 
            this.employeeExample.Location = new System.Drawing.Point(25, 68);
            this.employeeExample.Name = "employeeExample";
            this.employeeExample.Size = new System.Drawing.Size(78, 50);
            this.employeeExample.TabIndex = 17;
            this.employeeExample.Text = "Przykładowy pracownik";
            this.employeeExample.UseVisualStyleBackColor = true;
            this.employeeExample.Click += new System.EventHandler(this.employeeExample_Click);
            // 
            // zleceniaWarsztatoweToolStripMenuItem
            // 
            this.zleceniaWarsztatoweToolStripMenuItem.Name = "zleceniaWarsztatoweToolStripMenuItem";
            this.zleceniaWarsztatoweToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.zleceniaWarsztatoweToolStripMenuItem.Text = "Zlecenia warsztatowe";
            // 
            // harmonogramUrlopyToolStripMenuItem
            // 
            this.harmonogramUrlopyToolStripMenuItem.Name = "harmonogramUrlopyToolStripMenuItem";
            this.harmonogramUrlopyToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.harmonogramUrlopyToolStripMenuItem.Text = "Harmonogram/Urlopy";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(834, 512);
            this.Controls.Add(this.employeeExample);
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
        private System.Windows.Forms.ToolStripMenuItem zaplanowaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktualneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bibliotekiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noweToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zrealizowaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pracownicyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem narzedziaToolStripMenuItem;
        private System.Windows.Forms.Button employeeExample;

        private System.Windows.Forms.ToolStripMenuItem zestawienieZbiorczeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obszaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zleceniaWarsztatoweToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem harmonogramUrlopyToolStripMenuItem;

    }
}

