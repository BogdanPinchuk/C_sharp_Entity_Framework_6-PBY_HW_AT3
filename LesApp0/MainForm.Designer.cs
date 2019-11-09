namespace LesApp0
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.createMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.split = new System.Windows.Forms.SplitContainer();
            this.groupCRUD = new System.Windows.Forms.GroupBox();
            this.bRefresh = new System.Windows.Forms.Button();
            this.cRead = new System.Windows.Forms.CheckBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bRead = new System.Windows.Forms.Button();
            this.bCreate = new System.Windows.Forms.Button();
            this.groupRow = new System.Windows.Forms.GroupBox();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.lCount = new System.Windows.Forms.Label();
            this.tbCategoty = new System.Windows.Forms.TextBox();
            this.lCategory = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.lNumber = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lID = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.openFileD = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileD = new System.Windows.Forms.SaveFileDialog();
            this.toolHelp = new System.Windows.Forms.ToolTip(this.components);
            this.menu.SuspendLayout();
            this.status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.split.Panel1.SuspendLayout();
            this.split.Panel2.SuspendLayout();
            this.split.SuspendLayout();
            this.groupCRUD.SuspendLayout();
            this.groupRow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(680, 28);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenu,
            this.createMenu,
            this.saveMenu,
            this.toolStripSeparator1,
            this.closeMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(46, 24);
            this.fileMenu.Text = "File";
            // 
            // openMenu
            // 
            this.openMenu.Name = "openMenu";
            this.openMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenu.Size = new System.Drawing.Size(200, 26);
            this.openMenu.Text = "Open";
            this.openMenu.Click += new System.EventHandler(this.OpenMenu_Click);
            // 
            // createMenu
            // 
            this.createMenu.Name = "createMenu";
            this.createMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createMenu.Size = new System.Drawing.Size(200, 26);
            this.createMenu.Text = "Create";
            this.createMenu.Click += new System.EventHandler(this.CreateMenu_Click);
            // 
            // saveMenu
            // 
            this.saveMenu.Enabled = false;
            this.saveMenu.Name = "saveMenu";
            this.saveMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenu.Size = new System.Drawing.Size(200, 26);
            this.saveMenu.Text = "Save as...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // closeMenu
            // 
            this.closeMenu.Name = "closeMenu";
            this.closeMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeMenu.Size = new System.Drawing.Size(200, 26);
            this.closeMenu.Text = "Close";
            this.closeMenu.Click += new System.EventHandler(this.CloseMenu_Click);
            // 
            // status
            // 
            this.status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.status.Location = new System.Drawing.Point(0, 339);
            this.status.Name = "status";
            this.status.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.status.Size = new System.Drawing.Size(680, 26);
            this.status.TabIndex = 1;
            this.status.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(35, 20);
            this.statusLabel.Text = "info";
            // 
            // split
            // 
            this.split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split.Location = new System.Drawing.Point(0, 28);
            this.split.Margin = new System.Windows.Forms.Padding(4);
            this.split.Name = "split";
            // 
            // split.Panel1
            // 
            this.split.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.split.Panel1.Controls.Add(this.groupCRUD);
            this.split.Panel1.Controls.Add(this.groupRow);
            // 
            // split.Panel2
            // 
            this.split.Panel2.Controls.Add(this.dataGrid);
            this.split.Size = new System.Drawing.Size(680, 311);
            this.split.SplitterDistance = 223;
            this.split.SplitterWidth = 5;
            this.split.TabIndex = 2;
            // 
            // groupCRUD
            // 
            this.groupCRUD.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupCRUD.Controls.Add(this.bRefresh);
            this.groupCRUD.Controls.Add(this.cRead);
            this.groupCRUD.Controls.Add(this.bAdd);
            this.groupCRUD.Controls.Add(this.bDelete);
            this.groupCRUD.Controls.Add(this.bUpdate);
            this.groupCRUD.Controls.Add(this.bRead);
            this.groupCRUD.Controls.Add(this.bCreate);
            this.groupCRUD.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupCRUD.Enabled = false;
            this.groupCRUD.Location = new System.Drawing.Point(0, 149);
            this.groupCRUD.Name = "groupCRUD";
            this.groupCRUD.Size = new System.Drawing.Size(223, 143);
            this.groupCRUD.TabIndex = 1;
            this.groupCRUD.TabStop = false;
            this.groupCRUD.Text = "CRUD";
            // 
            // bRefresh
            // 
            this.bRefresh.Location = new System.Drawing.Point(93, 79);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(75, 23);
            this.bRefresh.TabIndex = 6;
            this.bRefresh.Text = "Refresh";
            this.toolHelp.SetToolTip(this.bRefresh, "Update table");
            this.bRefresh.UseVisualStyleBackColor = true;
            // 
            // cRead
            // 
            this.cRead.AutoSize = true;
            this.cRead.Location = new System.Drawing.Point(93, 51);
            this.cRead.Name = "cRead";
            this.cRead.Size = new System.Drawing.Size(59, 21);
            this.cRead.TabIndex = 5;
            this.cRead.Text = "Auto";
            this.toolHelp.SetToolTip(this.cRead, "Auto-read");
            this.cRead.UseVisualStyleBackColor = true;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(93, 21);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 4;
            this.bAdd.Text = "Add";
            this.toolHelp.SetToolTip(this.bAdd, "Add row to database");
            this.bAdd.UseVisualStyleBackColor = true;
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(12, 108);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 3;
            this.bDelete.Text = "Delete";
            this.toolHelp.SetToolTip(this.bDelete, "Delete row");
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(12, 79);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 23);
            this.bUpdate.TabIndex = 2;
            this.bUpdate.Text = "Update";
            this.toolHelp.SetToolTip(this.bUpdate, "Update row and save in database");
            this.bUpdate.UseVisualStyleBackColor = true;
            // 
            // bRead
            // 
            this.bRead.Location = new System.Drawing.Point(12, 50);
            this.bRead.Name = "bRead";
            this.bRead.Size = new System.Drawing.Size(75, 23);
            this.bRead.TabIndex = 1;
            this.bRead.Text = "Read";
            this.toolHelp.SetToolTip(this.bRead, "Read of chosen row");
            this.bRead.UseVisualStyleBackColor = true;
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(12, 21);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(75, 23);
            this.bCreate.TabIndex = 0;
            this.bCreate.Text = "Create";
            this.toolHelp.SetToolTip(this.bCreate, "Do empty cells");
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.BCreate_Click);
            // 
            // groupRow
            // 
            this.groupRow.AutoSize = true;
            this.groupRow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupRow.Controls.Add(this.tbCount);
            this.groupRow.Controls.Add(this.lCount);
            this.groupRow.Controls.Add(this.tbCategoty);
            this.groupRow.Controls.Add(this.lCategory);
            this.groupRow.Controls.Add(this.tbNumber);
            this.groupRow.Controls.Add(this.lNumber);
            this.groupRow.Controls.Add(this.tbID);
            this.groupRow.Controls.Add(this.lID);
            this.groupRow.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupRow.Enabled = false;
            this.groupRow.Location = new System.Drawing.Point(0, 0);
            this.groupRow.Name = "groupRow";
            this.groupRow.Size = new System.Drawing.Size(223, 149);
            this.groupRow.TabIndex = 0;
            this.groupRow.TabStop = false;
            this.groupRow.Text = "Row of table";
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(78, 106);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(100, 22);
            this.tbCount.TabIndex = 7;
            this.tbCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolHelp.SetToolTip(this.tbCount, "Capacity of audience");
            // 
            // lCount
            // 
            this.lCount.AutoSize = true;
            this.lCount.Location = new System.Drawing.Point(7, 109);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(45, 17);
            this.lCount.TabIndex = 6;
            this.lCount.Text = "Count";
            // 
            // tbCategoty
            // 
            this.tbCategoty.Location = new System.Drawing.Point(78, 78);
            this.tbCategoty.Name = "tbCategoty";
            this.tbCategoty.Size = new System.Drawing.Size(100, 22);
            this.tbCategoty.TabIndex = 5;
            this.tbCategoty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolHelp.SetToolTip(this.tbCategoty, "Category of audience");
            // 
            // lCategory
            // 
            this.lCategory.AutoSize = true;
            this.lCategory.Location = new System.Drawing.Point(7, 81);
            this.lCategory.Name = "lCategory";
            this.lCategory.Size = new System.Drawing.Size(65, 17);
            this.lCategory.TabIndex = 4;
            this.lCategory.Text = "Category";
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(78, 50);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(100, 22);
            this.tbNumber.TabIndex = 3;
            this.tbNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolHelp.SetToolTip(this.tbNumber, "Number of audience");
            // 
            // lNumber
            // 
            this.lNumber.AutoSize = true;
            this.lNumber.Location = new System.Drawing.Point(7, 53);
            this.lNumber.Name = "lNumber";
            this.lNumber.Size = new System.Drawing.Size(58, 17);
            this.lNumber.TabIndex = 2;
            this.lNumber.Text = "Number";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(78, 22);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(100, 22);
            this.tbID.TabIndex = 1;
            this.tbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolHelp.SetToolTip(this.tbID, "Id");
            // 
            // lID
            // 
            this.lID.AutoSize = true;
            this.lID.Location = new System.Drawing.Point(7, 25);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(19, 17);
            this.lID.TabIndex = 0;
            this.lID.Text = "Id";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 0);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.Size = new System.Drawing.Size(452, 311);
            this.dataGrid.TabIndex = 0;
            // 
            // openFileD
            // 
            this.openFileD.FileName = "DataBase";
            this.openFileD.Filter = "DB Files *.mdf|*.mdf|All files|*.*";
            this.openFileD.Title = "Open DataBase File";
            // 
            // folderBrowser
            // 
            this.folderBrowser.Description = "Choose folder";
            // 
            // saveFileD
            // 
            this.saveFileD.FileName = "DataBase";
            this.saveFileD.Filter = "DB Files *.mdf|*.mdf|All files|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 365);
            this.Controls.Add(this.split);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "LesApp0";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.split.Panel1.ResumeLayout(false);
            this.split.Panel1.PerformLayout();
            this.split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
            this.split.ResumeLayout(false);
            this.groupCRUD.ResumeLayout(false);
            this.groupCRUD.PerformLayout();
            this.groupRow.ResumeLayout(false);
            this.groupRow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openMenu;
        private System.Windows.Forms.ToolStripMenuItem createMenu;
        private System.Windows.Forms.ToolStripMenuItem saveMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeMenu;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.SplitContainer split;
        private System.Windows.Forms.OpenFileDialog openFileD;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.SaveFileDialog saveFileD;
        private System.Windows.Forms.GroupBox groupRow;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.TextBox tbCategoty;
        private System.Windows.Forms.Label lCategory;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label lNumber;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.GroupBox groupCRUD;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bRead;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.CheckBox cRead;
        private System.Windows.Forms.ToolTip toolHelp;
        private System.Windows.Forms.Button bRefresh;
    }
}

