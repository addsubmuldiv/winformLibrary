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
                MessageBox.Show("�������ݿ�ʧ�ܣ�");
            }
        }

        private void Sign_in_Click(object sender, EventArgs e)
        {
            SqlCommand sqlcom = sqlcon.CreateCommand();
            if (userid_box.Text.Length == 0 || userpassword_box.Text.Length == 0)
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("�˺Ż����벻��Ϊ�գ�");
                return;
            }
            sqlcom.CommandText = $"select count(*) from manager where userid = '{userid_box.Text}' and userpassword = '{userpassword_box.Text}'";
            object i=sqlcom.ExecuteScalar();
            int flag = Convert.ToInt32(i);
            if (flag == 1)
            {
                MessageBox.Show("��¼�ɹ���");
            }
            else
            {
                MessageBox.Show("��¼ʧ�ܣ�\n�����˺ź������Ƿ���ȷ��");
            }
        }

        private void Sign_up_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Form RegForm = new Registry_form();
            RegForm.Show();
        }

        private void Login_Form_Activated(object sender, EventArgs e)
        {
            userid_box.Focus();
        }
    }
}