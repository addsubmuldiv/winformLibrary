namespace WindowsFormsApp3
{
    partial class change_password
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
            this.old_password = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.password_box1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.password_box2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.change_btn = new DevComponents.DotNetBar.ButtonX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(69, 49);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "旧密码：";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(69, 98);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "新密码：";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(69, 153);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(86, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "再次输入：";
            // 
            // old_password
            // 
            this.old_password.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.old_password.Border.Class = "TextBoxBorder";
            this.old_password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.old_password.DisabledBackColor = System.Drawing.Color.White;
            this.old_password.ForeColor = System.Drawing.Color.Black;
            this.old_password.Location = new System.Drawing.Point(151, 46);
            this.old_password.Name = "old_password";
            this.old_password.PasswordChar = '*';
            this.old_password.PreventEnterBeep = true;
            this.old_password.Size = new System.Drawing.Size(100, 25);
            this.old_password.TabIndex = 3;
            // 
            // password_box1
            // 
            this.password_box1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.password_box1.Border.Class = "TextBoxBorder";
            this.password_box1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.password_box1.DisabledBackColor = System.Drawing.Color.White;
            this.password_box1.ForeColor = System.Drawing.Color.Black;
            this.password_box1.Location = new System.Drawing.Point(151, 96);
            this.password_box1.Name = "password_box1";
            this.password_box1.PasswordChar = '*';
            this.password_box1.PreventEnterBeep = true;
            this.password_box1.Size = new System.Drawing.Size(100, 25);
            this.password_box1.TabIndex = 4;
            // 
            // password_box2
            // 
            this.password_box2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.password_box2.Border.Class = "TextBoxBorder";
            this.password_box2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.password_box2.DisabledBackColor = System.Drawing.Color.White;
            this.password_box2.ForeColor = System.Drawing.Color.Black;
            this.password_box2.Location = new System.Drawing.Point(151, 151);
            this.password_box2.Name = "password_box2";
            this.password_box2.PasswordChar = '*';
            this.password_box2.PreventEnterBeep = true;
            this.password_box2.Size = new System.Drawing.Size(100, 25);
            this.password_box2.TabIndex = 5;
            // 
            // change_btn
            // 
            this.change_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.change_btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.change_btn.Location = new System.Drawing.Point(105, 205);
            this.change_btn.Name = "change_btn";
            this.change_btn.Size = new System.Drawing.Size(103, 42);
            this.change_btn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.change_btn.TabIndex = 6;
            this.change_btn.Text = "更改";
            this.change_btn.Click += new System.EventHandler(this.change_btn_Click);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // change_password
            // 
            this.ClientSize = new System.Drawing.Size(317, 273);
            this.Controls.Add(this.change_btn);
            this.Controls.Add(this.password_box2);
            this.Controls.Add(this.password_box1);
            this.Controls.Add(this.old_password);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "change_password";
            this.Text = "change_password";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX old_password;
        private DevComponents.DotNetBar.Controls.TextBoxX password_box1;
        private DevComponents.DotNetBar.Controls.TextBoxX password_box2;
        private DevComponents.DotNetBar.ButtonX change_btn;
        private DevComponents.DotNetBar.StyleManager styleManager1;
    }
}