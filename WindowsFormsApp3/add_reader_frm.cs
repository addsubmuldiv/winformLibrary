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
    public partial class add_reader_frm : DevComponents.DotNetBar.OfficeForm
    {
        private SqlConnection sqlcon;
        private static add_reader_frm uniqueInstance;
        private add_reader_frm()
        {
            InitializeComponent();
            getSqlConnection getcon = new getSqlConnection();
            sqlcon = getcon.GetCon();
            read_reader_from_database();
        }

        public void read_reader_from_database()
        {
            listView1.Items.Clear();
            SqlCommand sqlcom = sqlcon.CreateCommand();
            sqlcom.CommandText = $"select * from reader";
            SqlDataReader sqlreader = sqlcom.ExecuteReader();
            listView1.BeginUpdate();
            while(sqlreader.Read())
            {
                ListViewItem lv = new ListViewItem(sqlreader[0].ToString());
                lv.SubItems.Add(sqlreader[1].ToString());
                lv.SubItems.Add(sqlreader[2].ToString());
                lv.SubItems.Add(Convert.ToDateTime(sqlreader[3]).ToShortDateString());
                lv.SubItems.Add(sqlreader[4].ToString());
                lv.SubItems.Add(sqlreader[5].ToString());
                listView1.Items.Add(lv);
            }
            sqlreader.Close();
            listView1.EndUpdate();
        }

        public static add_reader_frm getInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new add_reader_frm();
            return uniqueInstance;
        }

        private void add_reader_Click(object sender, EventArgs e)
        {
            MessageBoxEx.EnableGlass = false;
            SqlCommand sqlcom = sqlcon.CreateCommand();

            sqlcom.CommandText = $"select count(*) from reader where readerId='{readerid_box.Text}'";
            object i = sqlcom.ExecuteScalar();
            if (Convert.ToInt32(i)==1)
            {
                MessageBoxEx.Show("此用户ID已经存在！");
                return;
            }
            sqlcom.CommandText = $"insert into reader values('{readerid_box.Text}','{password_box.Text}','{phone_box.Text}','{dateTime_box.Value.ToShortDateString()}','{id_kind_box.Text}','{id_number_box.Text}')";
            int flag = sqlcom.ExecuteNonQuery();
            if(flag==1)
            {
                MessageBoxEx.Show("添加成功！");
            }
            else
            {
                MessageBoxEx.Show("添加失败！");
            }
            read_reader_from_database();
        }

        private void phone_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex_int.IsInt(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (this.listView1.Columns[e.Column].Tag == null)
                this.listView1.Columns[e.Column].Tag = true;
            bool flag = (bool)this.listView1.Columns[e.Column].Tag;
            if (flag)
                this.listView1.Columns[e.Column].Tag = false;
            else
                this.listView1.Columns[e.Column].Tag = true;
            this.listView1.ListViewItemSorter = new ListViewSort(e.Column, this.listView1.Columns[e.Column].Tag);
            this.listView1.Sort();//对列表进行自定义排序  
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem a;
            if(listView1.SelectedItems.Count!=0)
            {
                a = listView1.SelectedItems[0];
                readerid_box.Text = a.Text;
                password_box.Text = a.SubItems[1].Text;
                phone_box.Text = a.SubItems[2].Text;
                dateTime_box.Value = DateTime.Parse(a.SubItems[3].Text);
                id_kind_box.Text = a.SubItems[4].Text;
                id_number_box.Text = a.SubItems[5].Text;
            }
        }
    }
}