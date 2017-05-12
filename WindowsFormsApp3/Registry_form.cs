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
    public partial class Registry_form : DevComponents.DotNetBar.OfficeForm
    {
        SqlConnection sqlcon;
        private Login_Form login;
        public Registry_form()
        {
            InitializeComponent();
            login = Program.first;
            getSqlConnection getcon = new getSqlConnection();
            sqlcon=getcon.GetCon();
            toolTip1.SetToolTip(reg_id, "输入账号");
            toolTip1.SetToolTip(reg_password, "输入密码");
            toolTip1.SetToolTip(reg_password_again, "输入密码");
            toolTip1.SetToolTip(serial_reg_box, "输入序列号");
            toolTip1.SetToolTip(registry_button, "点击注册");
        }

        private void Registry_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.Enabled = true;
            login.Activate();
        }

        private void registry_button_Click(object sender, EventArgs e)
        {
            if (reg_id.Text.Length == 0 || reg_password.Text.Length == 0)
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("账号或密码不能为空！");
                return;
            }
            else if(reg_password.Text!=reg_password_again.Text)
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("请确保两次输入密码一致！");
                return;
            }
            else
            {
                SqlCommand sqlcom = sqlcon.CreateCommand();
                sqlcom.CommandText = $"select count(*) from library where serial = '{serial_reg_box.Text}'";
                if(Convert.ToInt32(sqlcom.ExecuteScalar())!=1)
                {
                    MessageBoxEx.EnableGlass = false;
                    MessageBoxEx.Show("请输入正确的序列号！");
                    return;
                }
                sqlcom.CommandText = $"select count(*) from manager where userid = '{reg_id.Text}'";
                object i = sqlcom.ExecuteScalar();
                if(1==Convert.ToInt32(i))
                {
                    MessageBoxEx.EnableGlass = false;
                    MessageBoxEx.Show("该账号已注册！请重试");
                    return;
                }
                sqlcom.CommandText = $"insert into manager values ('{reg_id.Text}','{reg_password.Text}')";
                if(1==sqlcom.ExecuteNonQuery())
                {
                    MessageBoxEx.EnableGlass = false;
                    MessageBoxEx.Show("注册成功！");
                    this.Close();
                    login.Enabled = true;
                    login.Activate();
                }
                else
                {
                    MessageBoxEx.EnableGlass = false;
                    MessageBoxEx.Show("注册失败！");
                }
            }
        }

        private void Registry_form_Activated(object sender, EventArgs e)
        {
            reg_id.Focus();
        }

        private void isManager_reg_CheckedChanged(object sender, EventArgs e)
        {
            if (manager_serial.Visible == false)
            {
                serial_reg_box.Visible = true;
                manager_serial.Visible = true;
            }
            else
            {
                serial_reg_box.Visible = false;
                manager_serial.Visible = false;
            }
        }
    }
}