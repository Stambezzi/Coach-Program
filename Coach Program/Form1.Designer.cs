namespace Coach_Program
{
    partial class Form1
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
            this.menusPanel = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridClients = new System.Windows.Forms.DataGridView();
            this.rightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.update = new System.Windows.Forms.ToolStripMenuItem();
            this.mpK_Calendar = new MPK_Calendar.MPK_Calendar();
            this.searchBox = new Coach_Program.CueTextBox();
            this.menusPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).BeginInit();
            this.rightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menusPanel
            // 
            this.menusPanel.ColumnCount = 1;
            this.menusPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menusPanel.Controls.Add(this.menuStrip1, 0, 0);
            this.menusPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menusPanel.Location = new System.Drawing.Point(0, 0);
            this.menusPanel.Name = "menusPanel";
            this.menusPanel.RowCount = 1;
            this.menusPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.menusPanel.Size = new System.Drawing.Size(884, 25);
            this.menusPanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClientToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.addClientToolStripMenuItem.Text = "Add Client";
            this.addClientToolStripMenuItem.Click += new System.EventHandler(this.addClientToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // dataGridClients
            // 
            this.dataGridClients.Location = new System.Drawing.Point(12, 79);
            this.dataGridClients.Name = "dataGridClients";
            this.dataGridClients.Size = new System.Drawing.Size(362, 372);
            this.dataGridClients.TabIndex = 4;
            this.dataGridClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClients_CellClick);
            this.dataGridClients.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClients_CellValueChanged);
            this.dataGridClients.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewBinding);
            this.dataGridClients.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridClients_DataError);
            this.dataGridClients.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridClients_MouseClick);
            // 
            // rightClickMenu
            // 
            this.rightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delete,
            this.update});
            this.rightClickMenu.Name = "rightClickMenu";
            this.rightClickMenu.Size = new System.Drawing.Size(139, 48);
            this.rightClickMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.rightClickMenu_ItemClicked);
            // 
            // delete
            // 
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(138, 22);
            this.delete.Text = "Delete User";
            // 
            // update
            // 
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(138, 22);
            this.update.Text = "Update User";
            // 
            // mpK_Calendar
            // 
            this.mpK_Calendar.AbbreviateWeekDayHeader = true;
            this.mpK_Calendar.ActiveMonthColor = System.Drawing.Color.White;
            this.mpK_Calendar.ApptFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.mpK_Calendar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mpK_Calendar.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.mpK_Calendar.BoldedDateFontColor = System.Drawing.Color.Red;
            this.mpK_Calendar.BoldedDates = null;
            this.mpK_Calendar.DisplayWeekendsDarker = true;
            this.mpK_Calendar.GridColor = System.Drawing.Color.Black;
            this.mpK_Calendar.HeaderColor = System.Drawing.Color.LightSteelBlue;
            this.mpK_Calendar.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.mpK_Calendar.InactiveMonthColor = System.Drawing.Color.Silver;
            this.mpK_Calendar.intDay = 11;
            this.mpK_Calendar.intMonth = 12;
            this.mpK_Calendar.intYear = 2015;
            this.mpK_Calendar.Location = new System.Drawing.Point(380, 79);
            this.mpK_Calendar.Name = "mpK_Calendar";
            this.mpK_Calendar.NoApptFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mpK_Calendar.NonselectedDayFontColor = System.Drawing.Color.Black;
            this.mpK_Calendar.SelectedDate = new System.DateTime(2015, 12, 11, 4, 22, 31, 545);
            this.mpK_Calendar.SelectedDayColor = System.Drawing.Color.LightSteelBlue;
            this.mpK_Calendar.SelectedDayFontColor = System.Drawing.Color.White;
            this.mpK_Calendar.ShowCurrentMonthInDay = false;
            this.mpK_Calendar.ShowGrid = true;
            this.mpK_Calendar.ShowPrevNextButton = true;
            this.mpK_Calendar.Size = new System.Drawing.Size(492, 372);
            this.mpK_Calendar.TabIndex = 7;
            // 
            // searchBox
            // 
            this.searchBox.Cue = "Search";
            this.searchBox.Location = new System.Drawing.Point(12, 32);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(185, 20);
            this.searchBox.TabIndex = 6;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 506);
            this.Controls.Add(this.mpK_Calendar);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.dataGridClients);
            this.Controls.Add(this.menusPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menusPanel.ResumeLayout(false);
            this.menusPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).EndInit();
            this.rightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel menusPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridClients;
        private CueTextBox searchBox;
        private System.Windows.Forms.ContextMenuStrip rightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.ToolStripMenuItem update;
        private MPK_Calendar.MPK_Calendar mpK_Calendar;

    }
}

