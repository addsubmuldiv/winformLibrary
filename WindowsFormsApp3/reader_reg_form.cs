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
    public partial class reader_reg_form : DevComponents.DotNetBar.OfficeForm
    {
        Form login;
        SqlConnection sqlcon;
        public reader_reg_form()
        {
            InitializeComponent();
            login = Program.first;
            getSqlConnection sql = new getSqlConnection();
            sqlcon = sql.GetCon();
            toolTip1.SetToolTip(readerId_box, "�����˺�");
            toolTip1.SetToolTip(readerpassword_box, "��������");
            toolTip1.SetToolTip(phone_box, "����绰����");
            toolTip1.SetToolTip(id_box, "����֤������");
            toolTip1.SetToolTip(id_kind_box, "ѡ��֤������");
            toolTip1.SetToolTip(reader_password_again, "��������");
            toolTip1.SetToolTip(reader_reg_button, "���ע��");

        }

        private void reader_reg_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.Enabled = true;
            login.Activate();
        }

        private void reader_reg_button_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(readerId_box.Text)||
                String.IsNullOrEmpty(readerpassword_box.Text)||
                String.IsNullOrEmpty(phone_box.Text)||
                String.IsNullOrEmpty(id_box.Text)||
                String.IsNullOrEmpty(id_kind_box.Text)||
                String.IsNullOrEmpty(reader_password_again.Text))
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("ע����Ϣ����Ϊ�գ�");
                return;
            }
            SqlCommand sqlcom = sqlcon.CreateCommand();
            sqlcom.CommandText = $"select count(*) from reader where readerId = '{readerId_box.Text}'";
            object i = sqlcom.ExecuteScalar();
            if (1 == Convert.ToInt32(i))
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("���˺���ע�ᣡ������");
                return;
            }
            if(!(readerpassword_box.Text==reader_password_again.Text))
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("��ȷ��������������һ�£�");
            }
            sqlcom.CommandText = $"insert into reader values('{readerId_box.Text}','{readerpassword_box.Text}','{phone_box.Text}','{DateTime.Today}','{id_kind_box.Text}','{id_box.Text}')";
            int flag = sqlcom.ExecuteNonQuery();
            if (flag == 1)
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("ע��ɹ���");
                this.Close();
                login.Activate();
            }
            else
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("ע��ʧ�ܣ������ԣ�");
            }
        }

        private void phone_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}