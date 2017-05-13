namespace WindowsFormsApp3
{
    partial class Main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("图书入库");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("删除图书");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("更新图书信息");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("图书管理", new System.Windows.Forms.TreeNode[] {
            treeNode37,
            treeNode38,
            treeNode39});
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("增加读者");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("删除读者");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("更新读者信息");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("读者管理", new System.Windows.Forms.TreeNode[] {
            treeNode41,
            treeNode42,
            treeNode43});
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("增加借阅信息");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("更新借阅信息");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("还书处理");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("借阅管理", new System.Windows.Forms.TreeNode[] {
            treeNode45,
            treeNode46,
            treeNode47});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.图书管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_book = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_book = new System.Windows.Forms.ToolStripMenuItem();
            this.update_book = new System.Windows.Forms.ToolStripMenuItem();
            this.读者管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_reader = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_reader = new System.Windows.Forms.ToolStripMenuItem();
            this.update_reader = new System.Windows.Forms.ToolStripMenuItem();
            this.我的图书馆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_borrow = new System.Windows.Forms.ToolStripMenuItem();
            this.update_borrow = new System.Windows.Forms.ToolStripMenuItem();
            this.return_handle = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.StatusBar = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem3 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem4 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem5 = new DevComponents.DotNetBar.LabelItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书管理ToolStripMenuItem,
            this.读者管理ToolStripMenuItem,
            this.我的图书馆ToolStripMenuItem,
            this.about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 图书管理ToolStripMenuItem
            // 
            this.图书管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_book,
            this.delete_book,
            this.update_book});
            this.图书管理ToolStripMenuItem.Name = "图书管理ToolStripMenuItem";
            this.图书管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.图书管理ToolStripMenuItem.Text = "图书管理";
            // 
            // add_book
            // 
            this.add_book.Name = "add_book";
            this.add_book.Size = new System.Drawing.Size(181, 26);
            this.add_book.Text = "图书入库";
            // 
            // delete_book
            // 
            this.delete_book.Name = "delete_book";
            this.delete_book.Size = new System.Drawing.Size(181, 26);
            this.delete_book.Text = "删除图书";
            // 
            // update_book
            // 
            this.update_book.Name = "update_book";
            this.update_book.Size = new System.Drawing.Size(181, 26);
            this.update_book.Text = "更新图书信息";
            // 
            // 读者管理ToolStripMenuItem
            // 
            this.读者管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_reader,
            this.delete_reader,
            this.update_reader});
            this.读者管理ToolStripMenuItem.Name = "读者管理ToolStripMenuItem";
            this.读者管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.读者管理ToolStripMenuItem.Text = "读者管理";
            // 
            // add_reader
            // 
            this.add_reader.Name = "add_reader";
            this.add_reader.Size = new System.Drawing.Size(181, 26);
            this.add_reader.Text = "增加读者";
            // 
            // delete_reader
            // 
            this.delete_reader.Name = "delete_reader";
            this.delete_reader.Size = new System.Drawing.Size(181, 26);
            this.delete_reader.Text = "删除读者";
            // 
            // update_reader
            // 
            this.update_reader.Name = "update_reader";
            this.update_reader.Size = new System.Drawing.Size(181, 26);
            this.update_reader.Text = "更新读者信息";
            // 
            // 我的图书馆ToolStripMenuItem
            // 
            this.我的图书馆ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_borrow,
            this.update_borrow,
            this.return_handle});
            this.我的图书馆ToolStripMenuItem.Name = "我的图书馆ToolStripMenuItem";
            this.我的图书馆ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.我的图书馆ToolStripMenuItem.Text = "借阅管理";
            // 
            // add_borrow
            // 
            this.add_borrow.Name = "add_borrow";
            this.add_borrow.Size = new System.Drawing.Size(181, 26);
            this.add_borrow.Text = "增加借阅信息";
            // 
            // update_borrow
            // 
            this.update_borrow.Name = "update_borrow";
            this.update_borrow.Size = new System.Drawing.Size(181, 26);
            this.update_borrow.Text = "更新借阅信息";
            // 
            // return_handle
            // 
            this.return_handle.Name = "return_handle";
            this.return_handle.Size = new System.Drawing.Size(181, 26);
            this.return_handle.Text = "还书处理";
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(51, 24);
            this.about.Text = "关于";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(816, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // StatusBar
            // 
            // 
            // 
            // 
            this.StatusBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.StatusBar.ContainerControlProcessDialogKey = true;
            this.StatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatusBar.DragDropSupport = true;
            this.StatusBar.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1,
            this.labelItem2,
            this.labelItem3,
            this.labelItem4,
            this.labelItem5});
            this.StatusBar.Location = new System.Drawing.Point(0, 406);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(816, 22);
            this.StatusBar.TabIndex = 2;
            this.StatusBar.Text = "metroStatusBar1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 58);
            this.treeView1.Name = "treeView1";
            treeNode37.Name = "add_book";
            treeNode37.Text = "图书入库";
            treeNode38.Name = "delete_book";
            treeNode38.Text = "删除图书";
            treeNode39.Name = "update_book";
            treeNode39.Text = "更新图书信息";
            treeNode40.Name = "manage_book";
            treeNode40.Text = "图书管理";
            treeNode41.Name = "add_reader";
            treeNode41.Text = "增加读者";
            treeNode42.Name = "delete_book";
            treeNode42.Text = "删除读者";
            treeNode43.Name = "update_reader";
            treeNode43.Text = "更新读者信息";
            treeNode44.Name = "manage_reader";
            treeNode44.Text = "读者管理";
            treeNode45.Name = "add_borrow";
            treeNode45.Text = "增加借阅信息";
            treeNode46.Name = "update_borrow";
            treeNode46.Text = "更新借阅信息";
            treeNode47.Name = "handle_return_item";
            treeNode47.Text = "还书处理";
            treeNode48.Name = "manage_borrow";
            treeNode48.Text = "借阅管理";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode40,
            treeNode44,
            treeNode48});
            this.treeView1.Size = new System.Drawing.Size(170, 331);
            this.treeView1.TabIndex = 3;
            // 
            // labelItem1
            // 
            this.labelItem1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "Created by 郑宇航";
            // 
            // labelItem2
            // 
            this.labelItem2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = "15软件工程一班";
            // 
            // labelItem3
            // 
            this.labelItem3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelItem3.Name = "labelItem3";
            this.labelItem3.Text = "1515222030";
            // 
            // labelItem4
            // 
            this.labelItem4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelItem4.Name = "labelItem4";
            this.labelItem4.Text = "联系方式：15759213397";
            // 
            // labelItem5
            // 
            this.labelItem5.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelItem5.Name = "labelItem5";
            this.labelItem5.Text = "labelItem5";
            // 
            // Main_form
            // 
            this.ClientSize = new System.Drawing.Size(816, 428);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main_form";
            this.Text = "Main_form";
            this.Load += new System.EventHandler(this.Main_form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 图书管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_book;
        private System.Windows.Forms.ToolStripMenuItem delete_book;
        private System.Windows.Forms.ToolStripMenuItem update_book;
        private System.Windows.Forms.ToolStripMenuItem 读者管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_reader;
        private System.Windows.Forms.ToolStripMenuItem delete_reader;
        private System.Windows.Forms.ToolStripMenuItem update_reader;
        private System.Windows.Forms.ToolStripMenuItem 我的图书馆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_borrow;
        private System.Windows.Forms.ToolStripMenuItem update_borrow;
        private System.Windows.Forms.ToolStripMenuItem return_handle;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Metro.MetroStatusBar StatusBar;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.TreeView treeView1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.LabelItem labelItem3;
        private DevComponents.DotNetBar.LabelItem labelItem4;
        private DevComponents.DotNetBar.LabelItem labelItem5;
    }
}