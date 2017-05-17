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
    public partial class update_reader_frm : DevComponents.DotNetBar.OfficeForm
    {
        SqlConnection sqlcon;
        private static update_reader_frm uniqueInstance;
        private update_reader_frm()
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
        public static update_reader_frm getInstance()
        {
            if(uniqueInstance==null)
            {
                uniqueInstance = new update_reader_frm();
            }
            return uniqueInstance;
        }

        private void update_reader_Click(object sender, EventArgs e)
        {
            MessageBoxEx.EnableGlass = false;
            SqlCommand sqlcom = sqlcon.CreateCommand();
            sqlcom.CommandText = $"update reader set readerPassword='{password_box.Text}',phone='{phone_box.Text}',reg_date='{dateTime_box.Value}',certificate_kind='{id_kind_box.Text}',certificate='{id_number_box.Text}' where readerId='{readerid_box.Text}'";
            int flag = sqlcom.ExecuteNonQuery();
            if(flag==1)
            {
                MessageBoxEx.Show("更新成功！");
            }
            else
            {
                MessageBoxEx.Show("更新失败！");
            }
            read_reader_from_database();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem a;
            if (listView1.SelectedItems.Count != 0)
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

        private void phone_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex_int.IsInt(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void search_Click(object sender, EventArgs e)
        {
            SqlCommand sqlcom = sqlcon.CreateCommand();
            sqlcom.CommandText = $"select * from reader where upper(readerId) like upper('%{search_box.Text}%')";
            SqlDataReader sqlreader = sqlcom.ExecuteReader();
            listView1.Items.Clear();
            listView1.BeginUpdate();
            while (sqlreader.Read())
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

        private void Excel_button_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
                return;
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            excel.Visible = true;

            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                excel.Cells[1, i + 1] = listView1.Columns[i].Text;
            }

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                for (int j = 0; j < listView1.Columns.Count; j++)
                {
                    excel.Cells[i + 2, j + 1] = "" + listView1.Items[i].SubItems[j].Text;
                }
            }
        }
    }
}