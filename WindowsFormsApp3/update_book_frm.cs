using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
namespace WindowsFormsApp3
{
    public partial class update_book_frm : DevComponents.DotNetBar.OfficeForm
    {
        private SqlConnection sqlcon;
        private static update_book_frm uniqueInstance;
        private update_book_frm()
        {
            InitializeComponent();
            this.TopLevel = false;
            getSqlConnection getcon = new getSqlConnection();
            sqlcon = getcon.GetCon();
            try { sqlcon.Open(); }
            catch(Exception ex) { }
            read_from_database_to_listview();
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
        public static update_book_frm getInstance()
        {
            if(uniqueInstance==null)
            {
                uniqueInstance = new update_book_frm();
            }
            return uniqueInstance;
        }

        private void listViewEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem a;
            if (listViewEx1.SelectedItems.Count != 0)
            {
                a = listViewEx1.SelectedItems[0];
                bookname.Text = a.Text;
                bookid.Text = a.SubItems[1].Text;
                author.Text = a.SubItems[2].Text;
                publishing.Text = a.SubItems[4].Text;
                price.Text = a.SubItems[5].Text;
                number.Text = a.SubItems[6].Text;
                kind.Text = a.SubItems[7].Text;
                datetime.Value = DateTime.Parse(a.SubItems[8].Text);
            }
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

        private void update_book_Click(object sender, EventArgs e)
        {
            MessageBoxEx.EnableGlass = false;
            if (bookid.Text == "" ||
                bookname.Text == "" ||
                price.Text == "" ||
                datetime.Text == "" ||
                publishing.Text == "" ||
                author.Text == "" ||
                kind.Text == "" ||
                number.Text == "")
            {
                MessageBoxEx.Show("图书信息不可为空！");
                return;
            }
            SqlCommand sqlcom = sqlcon.CreateCommand();

            sqlcom.CommandText = $"select count(*) from book where bookId={bookid.Text}";
            int flag;
            if (Convert.ToInt32(sqlcom.ExecuteScalar()) != 0)
            {
                sqlcom.CommandText = $"update book set name='{bookname.Text}',author='{author.Text}',publishing_house='{publishing.Text}',price={price.Text},number={number.Text},kind='{kind.Text}',publising_date='{datetime.Value}' where bookId={bookid.Text}";
                flag = sqlcom.ExecuteNonQuery();
                if (flag == 1)
                {
                    MessageBoxEx.Show("更新成功！");
                }
                else
                {
                    MessageBoxEx.Show("更新失败！");
                }
                listViewEx1.Items.Clear();
                read_from_database_to_listview();
            }
            else
            {
                return;
            }
        }

        private void search_Click(object sender, EventArgs e)
        {

            string a = "";
            switch (comboBoxEx1.SelectedIndex)
            {
                case 0: a = "name"; break;
                case 1: a = "author"; break;
                case 2: a = "bookId"; break;
                case 3: a = "kind"; break;
                default: break;
            }
            SqlCommand sqlcom = sqlcon.CreateCommand();
            sqlcom.CommandText = $"select * from book where upper({a}) like upper('%{search_box.Text}%')";
            SqlDataReader sqlreader = sqlcom.ExecuteReader();




         /*   SqlCommand sqlcom = sqlcon.CreateCommand();
            sqlcom.CommandText = $"select * from book where upper(name) like upper('%{search_box.Text}%')";
            SqlDataReader sqlreader = sqlcom.ExecuteReader();*/
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

        private void bookid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Regex_int.IsInt(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Regex_int.IsInt(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Regex_int.IsInt(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void Excel_button_Click(object sender, EventArgs e)
        {
            if (listViewEx1.Items.Count == 0)
                return;
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            excel.Visible = true;

            for(int i=0;i<listViewEx1.Columns.Count;i++)
            {
                excel.Cells[1, i + 1] = listViewEx1.Columns[i].Text;
            }

            for(int i=0;i<listViewEx1.Items.Count;i++)
            {
                for(int j=0;j<listViewEx1.Columns.Count;j++)
                {
                    excel.Cells[i + 2, j + 1] = "" + listViewEx1.Items[i].SubItems[j].Text;
                }
            }
        }
    }
}
