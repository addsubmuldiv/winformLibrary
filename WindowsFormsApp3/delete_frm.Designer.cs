namespace WindowsFormsApp3
{
    partial class delete_frm
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
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.listViewEx1 = new System.Windows.Forms.ListView();
            this.col_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_publish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_kind = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_publishdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.delete_button = new DevComponents.DotNetBar.ButtonX();
            this.search = new DevComponents.DotNetBar.ButtonX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.search_box = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // listViewEx1
            // 
            this.listViewEx1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewEx1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_name,
            this.col_id,
            this.col_author,
            this.col_time,
            this.col_publish,
            this.col_price,
            this.col_number,
            this.col_kind,
            this.col_publishdate});
            this.listViewEx1.FullRowSelect = true;
            this.listViewEx1.GridLines = true;
            this.listViewEx1.LabelEdit = true;
            this.listViewEx1.Location = new System.Drawing.Point(53, 22);
            this.listViewEx1.Name = "listViewEx1";
            this.listViewEx1.Size = new System.Drawing.Size(681, 352);
            this.listViewEx1.TabIndex = 41;
            this.listViewEx1.UseCompatibleStateImageBehavior = false;
            this.listViewEx1.View = System.Windows.Forms.View.Details;
            this.listViewEx1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewEx1_ColumnClick);
            // 
            // col_name
            // 
            this.col_name.Text = "书名";
            this.col_name.Width = 62;
            // 
            // col_id
            // 
            this.col_id.Text = "书号";
            this.col_id.Width = 70;
            // 
            // col_author
            // 
            this.col_author.Text = "作者";
            this.col_author.Width = 71;
            // 
            // col_time
            // 
            this.col_time.Text = "借阅次数";
            this.col_time.Width = 95;
            // 
            // col_publish
            // 
            this.col_publish.Text = "出版社";
            this.col_publish.Width = 67;
            // 
            // col_price
            // 
            this.col_price.Text = "价格";
            this.col_price.Width = 65;
            // 
            // col_number
            // 
            this.col_number.Text = "数量";
            this.col_number.Width = 62;
            // 
            // col_kind
            // 
            this.col_kind.Text = "种类";
            this.col_kind.Width = 62;
            // 
            // col_publishdate
            // 
            this.col_publishdate.Text = "出版日期";
            this.col_publishdate.Width = 123;
            // 
            // delete_button
            // 
            this.delete_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.delete_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.delete_button.Location = new System.Drawing.Point(314, 432);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(137, 38);
            this.delete_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.delete_button.TabIndex = 2;
            this.delete_button.Text = "删除";
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // search
            // 
            this.search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.search.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.search.Location = new System.Drawing.Point(456, 395);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.search.TabIndex = 1;
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
            this.labelX11.TabIndex = 67;
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
            this.search_box.TabIndex = 0;
            // 
            // delete_frm
            // 
            this.ClientSize = new System.Drawing.Size(787, 495);
            this.Controls.Add(this.search);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.listViewEx1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "delete_frm";
            this.Text = "delete_frm";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.ListView listViewEx1;
        private System.Windows.Forms.ColumnHeader col_name;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_author;
        private System.Windows.Forms.ColumnHeader col_time;
        private System.Windows.Forms.ColumnHeader col_publish;
        private System.Windows.Forms.ColumnHeader col_price;
        private System.Windows.Forms.ColumnHeader col_number;
        private System.Windows.Forms.ColumnHeader col_kind;
        private System.Windows.Forms.ColumnHeader col_publishdate;
        private DevComponents.DotNetBar.ButtonX delete_button;
        private DevComponents.DotNetBar.ButtonX search;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.Controls.TextBoxX search_box;
    }
}