namespace WindowsFormsApp3
{
    partial class Registry_form
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
            this.reg_password_again = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.reg_password = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.reg_id = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.registry_button = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // reg_password_again
            // 
            // 
            // 
            // 
            this.reg_password_again.Border.Class = "TextBoxBorder";
            this.reg_password_again.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reg_password_again.Location = new System.Drawing.Point(125, 196);
            this.reg_password_again.Name = "reg_password_again";
            this.reg_password_again.PasswordChar = '*';
            this.reg_password_again.PreventEnterBeep = true;
            this.reg_password_again.Size = new System.Drawing.Size(177, 25);
            this.reg_password_again.TabIndex = 9;
            // 
            // reg_password
            // 
            // 
            // 
            // 
            this.reg_password.Border.Class = "TextBoxBorder";
            this.reg_password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reg_password.Location = new System.Drawing.Point(125, 138);
            this.reg_password.Name = "reg_password";
            this.reg_password.PasswordChar = '*';
            this.reg_password.PreventEnterBeep = true;
            this.reg_password.Size = new System.Drawing.Size(177, 25);
            this.reg_password.TabIndex = 8;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(51, 198);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(88, 23);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "»∑»œ√‹¬Î£∫";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(81, 140);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "√‹¬Î£∫";
            // 
            // reg_id
            // 
            // 
            // 
            // 
            this.reg_id.Border.Class = "TextBoxBorder";
            this.reg_id.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reg_id.Location = new System.Drawing.Point(125, 82);
            this.reg_id.Name = "reg_id";
            this.reg_id.PreventEnterBeep = true;
            this.reg_id.Size = new System.Drawing.Size(177, 25);
            this.reg_id.TabIndex = 12;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(81, 84);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 11;
            this.labelX4.Text = "’À∫≈£∫";
            // 
            // registry_button
            // 
            this.registry_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.registry_button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.registry_button.Location = new System.Drawing.Point(97, 263);
            this.registry_button.Name = "registry_button";
            this.registry_button.Size = new System.Drawing.Size(180, 70);
            this.registry_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.registry_button.TabIndex = 13;
            this.registry_button.Text = "◊¢≤·";
            this.registry_button.Click += new System.EventHandler(this.registry_button_Click);
            // 
            // Registry_form
            // 
            this.AcceptButton = this.registry_button;
            this.ClientSize = new System.Drawing.Size(382, 387);
            this.Controls.Add(this.registry_button);
            this.Controls.Add(this.reg_id);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.reg_password_again);
            this.Controls.Add(this.reg_password);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX3);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "Registry_form";
            this.Text = "◊¢≤·";
            this.Activated += new System.EventHandler(this.Registry_form_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registry_form_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.TextBoxX reg_password_again;
        private DevComponents.DotNetBar.Controls.TextBoxX reg_password;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX reg_id;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ButtonX registry_button;
    }
}