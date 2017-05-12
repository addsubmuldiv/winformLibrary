namespace WindowsFormsApp3
{
    partial class reader_reg_form
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.reader_reg_button = new DevComponents.DotNetBar.ButtonX();
            this.readerId_box = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.readerpassword_box = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.phone_box = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.id_box = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.reader_password_again = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.id_kind_box = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.id_card = new DevComponents.Editors.ComboItem();
            this.stu_id = new DevComponents.Editors.ComboItem();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(62, 55);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "账号：";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(62, 111);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "密码：";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(299, 55);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "电话：";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(33, 173);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(90, 23);
            this.labelX5.TabIndex = 5;
            this.labelX5.Text = "证件类型：";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(269, 173);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(90, 23);
            this.labelX6.TabIndex = 6;
            this.labelX6.Text = "证件号码：";
            // 
            // reader_reg_button
            // 
            this.reader_reg_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.reader_reg_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.reader_reg_button.Location = new System.Drawing.Point(231, 259);
            this.reader_reg_button.Name = "reader_reg_button";
            this.reader_reg_button.Size = new System.Drawing.Size(102, 33);
            this.reader_reg_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.reader_reg_button.TabIndex = 6;
            this.reader_reg_button.Text = "注册";
            this.reader_reg_button.Click += new System.EventHandler(this.reader_reg_button_Click);
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
            this.readerId_box.Location = new System.Drawing.Point(107, 53);
            this.readerId_box.Name = "readerId_box";
            this.readerId_box.PreventEnterBeep = true;
            this.readerId_box.Size = new System.Drawing.Size(147, 25);
            this.readerId_box.TabIndex = 0;
            // 
            // readerpassword_box
            // 
            this.readerpassword_box.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.readerpassword_box.Border.Class = "TextBoxBorder";
            this.readerpassword_box.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.readerpassword_box.DisabledBackColor = System.Drawing.Color.White;
            this.readerpassword_box.ForeColor = System.Drawing.Color.Black;
            this.readerpassword_box.Location = new System.Drawing.Point(107, 109);
            this.readerpassword_box.Name = "readerpassword_box";
            this.readerpassword_box.PasswordChar = '*';
            this.readerpassword_box.PreventEnterBeep = true;
            this.readerpassword_box.Size = new System.Drawing.Size(147, 25);
            this.readerpassword_box.TabIndex = 2;
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
            this.phone_box.Location = new System.Drawing.Point(346, 53);
            this.phone_box.Name = "phone_box";
            this.phone_box.PreventEnterBeep = true;
            this.phone_box.Size = new System.Drawing.Size(147, 25);
            this.phone_box.TabIndex = 1;
            // 
            // id_box
            // 
            this.id_box.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.id_box.Border.Class = "TextBoxBorder";
            this.id_box.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.id_box.DisabledBackColor = System.Drawing.Color.White;
            this.id_box.ForeColor = System.Drawing.Color.Black;
            this.id_box.Location = new System.Drawing.Point(343, 173);
            this.id_box.Name = "id_box";
            this.id_box.PreventEnterBeep = true;
            this.id_box.Size = new System.Drawing.Size(149, 25);
            this.id_box.TabIndex = 5;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // reader_password_again
            // 
            this.reader_password_again.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.reader_password_again.Border.Class = "TextBoxBorder";
            this.reader_password_again.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reader_password_again.DisabledBackColor = System.Drawing.Color.White;
            this.reader_password_again.ForeColor = System.Drawing.Color.Black;
            this.reader_password_again.Location = new System.Drawing.Point(346, 109);
            this.reader_password_again.Name = "reader_password_again";
            this.reader_password_again.PasswordChar = '*';
            this.reader_password_again.PreventEnterBeep = true;
            this.reader_password_again.Size = new System.Drawing.Size(147, 25);
            this.reader_password_again.TabIndex = 3;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(269, 111);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(223, 23);
            this.labelX4.TabIndex = 13;
            this.labelX4.Text = "确认密码：";
            // 
            // id_kind_box
            // 
            this.id_kind_box.DisplayMember = "Text";
            this.id_kind_box.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.id_kind_box.ForeColor = System.Drawing.Color.Black;
            this.id_kind_box.FormattingEnabled = true;
            this.id_kind_box.ItemHeight = 19;
            this.id_kind_box.Items.AddRange(new object[] {
            this.id_card,
            this.stu_id});
            this.id_kind_box.Location = new System.Drawing.Point(107, 173);
            this.id_kind_box.Name = "id_kind_box";
            this.id_kind_box.Size = new System.Drawing.Size(147, 25);
            this.id_kind_box.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.id_kind_box.TabIndex = 14;
            // 
            // id_card
            // 
            this.id_card.Text = "身份证";
            // 
            // stu_id
            // 
            this.stu_id.Text = "学号";
            // 
            // reader_reg_form
            // 
            this.ClientSize = new System.Drawing.Size(573, 318);
            this.Controls.Add(this.id_kind_box);
            this.Controls.Add(this.reader_password_again);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.phone_box);
            this.Controls.Add(this.readerpassword_box);
            this.Controls.Add(this.readerId_box);
            this.Controls.Add(this.reader_reg_button);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "reader_reg_form";
            this.Text = "读者注册";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.reader_reg_form_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.ButtonX reader_reg_button;
        private DevComponents.DotNetBar.Controls.TextBoxX readerId_box;
        private DevComponents.DotNetBar.Controls.TextBoxX readerpassword_box;
        private DevComponents.DotNetBar.Controls.TextBoxX phone_box;
        private DevComponents.DotNetBar.Controls.TextBoxX id_box;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Controls.TextBoxX reader_password_again;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.ToolTip toolTip1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx id_kind_box;
        private DevComponents.Editors.ComboItem id_card;
        private DevComponents.Editors.ComboItem stu_id;
    }
}