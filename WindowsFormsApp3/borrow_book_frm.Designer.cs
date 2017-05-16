namespace WindowsFormsApp3
{
    partial class borrow_book_frm
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.readerId_box = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.search_box = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.search_button = new DevComponents.DotNetBar.ButtonX();
            this.borrow_button = new DevComponents.DotNetBar.ButtonX();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.name = new DevComponents.Editors.ComboItem();
            this.author = new DevComponents.Editors.ComboItem();
            this.bookId = new DevComponents.Editors.ComboItem();
            this.kind = new DevComponents.Editors.ComboItem();
            this.SuspendLayout();
            // 
            // listViewEx1
            // 
            this.listViewEx1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewEx1.CheckBoxes = true;
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
            this.listViewEx1.Size = new System.Drawing.Size(681, 337);
            this.listViewEx1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewEx1.TabIndex = 1;
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
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(438, 416);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(86, 23);
            this.labelX1.TabIndex = 63;
            this.labelX1.Text = "读者账号：";
            // 
            // readerId_box
            // 
            this.readerId_box.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.readerId_box.Border.Class = "TextBoxBorder";
            this.readerId_box.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.readerId_box.DisabledBackColor = System.Drawing.Color.White;
            this.readerId_box.ForeColor = System.Drawing.Color.Black;
            this.readerId_box.Location = new System.Drawing.Point(514, 414);
            this.readerId_box.Name = "readerId_box";
            this.readerId_box.PreventEnterBeep = true;
            this.readerId_box.Size = new System.Drawing.Size(100, 25);
            this.readerId_box.TabIndex = 0;
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
            this.search_box.Location = new System.Drawing.Point(233, 414);
            this.search_box.Name = "search_box";
            this.search_box.PreventEnterBeep = true;
            this.search_box.Size = new System.Drawing.Size(100, 25);
            this.search_box.TabIndex = 2;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(184, 416);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(57, 23);
            this.labelX2.TabIndex = 65;
            this.labelX2.Text = "搜索：";
            // 
            // search_button
            // 
            this.search_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.search_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.search_button.Location = new System.Drawing.Point(340, 416);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 23);
            this.search_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.search_button.TabIndex = 3;
            this.search_button.Text = "搜索";
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // borrow_button
            // 
            this.borrow_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.borrow_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.borrow_button.Location = new System.Drawing.Point(620, 416);
            this.borrow_button.Name = "borrow_button";
            this.borrow_button.Size = new System.Drawing.Size(75, 23);
            this.borrow_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.borrow_button.TabIndex = 4;
            this.borrow_button.Text = "借阅";
            this.borrow_button.Click += new System.EventHandler(this.borrow_button_Click);
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEx1.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 20;
            this.comboBoxEx1.Items.AddRange(new object[] {
            this.name,
            this.author,
            this.bookId,
            this.kind});
            this.comboBoxEx1.Location = new System.Drawing.Point(117, 414);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(61, 26);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx1.TabIndex = 1;
            this.comboBoxEx1.SelectedIndex = 0;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(86, 416);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(25, 23);
            this.labelX3.TabIndex = 70;
            this.labelX3.Text = "按";
            // 
            // name
            // 
            this.name.Text = "书名";
            // 
            // author
            // 
            this.author.Text = "作者";
            // 
            // bookId
            // 
            this.bookId.Text = "书号";
            // 
            // kind
            // 
            this.kind.Text = "种类";
            // 
            // borrow_book_frm
            // 
            this.ClientSize = new System.Drawing.Size(787, 495);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.comboBoxEx1);
            this.Controls.Add(this.borrow_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.readerId_box);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.listViewEx1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "borrow_book_frm";
            this.Text = "borrow_book_frm";
            this.Activated += new System.EventHandler(this.borrow_book_frm_Activated);
            this.ResumeLayout(false);

        }
        
        #endregion

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
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX readerId_box;
        private DevComponents.DotNetBar.Controls.TextBoxX search_box;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX search_button;
        private DevComponents.DotNetBar.ButtonX borrow_button;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private DevComponents.Editors.ComboItem name;
        private DevComponents.Editors.ComboItem author;
        private DevComponents.Editors.ComboItem bookId;
        private DevComponents.Editors.ComboItem kind;
        private DevComponents.DotNetBar.LabelX labelX3;
    }
}