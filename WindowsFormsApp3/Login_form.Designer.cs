namespace WindowsFormsApp3
{
    partial class Login_Form
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
            this.Sign_in = new DevComponents.DotNetBar.ButtonX();
            this.Sign_up = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.userid_box = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.userpassword_box = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.isManager = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Sign_in
            // 
            this.Sign_in.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Sign_in.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Sign_in.Location = new System.Drawing.Point(60, 283);
            this.Sign_in.Name = "Sign_in";
            this.Sign_in.Size = new System.Drawing.Size(100, 53);
            this.Sign_in.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Sign_in.TabIndex = 0;
            this.Sign_in.Text = "µÇÂ¼";
            this.Sign_in.Click += new System.EventHandler(this.Sign_in_Click);
            // 
            // Sign_up
            // 
            this.Sign_up.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Sign_up.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Sign_up.Location = new System.Drawing.Point(240, 283);
            this.Sign_up.Name = "Sign_up";
            this.Sign_up.Size = new System.Drawing.Size(100, 53);
            this.Sign_up.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Sign_up.TabIndex = 1;
            this.Sign_up.Text = "×¢²á";
            this.Sign_up.Click += new System.EventHandler(this.Sign_up_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(81, 96);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "ÕËºÅ£º";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(81, 159);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "ÃÜÂë£º";
            // 
            // userid_box
            // 
            this.userid_box.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.userid_box.Border.Class = "TextBoxBorder";
            this.userid_box.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.userid_box.DisabledBackColor = System.Drawing.Color.White;
            this.userid_box.ForeColor = System.Drawing.Color.Black;
            this.userid_box.Location = new System.Drawing.Point(125, 94);
            this.userid_box.Name = "userid_box";
            this.userid_box.PreventEnterBeep = true;
            this.userid_box.Size = new System.Drawing.Size(177, 25);
            this.userid_box.TabIndex = 4;
            // 
            // userpassword_box
            // 
            this.userpassword_box.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.userpassword_box.Border.Class = "TextBoxBorder";
            this.userpassword_box.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.userpassword_box.DisabledBackColor = System.Drawing.Color.White;
            this.userpassword_box.ForeColor = System.Drawing.Color.Black;
            this.userpassword_box.Location = new System.Drawing.Point(125, 157);
            this.userpassword_box.Name = "userpassword_box";
            this.userpassword_box.PasswordChar = '*';
            this.userpassword_box.PreventEnterBeep = true;
            this.userpassword_box.Size = new System.Drawing.Size(177, 25);
            this.userpassword_box.TabIndex = 5;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // isManager
            // 
            this.isManager.AutoSize = true;
            this.isManager.Location = new System.Drawing.Point(246, 215);
            this.isManager.Name = "isManager";
            this.isManager.Size = new System.Drawing.Size(89, 19);
            this.isManager.TabIndex = 6;
            this.isManager.Text = "¹ÜÀíÔ±£¿";
            this.isManager.UseVisualStyleBackColor = true;
            // 
            // Login_Form
            // 
            this.AcceptButton = this.Sign_in;
            this.ClientSize = new System.Drawing.Size(382, 387);
            this.Controls.Add(this.isManager);
            this.Controls.Add(this.userpassword_box);
            this.Controls.Add(this.userid_box);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.Sign_up);
            this.Controls.Add(this.Sign_in);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login_Form";
            this.Text = "µÇÂ¼";
            this.Activated += new System.EventHandler(this.Login_Form_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX Sign_in;
        private DevComponents.DotNetBar.ButtonX Sign_up;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX userid_box;
        private DevComponents.DotNetBar.Controls.TextBoxX userpassword_box;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.CheckBox isManager;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}