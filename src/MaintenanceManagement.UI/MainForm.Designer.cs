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
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.zleceniaWarsztatoweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.harmonogramUrlopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeExample = new System.Windows.Forms.Button();
            this.kontrollingButton = new System.Windows.Forms.Button();
            this.wtryskarkiButton = new System.Windows.Forms.Button();
            this.pakujaceButton = new System.Windows.Forms.Button();
            this.ekstruderButton = new System.Windows.Forms.Button();
            this.automatyButton = new System.Windows.Forms.Button();
            this.facilityButton = new System.Windows.Forms.Button();
            this.brygadaAButton = new System.Windows.Forms.Button();
            this.brygadaBButton = new System.Windows.Forms.Button();
            this.brygadaCButton = new System.Windows.Forms.Button();
            this.brygadaDButton = new System.Windows.Forms.Button();
            this.warsztatButton = new System.Windows.Forms.Button();
            this.infrastrukturaButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
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
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamknijToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
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
            this.pracownicyToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.pracownicyToolStripMenuItem.Text = "Pracownicy";
            this.pracownicyToolStripMenuItem.Click += new System.EventHandler(this.pracownicyToolStripMenuItem_Click);
            // 
            // narzedziaToolStripMenuItem
            // 
            this.narzedziaToolStripMenuItem.Name = "narzedziaToolStripMenuItem";
            this.narzedziaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.narzedziaToolStripMenuItem.Text = "Narzędzia";
            this.narzedziaToolStripMenuItem.Click += new System.EventHandler(this.narzToolStripMenuItem_Click);
            // 
            // obszaryToolStripMenuItem
            // 
            this.obszaryToolStripMenuItem.Name = "obszaryToolStripMenuItem";
            this.obszaryToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.obszaryToolStripMenuItem.Text = "Obszary";
            this.obszaryToolStripMenuItem.Click += new System.EventHandler(this.obszaryToolStripMenuItem_Click);
            // 
            // zleceniaWarsztatoweToolStripMenuItem
            // 
            this.zleceniaWarsztatoweToolStripMenuItem.Name = "zleceniaWarsztatoweToolStripMenuItem";
            this.zleceniaWarsztatoweToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.zleceniaWarsztatoweToolStripMenuItem.Text = "Zlecenia warsztatowe";
            this.zleceniaWarsztatoweToolStripMenuItem.Visible = false;
            // 
            // harmonogramUrlopyToolStripMenuItem
            // 
            this.harmonogramUrlopyToolStripMenuItem.Name = "harmonogramUrlopyToolStripMenuItem";
            this.harmonogramUrlopyToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.harmonogramUrlopyToolStripMenuItem.Text = "Harmonogram/Urlopy";
            this.harmonogramUrlopyToolStripMenuItem.Visible = false;
            // 
            // employeeExample
            // 
            this.employeeExample.Location = new System.Drawing.Point(744, 450);
            this.employeeExample.Name = "employeeExample";
            this.employeeExample.Size = new System.Drawing.Size(78, 50);
            this.employeeExample.TabIndex = 17;
            this.employeeExample.Text = "Przykładowy pracownik";
            this.employeeExample.UseVisualStyleBackColor = true;
            this.employeeExample.Click += new System.EventHandler(this.employeeExample_Click);
            // 
            // kontrollingButton
            // 
            this.kontrollingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kontrollingButton.Location = new System.Drawing.Point(12, 150);
            this.kontrollingButton.Name = "kontrollingButton";
            this.kontrollingButton.Size = new System.Drawing.Size(96, 49);
            this.kontrollingButton.TabIndex = 18;
            this.kontrollingButton.Text = "Kontrolling";
            this.kontrollingButton.UseVisualStyleBackColor = true;
            this.kontrollingButton.Click += new System.EventHandler(this.controllingButton_Click);
            // 
            // wtryskarkiButton
            // 
            this.wtryskarkiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wtryskarkiButton.Location = new System.Drawing.Point(150, 150);
            this.wtryskarkiButton.Name = "wtryskarkiButton";
            this.wtryskarkiButton.Size = new System.Drawing.Size(96, 49);
            this.wtryskarkiButton.TabIndex = 19;
            this.wtryskarkiButton.Text = "Wtryskarki";
            this.wtryskarkiButton.UseVisualStyleBackColor = true;
            this.wtryskarkiButton.Click += new System.EventHandler(this.wtryskarkiButton_Click);
            // 
            // pakujaceButton
            // 
            this.pakujaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pakujaceButton.Location = new System.Drawing.Point(288, 150);
            this.pakujaceButton.Name = "pakujaceButton";
            this.pakujaceButton.Size = new System.Drawing.Size(96, 49);
            this.pakujaceButton.TabIndex = 20;
            this.pakujaceButton.Text = "Maszyny pakujące";
            this.pakujaceButton.UseVisualStyleBackColor = true;
            this.pakujaceButton.Click += new System.EventHandler(this.pakujaceButton_Click);
            // 
            // ekstruderButton
            // 
            this.ekstruderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ekstruderButton.Location = new System.Drawing.Point(426, 150);
            this.ekstruderButton.Name = "ekstruderButton";
            this.ekstruderButton.Size = new System.Drawing.Size(96, 49);
            this.ekstruderButton.TabIndex = 21;
            this.ekstruderButton.Text = "Ekstruder";
            this.ekstruderButton.UseVisualStyleBackColor = true;
            this.ekstruderButton.Click += new System.EventHandler(this.ekstruderButton_Click);
            // 
            // automatyButton
            // 
            this.automatyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.automatyButton.Location = new System.Drawing.Point(564, 150);
            this.automatyButton.Name = "automatyButton";
            this.automatyButton.Size = new System.Drawing.Size(96, 49);
            this.automatyButton.TabIndex = 22;
            this.automatyButton.Text = "Automaty";
            this.automatyButton.UseVisualStyleBackColor = true;
            this.automatyButton.Click += new System.EventHandler(this.automatyButton_Click);
            // 
            // facilityButton
            // 
            this.facilityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.facilityButton.Location = new System.Drawing.Point(702, 150);
            this.facilityButton.Name = "facilityButton";
            this.facilityButton.Size = new System.Drawing.Size(96, 49);
            this.facilityButton.TabIndex = 23;
            this.facilityButton.Text = "Facility";
            this.facilityButton.UseVisualStyleBackColor = true;
            this.facilityButton.Click += new System.EventHandler(this.facilityButton_Click);
            // 
            // brygadaAButton
            // 
            this.brygadaAButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.brygadaAButton.Location = new System.Drawing.Point(12, 244);
            this.brygadaAButton.Name = "brygadaAButton";
            this.brygadaAButton.Size = new System.Drawing.Size(96, 49);
            this.brygadaAButton.TabIndex = 24;
            this.brygadaAButton.Text = "Brygada A";
            this.brygadaAButton.UseVisualStyleBackColor = true;
            this.brygadaAButton.Click += new System.EventHandler(this.brygadaAButton_Click);
            // 
            // brygadaBButton
            // 
            this.brygadaBButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.brygadaBButton.Location = new System.Drawing.Point(150, 244);
            this.brygadaBButton.Name = "brygadaBButton";
            this.brygadaBButton.Size = new System.Drawing.Size(96, 49);
            this.brygadaBButton.TabIndex = 25;
            this.brygadaBButton.Text = "Brygada B";
            this.brygadaBButton.UseVisualStyleBackColor = true;
            this.brygadaBButton.Click += new System.EventHandler(this.brygadaBButton_Click);
            // 
            // brygadaCButton
            // 
            this.brygadaCButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.brygadaCButton.Location = new System.Drawing.Point(288, 244);
            this.brygadaCButton.Name = "brygadaCButton";
            this.brygadaCButton.Size = new System.Drawing.Size(96, 49);
            this.brygadaCButton.TabIndex = 26;
            this.brygadaCButton.Text = "Brygada C";
            this.brygadaCButton.UseVisualStyleBackColor = true;
            this.brygadaCButton.Click += new System.EventHandler(this.brygadaCButton_Click);
            // 
            // brygadaDButton
            // 
            this.brygadaDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.brygadaDButton.Location = new System.Drawing.Point(426, 244);
            this.brygadaDButton.Name = "brygadaDButton";
            this.brygadaDButton.Size = new System.Drawing.Size(96, 49);
            this.brygadaDButton.TabIndex = 27;
            this.brygadaDButton.Text = "Brygada D";
            this.brygadaDButton.UseVisualStyleBackColor = true;
            this.brygadaDButton.Click += new System.EventHandler(this.brygadaDButton_Click);
            // 
            // warsztatButton
            // 
            this.warsztatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.warsztatButton.Location = new System.Drawing.Point(564, 244);
            this.warsztatButton.Name = "warsztatButton";
            this.warsztatButton.Size = new System.Drawing.Size(96, 49);
            this.warsztatButton.TabIndex = 28;
            this.warsztatButton.Text = "Warsztat";
            this.warsztatButton.UseVisualStyleBackColor = true;
            this.warsztatButton.Click += new System.EventHandler(this.warsztatButton_Click);
            // 
            // infrastrukturaButton
            // 
            this.infrastrukturaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infrastrukturaButton.Location = new System.Drawing.Point(702, 244);
            this.infrastrukturaButton.Name = "infrastrukturaButton";
            this.infrastrukturaButton.Size = new System.Drawing.Size(96, 49);
            this.infrastrukturaButton.TabIndex = 29;
            this.infrastrukturaButton.Text = "Infrastruktura";
            this.infrastrukturaButton.UseVisualStyleBackColor = true;
            this.infrastrukturaButton.Click += new System.EventHandler(this.infrastrukturaButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(834, 512);
            this.Controls.Add(this.infrastrukturaButton);
            this.Controls.Add(this.warsztatButton);
            this.Controls.Add(this.brygadaDButton);
            this.Controls.Add(this.brygadaCButton);
            this.Controls.Add(this.brygadaBButton);
            this.Controls.Add(this.brygadaAButton);
            this.Controls.Add(this.facilityButton);
            this.Controls.Add(this.automatyButton);
            this.Controls.Add(this.ekstruderButton);
            this.Controls.Add(this.pakujaceButton);
            this.Controls.Add(this.wtryskarkiButton);
            this.Controls.Add(this.kontrollingButton);
            this.Controls.Add(this.employeeExample);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Maintenance management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.Button kontrollingButton;
        private System.Windows.Forms.Button wtryskarkiButton;
        private System.Windows.Forms.Button pakujaceButton;
        private System.Windows.Forms.Button ekstruderButton;
        private System.Windows.Forms.Button automatyButton;
        private System.Windows.Forms.Button facilityButton;
        private System.Windows.Forms.Button brygadaAButton;
        private System.Windows.Forms.Button brygadaBButton;
        private System.Windows.Forms.Button brygadaCButton;
        private System.Windows.Forms.Button brygadaDButton;
        private System.Windows.Forms.Button warsztatButton;
        private System.Windows.Forms.Button infrastrukturaButton;

    }
}

