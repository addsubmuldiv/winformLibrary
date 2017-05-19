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
    public partial class change_password : DevComponents.DotNetBar.OfficeForm
   {
        private string userid;
        public string Userid
        {
            set { userid = value; }
            get { return userid; }
        }
      //  private static change_password uniqueInstance;
        public change_password()
        {
            InitializeComponent();
        }
    /*    public static change_password getInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new change_password();
            return uniqueInstance;
        }*/

        private void change_btn_Click(object sender, EventArgs e)
        {
            getSqlConnection getcon=new getSqlConnection();
            SqlConnection sqlcon = getcon.GetCon();
            SqlCommand sqlcom = sqlcon.CreateCommand();
            MessageBoxEx.EnableGlass = false;
            if (
                password_box1.Text == "" ||
                old_password.Text == "" ||
                password_box2.Text == ""
                )
            {
                MessageBoxEx.Show("密码不能为空！");
                return;
            }


            if(password_box1.Text!=password_box2.Text)
            {
                MessageBoxEx.Show("两次密码输入不一致！");
                return;
            }

            sqlcom.CommandText = $"update manager set userpassword='{password_box1.Text}' where userid='{Userid}'";
            int flag=sqlcom.ExecuteNonQuery();
            if(flag==1)
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("更改成功！");
                this.Close();
            }
            
        }
    }
}