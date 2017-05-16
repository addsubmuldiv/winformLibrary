namespace WindowsFormsApp3
{
    partial class delete_reader_frm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.delete_reader = new DevComponents.DotNetBar.ButtonX();
            this.search = new DevComponents.DotNetBar.ButtonX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.search_box = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(53, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(681, 352);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "账号";
            this.columnHeader1.Width = 88;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "密码";
            this.columnHeader2.Width = 99;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "电话";
            this.columnHeader3.Width = 117;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "注册日期";
            this.columnHeader4.Width = 112;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "证件类型";
            this.columnHeader5.Width = 89;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "证件号码";
            this.columnHeader6.Width = 172;
            // 
            // delete_reader
            // 
            this.delete_reader.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.delete_reader.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.delete_reader.Location = new System.Drawing.Point(314, 432);
            this.delete_reader.Name = "delete_reader";
            this.delete_reader.Size = new System.Drawing.Size(137, 38);
            this.delete_reader.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.delete_reader.TabIndex = 28;
            this.delete_reader.Text = "删除";
            this.delete_reader.Click += new System.EventHandler(this.delete_reader_Click);
            // 
            // search
            // 
            this.search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.search.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.search.Location = new System.Drawing.Point(456, 395);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.search.TabIndex = 69;
            this.search.Text = "搜索";
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(242, 399);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(90, 23);
            this.labelX11.TabIndex = 70;
            this.labelX11.Text = "搜索书名：";
            // 
            // search_box
            // 
            this.search_box.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.search_box.Border.Class = "TextBoxBorder";
            this.search_box.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.search_box.DisabledBackColor = System.Drawing.Color.White;
            this.search_box.ForeColor = System.Drawing.Color.Black;
            this.search_box.Location = new System.Drawing.Point(332, 397);
            this.search_box.Name = "search_box";
            this.search_box.PreventEnterBeep = true;
            this.search_box.Size = new System.Drawing.Size(100, 25);
            this.search_box.TabIndex = 68;
            // 
            // delete_reader_frm
            // 
            this.ClientSize = new System.Drawing.Size(787, 495);
            this.Controls.Add(this.search);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.delete_reader);
            this.Controls.Add(this.listView1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "delete_reader_frm";
            this.Text = "delete_reader_frm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private DevComponents.DotNetBar.ButtonX delete_reader;
        private DevComponents.DotNetBar.ButtonX search;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.Controls.TextBoxX search_box;
    }
}