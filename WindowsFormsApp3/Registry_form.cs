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
        }

        private void Registry_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.login.Enabled = true;
        }

        private void registry_button_Click(object sender, EventArgs e)
        {
            if (reg_id.Text.Length == 0 || reg_password.Text.Length == 0)
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("�˺Ż����벻��Ϊ�գ�");
                return;
            }
            else if(reg_password.Text!=reg_password_again.Text)
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("��ȷ��������������һ�£�");
            }
            else
            {
                SqlCommand sqlcom = sqlcon.CreateCommand();
                sqlcom.CommandText = $"select count(*) from manager where userid = '{reg_id.Text}'";
                object i = sqlcom.ExecuteScalar();
                if(1==Convert.ToInt32(i))
                {
                    MessageBoxEx.EnableGlass = false;
                    MessageBoxEx.Show("���˺���ע�ᣡ������");
                    return;
                }
                sqlcom.CommandText = $"insert into manager values ('{reg_id.Text}','{reg_password.Text}')";
                if(1==sqlcom.ExecuteNonQuery())
                {
                    MessageBoxEx.EnableGlass = false;
                    MessageBoxEx.Show("ע��ɹ���");
                    this.Close();
                    login.Enabled = true;
                }
                else
                {
                    MessageBoxEx.EnableGlass = false;
                    MessageBoxEx.Show("ע��ʧ�ܣ�");
                }
            }
        }

        private void Registry_form_Activated(object sender, EventArgs e)
        {
            reg_id.Focus();
        }
    }
}