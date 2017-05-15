namespace WindowsFormsApp3
{
    partial class add_reader_frm
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.readerid_box = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.password_box = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.phone_box = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.id_number_box = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.add_reader = new DevComponents.DotNetBar.ButtonX();
            this.dateTime_box = new System.Windows.Forms.DateTimePicker();
            this.id_kind_box = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(160, 278);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(87, 23);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "账号：";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(160, 323);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "密码：";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(160, 366);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 8;
            this.labelX3.Text = "电话：";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(414, 366);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(91, 23);
            this.labelX4.TabIndex = 9;
            this.labelX4.Text = "注册日期：";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(414, 278);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(91, 23);
            this.labelX5.TabIndex = 10;
            this.labelX5.Text = "证件类型：";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(414, 323);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(84, 23);
            this.labelX6.TabIndex = 11;
            this.labelX6.Text = "证件号码：";
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
            this.listView1.Size = new System.Drawing.Size(681, 227);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            // readerid_box
            // 
            this.readerid_box.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.readerid_box.Border.Class = "TextBoxBorder";
            this.readerid_box.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.readerid_box.DisabledBackColor = System.Drawing.Color.White;
            this.readerid_box.ForeColor = System.Drawing.Color.Black;
            this.readerid_box.Location = new System.Drawing.Point(207, 276);
            this.readerid_box.Name = "readerid_box";
            this.readerid_box.PreventEnterBeep = true;
            this.readerid_box.Size = new System.Drawing.Size(100, 25);
            this.readerid_box.TabIndex = 0;
            // 
            // password_box
            // 
            this.password_box.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.password_box.Border.Class = "TextBoxBorder";
            this.password_box.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.password_box.DisabledBackColor = System.Drawing.Color.White;
            this.password_box.ForeColor = System.Drawing.Color.Black;
            this.password_box.Location = new System.Drawing.Point(207, 321);
            this.password_box.Name = "password_box";
            this.password_box.PreventEnterBeep = true;
            this.password_box.Size = new System.Drawing.Size(100, 25);
            this.password_box.TabIndex = 1;
            // 
            // phone_box
            // 
            this.phone_box.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.phone_box.Border.Class = "TextBoxBorder";
            this.phone_box.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.phone_box.DisabledBackColor = System.Drawing.Color.White;
            this.phone_box.ForeColor = System.Drawing.Color.Black;
            this.phone_box.Location = new System.Drawing.Point(207, 364);
            this.phone_box.Name = "phone_box";
            this.phone_box.PreventEnterBeep = true;
            this.phone_box.Size = new System.Drawing.Size(100, 25);
            this.phone_box.TabIndex = 2;
            this.phone_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_box_KeyPress);
            // 
            // id_number_box
            // 
            this.id_number_box.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.id_number_box.Border.Class = "TextBoxBorder";
            this.id_number_box.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.id_number_box.DisabledBackColor = System.Drawing.Color.White;
            this.id_number_box.ForeColor = System.Drawing.Color.Black;
            this.id_number_box.Location = new System.Drawing.Point(486, 321);
            this.id_number_box.Name = "id_number_box";
            this.id_number_box.PreventEnterBeep = true;
            this.id_number_box.Size = new System.Drawing.Size(154, 25);
            this.id_number_box.TabIndex = 4;
            // 
            // add_reader
            // 
            this.add_reader.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.add_reader.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.add_reader.Location = new System.Drawing.Point(314, 432);
            this.add_reader.Name = "add_reader";
            this.add_reader.Size = new System.Drawing.Size(137, 38);
            this.add_reader.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.add_reader.TabIndex = 6;
            this.add_reader.Text = "添加";
            this.add_reader.Click += new System.EventHandler(this.add_reader_Click);
            // 
            // dateTime_box
            // 
            this.dateTime_box.Location = new System.Drawing.Point(486, 364);
            this.dateTime_box.Name = "dateTime_box";
            this.dateTime_box.Size = new System.Drawing.Size(200, 25);
            this.dateTime_box.TabIndex = 5;
            // 
            // id_kind_box
            // 
            this.id_kind_box.DisplayMember = "Text";
            this.id_kind_box.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.id_kind_box.ForeColor = System.Drawing.Color.Black;
            this.id_kind_box.FormattingEnabled = true;
            this.id_kind_box.ItemHeight = 19;
            this.id_kind_box.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.id_kind_box.Location = new System.Drawing.Point(486, 276);
            this.id_kind_box.Name = "id_kind_box";
            this.id_kind_box.Size = new System.Drawing.Size(121, 25);
            this.id_kind_box.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.id_kind_box.TabIndex = 3;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "学号";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "身份证";
            // 
            // add_reader_frm
            // 
            this.ClientSize = new System.Drawing.Size(787, 495);
            this.Controls.Add(this.id_kind_box);
            this.Controls.Add(this.dateTime_box);
            this.Controls.Add(this.add_reader);
            this.Controls.Add(this.id_number_box);
            this.Controls.Add(this.phone_box);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.readerid_box);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_reader_frm";
            this.Text = "add_reader_frm";
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private DevComponents.DotNetBar.Controls.TextBoxX readerid_box;
        private DevComponents.DotNetBar.Controls.TextBoxX password_box;
        private DevComponents.DotNetBar.Controls.TextBoxX phone_box;
        private DevComponents.DotNetBar.Controls.TextBoxX id_number_box;
        private DevComponents.DotNetBar.ButtonX add_reader;
        private System.Windows.Forms.DateTimePicker dateTime_box;
        private DevComponents.DotNetBar.Controls.ComboBoxEx id_kind_box;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
    }
}