namespace WindowsFormsApp3
{
    partial class return_handle_frm
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
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.name = new DevComponents.Editors.ComboItem();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.search = new DevComponents.DotNetBar.ButtonX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.search_box = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.return_button = new DevComponents.DotNetBar.ButtonX();
            this.Excel_button = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
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
            this.listView1.Size = new System.Drawing.Size(681, 311);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "书号";
            this.columnHeader1.Width = 83;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "读者账号";
            this.columnHeader2.Width = 119;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "借阅日期";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "应归还日期";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "实际归还日期";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "是否归还";
            this.columnHeader6.Width = 95;
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(180, 399);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(25, 23);
            this.labelX12.TabIndex = 77;
            this.labelX12.Text = "按";
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
            this.comboItem1});
            this.comboBoxEx1.Location = new System.Drawing.Point(211, 395);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(61, 26);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx1.TabIndex = 76;
            // 
            // name
            // 
            this.name.Text = "书号";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "读者账号";
            // 
            // search
            // 
            this.search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.search.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.search.Location = new System.Drawing.Point(456, 395);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.search.TabIndex = 74;
            this.search.Text = "搜索";
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(278, 399);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(53, 23);
            this.labelX11.TabIndex = 75;
            this.labelX11.Text = "搜索：";
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
            this.search_box.TabIndex = 73;
            // 
            // return_button
            // 
            this.return_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.return_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.return_button.Location = new System.Drawing.Point(314, 432);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(137, 38);
            this.return_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.return_button.TabIndex = 78;
            this.return_button.Text = "归还";
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // Excel_button
            // 
            this.Excel_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Excel_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Excel_button.Location = new System.Drawing.Point(639, 348);
            this.Excel_button.Name = "Excel_button";
            this.Excel_button.Size = new System.Drawing.Size(95, 36);
            this.Excel_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Excel_button.TabIndex = 79;
            this.Excel_button.Text = "导出到Excel";
            this.Excel_button.Click += new System.EventHandler(this.Excel_button_Click);
            // 
            // return_handle_frm
            // 
            this.ClientSize = new System.Drawing.Size(787, 495);
            this.Controls.Add(this.Excel_button);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.labelX12);
            this.Controls.Add(this.comboBoxEx1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.listView1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "return_handle_frm";
            this.Text = "return_handle_frm";
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
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private DevComponents.Editors.ComboItem name;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.DotNetBar.ButtonX search;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.Controls.TextBoxX search_box;
        private DevComponents.DotNetBar.ButtonX return_button;
        private DevComponents.DotNetBar.ButtonX Excel_button;
    }
}