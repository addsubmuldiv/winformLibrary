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
    public partial class delete_reader_frm : DevComponents.DotNetBar.OfficeForm
    {
        SqlConnection sqlcon;
        private static delete_reader_frm uniqueInstance;
        private delete_reader_frm()
        {
            InitializeComponent();
            getSqlConnection getcon = new getSqlConnection();
            sqlcon = getcon.GetCon();
            read_reader_from_database();
        }

        public static delete_reader_frm getInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new delete_reader_frm();
            return uniqueInstance;
        }

        public void read_reader_from_database()
        {
            listView1.Items.Clear();
            SqlCommand sqlcom = sqlcon.CreateCommand();
            sqlcom.CommandText = $"select * from reader";
            SqlDataReader sqlreader = sqlcom.ExecuteReader();
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

        private void delete_reader_Click(object sender, EventArgs e)
        {
            //  ListViewItem a;
            MessageBoxEx.EnableGlass = false;
            int count = 0, temp;
            SqlCommand sqlcom = sqlcon.CreateCommand();
            temp = listView1.CheckedItems.Count;
            if (listView1.CheckedItems.Count != 0)
            {
                if (!(MessageBoxEx.Show($"确认删除这{listView1.CheckedItems.Count}项？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    return;
                }
                for (int i = 0; i < listView1.CheckedItems.Count; i++)
                {
                    if (listView1.CheckedItems[i].Checked)
                    {
                        sqlcom.CommandText = $"delete from reader where readerId='{listView1.CheckedItems[i].Text}' and readerPassword={listView1.CheckedItems[i].SubItems[1].Text}";
                        int flag = sqlcom.ExecuteNonQuery();
                        if (flag == 1)
                        {
                            // MessageBoxEx.Show("删除成功!");
                            count++;
                        }
                    }
                }
            }
            if (count == temp)
                MessageBoxEx.Show($"成功删除{count}项！");
            read_reader_from_database();
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
    }
}