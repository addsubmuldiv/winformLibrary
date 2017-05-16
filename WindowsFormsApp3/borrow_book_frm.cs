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
    public partial class borrow_book_frm : DevComponents.DotNetBar.OfficeForm
    {
        private SqlConnection sqlcon;
        private static borrow_book_frm uniqueInstance;
        private borrow_book_frm()
        {
            InitializeComponent();
            getSqlConnection getcon = new getSqlConnection();
            sqlcon = getcon.GetCon();
        }
        public static borrow_book_frm getInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new borrow_book_frm();
            return uniqueInstance;
        }
        public void read_from_database_to_listview()
        {
            listViewEx1.Items.Clear();
            listViewEx1.BeginUpdate();
            SqlCommand sqlcom = sqlcon.CreateCommand();
            sqlcom.CommandText = "select * from book";
            SqlDataReader sqlreader = sqlcom.ExecuteReader();
            while (sqlreader.Read())
            {
                ListViewItem lv = new ListViewItem(sqlreader[0].ToString());
                lv.SubItems.Add(sqlreader[1].ToString());
                lv.SubItems.Add(sqlreader[2].ToString());
                lv.SubItems.Add(sqlreader[3].ToString());
                lv.SubItems.Add(sqlreader[4].ToString());
                lv.SubItems.Add(sqlreader[5].ToString());
                lv.SubItems.Add(sqlreader[6].ToString());
                lv.SubItems.Add(sqlreader[7].ToString());
                lv.SubItems.Add(Convert.ToDateTime(sqlreader[8]).ToShortDateString());
                listViewEx1.Items.Add(lv);
            }
            sqlreader.Close();
            listViewEx1.EndUpdate();
        }

        private void listViewEx1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (this.listViewEx1.Columns[e.Column].Tag == null)
                this.listViewEx1.Columns[e.Column].Tag = true;
            bool flag = (bool)this.listViewEx1.Columns[e.Column].Tag;
            if (flag)
                this.listViewEx1.Columns[e.Column].Tag = false;
            else
                this.listViewEx1.Columns[e.Column].Tag = true;
            this.listViewEx1.ListViewItemSorter = new ListViewSort(e.Column, this.listViewEx1.Columns[e.Column].Tag);
            this.listViewEx1.Sort();//对列表进行自定义排序  
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            string a="";
            switch (comboBoxEx1.SelectedIndex)
            {
                case 0:a = "name";break;
                case 1:a = "author";break;
                case 2:a = "bookId";break;
                case 3:a = "kind";break;
                default:break;
            }
            SqlCommand sqlcom = sqlcon.CreateCommand();
            sqlcom.CommandText = $"select * from book where upper({a}) like upper('%{search_box.Text}%')";
            SqlDataReader sqlreader = sqlcom.ExecuteReader();
            listViewEx1.Items.Clear();
            listViewEx1.BeginUpdate();
            while (sqlreader.Read())
            {
                ListViewItem lv = new ListViewItem(sqlreader[0].ToString());
                lv.SubItems.Add(sqlreader[1].ToString());
                lv.SubItems.Add(sqlreader[2].ToString());
                lv.SubItems.Add(sqlreader[3].ToString());
                lv.SubItems.Add(sqlreader[4].ToString());
                lv.SubItems.Add(sqlreader[5].ToString());
                lv.SubItems.Add(sqlreader[6].ToString());
                lv.SubItems.Add(sqlreader[7].ToString());
                lv.SubItems.Add(Convert.ToDateTime(sqlreader[8]).ToShortDateString());
                listViewEx1.Items.Add(lv);
            }
            sqlreader.Close();
            listViewEx1.EndUpdate();
        }

        private void borrow_button_Click(object sender, EventArgs e)
        {
            MessageBoxEx.EnableGlass = false;
            int count = 0, temp, num;
            SqlCommand sqlcom = sqlcon.CreateCommand();
            temp = listViewEx1.CheckedItems.Count;
            if (listViewEx1.CheckedItems.Count != 0)
            {
            /*    if (!(MessageBoxEx.Show($"确认删除这{listViewEx1.CheckedItems.Count}项？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    return;
                }*/
                for (int i = 0; i < listViewEx1.CheckedItems.Count; i++)
                {
                   
                    if (listViewEx1.CheckedItems[i].Checked)
                    {
                        sqlcom.CommandText = $"select count(*) from reader where readerId='{readerId_box.Text}'";
                        if (Convert.ToInt32(sqlcom.ExecuteScalar()) != 1)
                        {
                            MessageBoxEx.Show("此用户ID不存在！");
                            return;
                        }


                        sqlcom.CommandText = $"select number from book where bookId={listViewEx1.CheckedItems[i].SubItems[1].Text}";
                        num = Convert.ToInt32(sqlcom.ExecuteScalar());
                        if (num==0)
                        {
                            MessageBoxEx.Show($"{listViewEx1.CheckedItems[i].Text}已借完！");
                            return;
                        }

                        sqlcom.CommandText = $"insert into borrow values({listViewEx1.CheckedItems[i].SubItems[1].Text},'{readerId_box.Text}','{DateTime.Now.ToShortDateString()}','{DateTime.Now.AddDays(60).ToShortDateString()}','{DateTime.Parse("1970-01-01")}',0)"; 
                        int flag = sqlcom.ExecuteNonQuery();
                        if (flag == 1)
                        {
                            sqlcom.CommandText = $"update book set number={num-1} where bookId={listViewEx1.CheckedItems[i].SubItems[1].Text}";
                            sqlcom.ExecuteNonQuery();
                            // MessageBoxEx.Show("删除成功!");
                            count++;
                        }
                    }
                }
            }
            if (count == temp)
                MessageBoxEx.Show($"成功借阅{count}本书！");
            else
                MessageBoxEx.Show("很抱歉！出错了");
            read_from_database_to_listview();
        }

        private void borrow_book_frm_Activated(object sender, EventArgs e)
        {
            readerId_box.Focus();
        }
    }
}