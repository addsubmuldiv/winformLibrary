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
    public partial class return_handle_frm : DevComponents.DotNetBar.OfficeForm
    {
        private SqlConnection sqlcon;
        private static return_handle_frm uniqueInstance;
        private return_handle_frm()
        {
            InitializeComponent();
            getSqlConnection getcon = new getSqlConnection();
            sqlcon = getcon.GetCon();
            read_borrow_from_database();
        }
        public static return_handle_frm getInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new return_handle_frm();
            return uniqueInstance;
        }
        public void read_borrow_from_database()
        {
            listView1.Items.Clear();
            listView1.Update();
            SqlCommand sqlcom = sqlcon.CreateCommand();
            sqlcom.CommandText = $"select * from borrow";
            SqlDataReader sqlreader = sqlcom.ExecuteReader();
            while (sqlreader.Read())
            {
                ListViewItem lv = new ListViewItem(sqlreader[0].ToString());
                lv.SubItems.Add(sqlreader[1].ToString());
                lv.SubItems.Add(Convert.ToDateTime(sqlreader[2]).ToShortDateString());
                lv.SubItems.Add(Convert.ToDateTime(sqlreader[3]).ToShortDateString());
                lv.SubItems.Add(Convert.ToDateTime(sqlreader[4]).ToShortDateString());
                //     lv.SubItems.Add(sqlreader[5].ToString());
                lv.SubItems.Add((sqlreader[5].ToString() == "False" ? "否" : "是"));
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

        private void search_Click(object sender, EventArgs e)
        {
            string a = "";
            switch (comboBoxEx1.SelectedIndex)
            {
                case 0: a = "bookId"; break;
                case 1: a = "readerId"; break;
                default: break;
            }
            SqlCommand sqlcom = sqlcon.CreateCommand();
            sqlcom.CommandText = $"select * from borrow where upper({a}) like upper('%{search_box.Text}%')";
            SqlDataReader sqlreader = sqlcom.ExecuteReader();




            /*   SqlCommand sqlcom = sqlcon.CreateCommand();
               sqlcom.CommandText = $"select * from book where upper(name) like upper('%{search_box.Text}%')";
               SqlDataReader sqlreader = sqlcom.ExecuteReader();*/
            listView1.Items.Clear();
            listView1.BeginUpdate();
            while (sqlreader.Read())
            {
                ListViewItem lv = new ListViewItem(sqlreader[0].ToString());
                lv.SubItems.Add(sqlreader[1].ToString());
                lv.SubItems.Add(Convert.ToDateTime(sqlreader[2]).ToShortDateString());
                lv.SubItems.Add(Convert.ToDateTime(sqlreader[3]).ToShortDateString());
                lv.SubItems.Add(Convert.ToDateTime(sqlreader[4]).ToShortDateString());
                lv.SubItems.Add(sqlreader[5].ToString());
                listView1.Items.Add(lv);
            }
            sqlreader.Close();
            listView1.EndUpdate();
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            int count = 0;
            MessageBoxEx.EnableGlass = false;
            if (listView1.CheckedItems.Count != 0)
            {
                SqlCommand sqlcom = sqlcon.CreateCommand();
                for (int i = 0; i < listView1.CheckedItems.Count; i++)
                {
                    sqlcom.CommandText = $"select isReturned from borrow where bookId={listView1.CheckedItems[i].Text} and readerId='{listView1.CheckedItems[i].SubItems[1].Text}'";
                    if(Convert.ToInt32(sqlcom.ExecuteScalar())==1)
                    {
                        MessageBoxEx.Show($"读者{listView1.CheckedItems[i].SubItems[1].Text}已归还ID为{listView1.CheckedItems[i].Text}的书！");
                        count++;
                        if(count==listView1.CheckedItems.Count)
                        {
                            return;
                        }
                    }
                    sqlcom.CommandText = $"update borrow set isReturned=1,real_return_date='{DateTime.Now.ToShortDateString()}' where bookId={listView1.CheckedItems[i].Text} and readerId='{listView1.CheckedItems[i].SubItems[1].Text}'";
                    sqlcom.ExecuteNonQuery();
                    sqlcom.CommandText = $"update book set borrow_time=borrow_time+1,number=number+1 where bookId={listView1.CheckedItems[i].Text}";
                    sqlcom.ExecuteNonQuery();
                }
                MessageBoxEx.Show($"归还{listView1.CheckedItems.Count}本！");
            }
            read_borrow_from_database();
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
                excel.Columns.AutoFit();
            }

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                for (int j = 0; j < listView1.Columns.Count; j++)
                {
                    excel.Cells[i + 2, j + 1] = "" + listView1.Items[i].SubItems[j].Text;
                    excel.Columns.AutoFit();
                }
            }
        }
    }
}