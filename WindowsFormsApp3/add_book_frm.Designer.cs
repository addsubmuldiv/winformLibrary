namespace WindowsFormsApp3
{
    partial class add_book_frm
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
            this.add_book = new DevComponents.DotNetBar.ButtonX();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.kind = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.literature = new DevComponents.Editors.ComboItem();
            this.computer = new DevComponents.Editors.ComboItem();
            this.novel = new DevComponents.Editors.ComboItem();
            this.education = new DevComponents.Editors.ComboItem();
            this.history = new DevComponents.Editors.ComboItem();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.number = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.price = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.publishing = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.author = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.bookid = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.bookname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
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
            this.listViewEx1.Size = new System.Drawing.Size(681, 227);
            this.listViewEx1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewEx1.TabIndex = 60;
            this.listViewEx1.UseCompatibleStateImageBehavior = false;
            this.listViewEx1.View = System.Windows.Forms.View.Details;
            this.listViewEx1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewEx1_ColumnClick);
            this.listViewEx1.SelectedIndexChanged += new System.EventHandler(this.listViewEx1_SelectedIndexChanged);
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
            // add_book
            // 
            this.add_book.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.add_book.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.add_book.Location = new System.Drawing.Point(314, 432);
            this.add_book.Name = "add_book";
            this.add_book.Size = new System.Drawing.Size(137, 38);
            this.add_book.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.add_book.TabIndex = 8;
            this.add_book.Text = "入库";
            this.add_book.Click += new System.EventHandler(this.add_book_Click);
            // 
            // datetime
            // 
            this.datetime.Location = new System.Drawing.Point(480, 361);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(200, 21);
            this.datetime.TabIndex = 7;
            // 
            // kind
            // 
            this.kind.AutoCompleteCustomSource.AddRange(new string[] {
            "文学",
            "社科",
            "小说",
            "教辅",
            "经管",
            "励志",
            "漫画",
            "历史",
            "哲学",
            "法律",
            "心理学",
            "计算机"});
            this.kind.DisplayMember = "Text";
            this.kind.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.kind.ForeColor = System.Drawing.Color.Black;
            this.kind.FormattingEnabled = true;
            this.kind.ItemHeight = 19;
            this.kind.Items.AddRange(new object[] {
            this.literature,
            this.computer,
            this.novel,
            this.education,
            this.history});
            this.kind.Location = new System.Drawing.Point(480, 330);
            this.kind.Name = "kind";
            this.kind.Size = new System.Drawing.Size(121, 25);
            this.kind.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.kind.TabIndex = 6;
            // 
            // literature
            // 
            this.literature.Text = "文学";
            // 
            // computer
            // 
            this.computer.Text = "计算机";
            // 
            // novel
            // 
            this.novel.Text = "小说";
            // 
            // education
            // 
            this.education.Text = "教辅";
            // 
            // history
            // 
            this.history.Text = "历史";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(586, 301);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(75, 23);
            this.labelX10.TabIndex = 56;
            this.labelX10.Text = "本";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(586, 270);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(75, 23);
            this.labelX9.TabIndex = 55;
            this.labelX9.Text = "元";
            // 
            // number
            // 
            this.number.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.number.Border.Class = "TextBoxBorder";
            this.number.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.number.DisabledBackColor = System.Drawing.Color.White;
            this.number.ForeColor = System.Drawing.Color.Black;
            this.number.Location = new System.Drawing.Point(480, 299);
            this.number.Name = "number";
            this.number.PreventEnterBeep = true;
            this.number.Size = new System.Drawing.Size(100, 21);
            this.number.TabIndex = 5;
            this.number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_KeyPress);
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.price.Border.Class = "TextBoxBorder";
            this.price.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.price.DisabledBackColor = System.Drawing.Color.White;
            this.price.ForeColor = System.Drawing.Color.Black;
            this.price.Location = new System.Drawing.Point(480, 268);
            this.price.Name = "price";
            this.price.PreventEnterBeep = true;
            this.price.Size = new System.Drawing.Size(100, 21);
            this.price.TabIndex = 4;
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            // 
            // publishing
            // 
            this.publishing.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.publishing.Border.Class = "TextBoxBorder";
            this.publishing.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.publishing.DisabledBackColor = System.Drawing.Color.White;
            this.publishing.ForeColor = System.Drawing.Color.Black;
            this.publishing.Location = new System.Drawing.Point(180, 361);
            this.publishing.Name = "publishing";
            this.publishing.PreventEnterBeep = true;
            this.publishing.Size = new System.Drawing.Size(100, 21);
            this.publishing.TabIndex = 3;
            // 
            // author
            // 
            this.author.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.author.Border.Class = "TextBoxBorder";
            this.author.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.author.DisabledBackColor = System.Drawing.Color.White;
            this.author.ForeColor = System.Drawing.Color.Black;
            this.author.Location = new System.Drawing.Point(180, 330);
            this.author.Name = "author";
            this.author.PreventEnterBeep = true;
            this.author.Size = new System.Drawing.Size(100, 21);
            this.author.TabIndex = 2;
            // 
            // bookid
            // 
            this.bookid.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.bookid.Border.Class = "TextBoxBorder";
            this.bookid.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.bookid.DisabledBackColor = System.Drawing.Color.White;
            this.bookid.ForeColor = System.Drawing.Color.Black;
            this.bookid.Location = new System.Drawing.Point(180, 299);
            this.bookid.Name = "bookid";
            this.bookid.PreventEnterBeep = true;
            this.bookid.Size = new System.Drawing.Size(100, 21);
            this.bookid.TabIndex = 1;
            this.bookid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bookid_KeyPress);
            // 
            // bookname
            // 
            this.bookname.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.bookname.Border.Class = "TextBoxBorder";
            this.bookname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.bookname.DisabledBackColor = System.Drawing.Color.White;
            this.bookname.ForeColor = System.Drawing.Color.Black;
            this.bookname.Location = new System.Drawing.Point(180, 268);
            this.bookname.Name = "bookname";
            this.bookname.PreventEnterBeep = true;
            this.bookname.Size = new System.Drawing.Size(100, 21);
            this.bookname.TabIndex = 0;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(116, 363);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(75, 23);
            this.labelX8.TabIndex = 48;
            this.labelX8.Text = "出版社：";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(402, 363);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(86, 23);
            this.labelX7.TabIndex = 47;
            this.labelX7.Text = "出版日期：";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(432, 332);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 46;
            this.labelX6.Text = "类别：";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(401, 301);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(86, 23);
            this.labelX5.TabIndex = 45;
            this.labelX5.Text = "库存数量：";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(431, 268);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 44;
            this.labelX4.Text = "价格：";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(93, 332);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(92, 23);
            this.labelX3.TabIndex = 43;
            this.labelX3.Text = "作者/译者：";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(131, 301);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 42;
            this.labelX2.Text = "书号：";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(131, 270);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 41;
            this.labelX1.Text = "书名：";
            // 
            // add_book_frm
            // 
            this.ClientSize = new System.Drawing.Size(787, 495);
            this.Controls.Add(this.listViewEx1);
            this.Controls.Add(this.add_book);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.kind);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.number);
            this.Controls.Add(this.price);
            this.Controls.Add(this.publishing);
            this.Controls.Add(this.author);
            this.Controls.Add(this.bookid);
            this.Controls.Add(this.bookname);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "add_book_frm";
            this.Text = "       ";
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
        private DevComponents.DotNetBar.ButtonX add_book;
        private System.Windows.Forms.DateTimePicker datetime;
        private DevComponents.DotNetBar.Controls.ComboBoxEx kind;
        private DevComponents.Editors.ComboItem literature;
        private DevComponents.Editors.ComboItem computer;
        private DevComponents.Editors.ComboItem novel;
        private DevComponents.Editors.ComboItem education;
        private DevComponents.Editors.ComboItem history;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX number;
        private DevComponents.DotNetBar.Controls.TextBoxX price;
        private DevComponents.DotNetBar.Controls.TextBoxX publishing;
        private DevComponents.DotNetBar.Controls.TextBoxX author;
        private DevComponents.DotNetBar.Controls.TextBoxX bookid;
        private DevComponents.DotNetBar.Controls.TextBoxX bookname;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}