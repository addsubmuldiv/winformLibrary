using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.SqlClient;
namespace WindowsFormsApp3
{
    public partial class Login_Form : DevComponents.DotNetBar.OfficeForm
    {
        SqlConnection sqlcon;
        public static int count = 0;
        public Login_Form()
        {
            InitializeComponent();
            getSqlConnection getConnection = new getSqlConnection();
            try
            {
                sqlcon = getConnection.GetCon();
            }
            catch(Exception ex)
            {
                MessageBox.Show("连接数据库失败！");
            }
            toolTip1.SetToolTip(isManager, "需要以登录或注册为管理员身份，请勾选！");
            toolTip1.SetToolTip(userid_box, "输入账号");
            toolTip1.SetToolTip(userpassword_box, "输入密码");
            toolTip1.SetToolTip(Sign_in, "点击登录");
            toolTip1.SetToolTip(Sign_up, "点击注册");
        }

        private void Sign_in_Click(object sender, EventArgs e)
        {
            MessageBoxEx.EnableGlass = false;
            SqlCommand sqlcom = sqlcon.CreateCommand();
            if (userid_box.Text.Length == 0 || userpassword_box.Text.Length == 0)
            {
                MessageBoxEx.Show("账号或密码不能为空！");
                return;
            }
            if (isManager.Checked)
            {
                sqlcom.CommandText = $"select count(*) from manager where userid = '{userid_box.Text}' and userpassword = '{userpassword_box.Text}'";
            }
            else
            {
                sqlcom.CommandText= $"select count(*) from reader where readerId = '{userid_box.Text}' and readerPassword = '{userpassword_box.Text}'";
            }
            object i = sqlcom.ExecuteScalar();
            int flag = Convert.ToInt32(i);
            if (flag == 1)
            {
                MessageBoxEx.Show("登录成功！");
                this.Hide();
                if (isManager.Checked)
                {
                    Form mainfrm = new Main_form();
                    mainfrm.Show();
                }
            }
            else
            {
                MessageBoxEx.Show("登录失败！\n请检查账号和密码是否正确！");
                count++;
                if (count == 3)
                {
                    MessageBoxEx.Show("登录失败次数过多！\n系统自动退出！");
                    this.Close();
                }
            }
        }

        private void Sign_up_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Form RegForm;
            if (isManager.Checked)
                RegForm = new Registry_form();
            else
                RegForm = new reader_reg_form();
            RegForm.Show();
        }

        private void Login_Form_Activated(object sender, EventArgs e)
        {
            userid_box.Focus();
        }
    }
}