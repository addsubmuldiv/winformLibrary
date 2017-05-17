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
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("图书入库");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("删除图书");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("更新图书信息");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("图书管理", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("增加读者");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("删除读者");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("更新读者信息");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("读者管理", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("增加借阅信息");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("还书处理");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("借阅管理", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21});
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
            this.return_handle = new System.Windows.Forms.ToolStripMenuItem();
            this.选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.change_password_item = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.StatusBar = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem3 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem4 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem5 = new DevComponents.DotNetBar.LabelItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书管理ToolStripMenuItem,
            this.读者管理ToolStripMenuItem,
            this.我的图书馆ToolStripMenuItem,
            this.选项ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(972, 28);
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
            this.add_book.Size = new System.Drawing.Size(174, 26);
            this.add_book.Text = "图书入库";
            this.add_book.Click += new System.EventHandler(this.add_book_Click);
            // 
            // delete_book
            // 
            this.delete_book.Name = "delete_book";
            this.delete_book.Size = new System.Drawing.Size(174, 26);
            this.delete_book.Text = "删除图书";
            this.delete_book.Click += new System.EventHandler(this.delete_book_Click);
            // 
            // update_book
            // 
            this.update_book.Name = "update_book";
            this.update_book.Size = new System.Drawing.Size(174, 26);
            this.update_book.Text = "更新图书信息";
            this.update_book.Click += new System.EventHandler(this.update_book_Click);
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
            this.add_reader.Size = new System.Drawing.Size(174, 26);
            this.add_reader.Text = "增加读者";
            this.add_reader.Click += new System.EventHandler(this.add_reader_Click);
            // 
            // delete_reader
            // 
            this.delete_reader.Name = "delete_reader";
            this.delete_reader.Size = new System.Drawing.Size(174, 26);
            this.delete_reader.Text = "删除读者";
            this.delete_reader.Click += new System.EventHandler(this.delete_reader_Click);
            // 
            // update_reader
            // 
            this.update_reader.Name = "update_reader";
            this.update_reader.Size = new System.Drawing.Size(174, 26);
            this.update_reader.Text = "更新读者信息";
            this.update_reader.Click += new System.EventHandler(this.update_reader_Click);
            // 
            // 我的图书馆ToolStripMenuItem
            // 
            this.我的图书馆ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_borrow,
            this.return_handle});
            this.我的图书馆ToolStripMenuItem.Name = "我的图书馆ToolStripMenuItem";
            this.我的图书馆ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.我的图书馆ToolStripMenuItem.Text = "借阅管理";
            // 
            // add_borrow
            // 
            this.add_borrow.Name = "add_borrow";
            this.add_borrow.Size = new System.Drawing.Size(174, 26);
            this.add_borrow.Text = "增加借阅信息";
            this.add_borrow.Click += new System.EventHandler(this.add_borrow_Click);
            // 
            // return_handle
            // 
            this.return_handle.Name = "return_handle";
            this.return_handle.Size = new System.Drawing.Size(174, 26);
            this.return_handle.Text = "还书处理";
            this.return_handle.Click += new System.EventHandler(this.return_handle_Click);
            // 
            // 选项ToolStripMenuItem
            // 
            this.选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.change_password_item});
            this.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            this.选项ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.选项ToolStripMenuItem.Text = "选项";
            // 
            // change_password_item
            // 
            this.change_password_item.Name = "change_password_item";
            this.change_password_item.Size = new System.Drawing.Size(181, 26);
            this.change_password_item.Text = "更改密码";
            this.change_password_item.Click += new System.EventHandler(this.change_password_item_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton5,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton8});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(972, 27);
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
            this.toolStripButton1.Text = "图书入库";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "删除图书";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton5.Text = "更新图书信息";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "添加读者";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Text = "删除读者";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton6.Text = "更新读者信息";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton7.Text = "借书处理";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton8.Text = "还书处理";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
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
            this.StatusBar.Location = new System.Drawing.Point(0, 602);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(972, 22);
            this.StatusBar.TabIndex = 2;
            this.StatusBar.Text = "metroStatusBar1";
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
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode12.Name = "add_book";
            treeNode12.Text = "图书入库";
            treeNode13.Name = "delete_book";
            treeNode13.Text = "删除图书";
            treeNode14.Name = "update_book";
            treeNode14.Text = "更新图书信息";
            treeNode15.Name = "manage_book";
            treeNode15.Text = "图书管理";
            treeNode16.Name = "add_reader";
            treeNode16.Text = "增加读者";
            treeNode17.Name = "delete_reader";
            treeNode17.Text = "删除读者";
            treeNode18.Name = "update_reader";
            treeNode18.Text = "更新读者信息";
            treeNode19.Name = "manage_reader";
            treeNode19.Text = "读者管理";
            treeNode20.Name = "add_borrow";
            treeNode20.Text = "增加借阅信息";
            treeNode21.Name = "handle_return_item";
            treeNode21.Text = "还书处理";
            treeNode22.Name = "manage_borrow";
            treeNode22.Text = "借阅管理";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode19,
            treeNode22});
            this.treeView1.Size = new System.Drawing.Size(170, 538);
            this.treeView1.TabIndex = 3;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // panelEx1
            // 
            this.panelEx1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.treeView1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(0, 58);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(171, 538);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 5;
            this.panelEx1.Text = "panelEx1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(170, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 538);
            this.panel1.TabIndex = 9;
            // 
            // Main_form
            // 
            this.ClientSize = new System.Drawing.Size(972, 624);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main_form";
            this.Text = "管理窗口";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_form_FormClosing);
            this.Load += new System.EventHandler(this.Main_form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelEx1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem return_handle;
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
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem change_password_item;
    }
}