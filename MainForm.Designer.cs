
namespace TestForGAZIT
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dgDivision = new System.Windows.Forms.DataGridView();
            this.dgUsers = new System.Windows.Forms.DataGridView();
            this.mStrip = new System.Windows.Forms.MenuStrip();
            this.miMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.miEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.miDelUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miRefs = new System.Windows.Forms.ToolStripMenuItem();
            this.miRefDivision = new System.Windows.Forms.ToolStripMenuItem();
            this.miRefPosts = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miStreets = new System.Windows.Forms.ToolStripMenuItem();
            this.miCities = new System.Windows.Forms.ToolStripMenuItem();
/*            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();*/
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.bdStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.sTools = new System.Windows.Forms.ToolStrip();
            this.AddButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.DelButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgDivision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
            this.mStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.sTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgDivision
            // 
            this.dgDivision.AllowUserToAddRows = false;
            this.dgDivision.AllowUserToDeleteRows = false;
            this.dgDivision.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dgDivision.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgDivision.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgDivision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDivision.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgDivision.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgDivision.Location = new System.Drawing.Point(5, 52);
            this.dgDivision.MultiSelect = false;
            this.dgDivision.Name = "dgDivision";
            this.dgDivision.ReadOnly = true;
            this.dgDivision.RowHeadersVisible = false;
            this.dgDivision.RowTemplate.Height = 25;
            this.dgDivision.RowTemplate.ReadOnly = true;
            this.dgDivision.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDivision.Size = new System.Drawing.Size(192, 383);
            this.dgDivision.TabIndex = 9;
            this.dgDivision.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDivision_CellClick);
            this.dgDivision.Click += new System.EventHandler(this.dgDivision_Click);
            // 
            // dgUsers
            // 
            this.dgUsers.AllowUserToAddRows = false;
            this.dgUsers.AllowUserToDeleteRows = false;
            this.dgUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dgUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgUsers.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgUsers.Location = new System.Drawing.Point(203, 52);
            this.dgUsers.MultiSelect = false;
            this.dgUsers.Name = "dgUsers";
            this.dgUsers.ReadOnly = true;
            this.dgUsers.RowHeadersVisible = false;
            this.dgUsers.RowTemplate.Height = 25;
            this.dgUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsers.Size = new System.Drawing.Size(591, 383);
            this.dgUsers.TabIndex = 6;
            this.dgUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsers_CellDoubleClick);
            // 
            // mStrip
            // 
            this.mStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMenu,
            this.miRefs});
            this.mStrip.Location = new System.Drawing.Point(0, 0);
            this.mStrip.Name = "mStrip";
            this.mStrip.Size = new System.Drawing.Size(800, 24);
            this.mStrip.TabIndex = 10;
            this.mStrip.Text = "Меню";
            // 
            // miMenu
            // 
            this.miMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddUser,
            this.miEditUser,
            this.miDelUser,
            this.toolStripSeparator2,
            this.miExit});
            this.miMenu.Name = "miMenu";
            this.miMenu.Size = new System.Drawing.Size(53, 20);
            this.miMenu.Text = "Меню";
            // 
            // miAddUser
            // 
            this.miAddUser.Name = "miAddUser";
            this.miAddUser.Size = new System.Drawing.Size(194, 22);
            this.miAddUser.Text = "Добавить сотрудника";
            this.miAddUser.Click += new System.EventHandler(this.AddtoolStripButton_Click);
            // 
            // miEditUser
            // 
            this.miEditUser.Name = "miEditUser";
            this.miEditUser.Size = new System.Drawing.Size(194, 22);
            this.miEditUser.Text = "Редактировать запись";
            this.miEditUser.Click += new System.EventHandler(this.EdittoolStripButton_Click);
            // 
            // miDelUser
            // 
            this.miDelUser.Name = "miDelUser";
            this.miDelUser.Size = new System.Drawing.Size(194, 22);
            this.miDelUser.Text = "Удалить запись";
            this.miDelUser.Click += new System.EventHandler(this.DeltoolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(191, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(194, 22);
            this.miExit.Text = "Выход";
            this.miExit.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // miRefs
            // 
            this.miRefs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRefDivision,
            this.miRefPosts,
            this.toolStripSeparator1,
            this.miStreets,
            this.miCities});
            this.miRefs.Name = "miRefs";
            this.miRefs.Size = new System.Drawing.Size(94, 20);
            this.miRefs.Text = "Справочники";
            // 
            // miRefDivision
            // 
            this.miRefDivision.Name = "miRefDivision";
            this.miRefDivision.Size = new System.Drawing.Size(159, 22);
            this.miRefDivision.Text = "Подразделения";
            this.miRefDivision.Click += new System.EventHandler(this.RefDivisions_Click);
            // 
            // miRefPosts
            // 
            this.miRefPosts.Name = "miRefPosts";
            this.miRefPosts.Size = new System.Drawing.Size(159, 22);
            this.miRefPosts.Text = "Должности";
            this.miRefPosts.Click += new System.EventHandler(this.RefPosts_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // miStreets
            // 
            this.miStreets.Name = "miStreets";
            this.miStreets.Size = new System.Drawing.Size(159, 22);
            this.miStreets.Text = "Города";
            this.miStreets.Click += new System.EventHandler(this.RefStreets_Click);
            // 
            // miCities
            // 
            this.miCities.Name = "miCities";
            this.miCities.Size = new System.Drawing.Size(159, 22);
            this.miCities.Text = "Улицы";
            this.miCities.Click += new System.EventHandler(this.RefCities_Click);
            // 
            // undoToolStripMenuItem
            // 
            /*
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            */
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bdStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 435);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // bdStatusLabel
            // 
            this.bdStatusLabel.Name = "bdStatusLabel";
            this.bdStatusLabel.Size = new System.Drawing.Size(65, 17);
            this.bdStatusLabel.Text = "Связь с БД";
            // 
            // sTools
            // 
            this.sTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddButton,
            this.EditButton,
            this.DelButton});
            this.sTools.Location = new System.Drawing.Point(0, 24);
            this.sTools.Name = "sTools";
            this.sTools.Size = new System.Drawing.Size(800, 25);
            this.sTools.TabIndex = 12;
            this.sTools.Text = "toolStrip1";
            // 
            // AddButton
            // 
            this.AddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(63, 22);
            this.AddButton.Text = "Добавить";
            this.AddButton.Click += new System.EventHandler(this.AddtoolStripButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(65, 22);
            this.EditButton.Text = "Изменить";
            this.EditButton.Click += new System.EventHandler(this.EdittoolStripButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DelButton.Image = ((System.Drawing.Image)(resources.GetObject("DelButton.Image")));
            this.DelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(55, 22);
            this.DelButton.Text = "Удалить";
            this.DelButton.Click += new System.EventHandler(this.DeltoolStripButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.sTools);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgDivision);
            this.Controls.Add(this.dgUsers);
            this.Controls.Add(this.mStrip);
            this.MainMenuStrip = this.mStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Персонал ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDivision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
            this.mStrip.ResumeLayout(false);
            this.mStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.sTools.ResumeLayout(false);
            this.sTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgUsers;
        private System.Windows.Forms.DataGridView dgDivision;
//        private System.Windows.Forms.MenuStrip menuStrip;
//        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem miExit;
/*        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;*/
        private System.Windows.Forms.ToolStripMenuItem miRefs;
/*        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem; */
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip sTools;
        private System.Windows.Forms.ToolStripStatusLabel bdStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem miStreets;
        private System.Windows.Forms.ToolStripMenuItem miCities;
        private System.Windows.Forms.ToolStripMenuItem miAddUser;
        private System.Windows.Forms.ToolStripMenuItem miEditUser;
        private System.Windows.Forms.ToolStripMenuItem miDelUser;
        private System.Windows.Forms.ToolStripButton AddButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton DelButton;
        private System.Windows.Forms.ToolStripMenuItem miMenu;
        private System.Windows.Forms.ToolStripMenuItem miRefDivision;
        private System.Windows.Forms.ToolStripMenuItem miRefPosts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.MenuStrip mStrip;
    }
}