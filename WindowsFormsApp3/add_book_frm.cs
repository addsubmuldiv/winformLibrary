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
    public partial class add_book_frm : DevComponents.DotNetBar.OfficeForm
    {

        private static add_book_frm uniqueInstance;
        private SqlConnection sqlcon;
        private add_book_frm()
        {
            InitializeComponent();
            getSqlConnection getcon = new getSqlConnection();
            sqlcon = getcon.GetCon();
            try { sqlcon.Open(); }
            catch { }
            /*     for(int i=0;i<10;i++)
                 {
                     ListViewItem a = new ListViewItem();
                     a.Text = "asd"+i;
                     a.SubItems.Add("fuck off" + i);
                     a.SubItems.Add("fuck off" + i);
                     a.SubItems.Add("fuck off" + i);
                     a.SubItems.Add("fuck off" + i);
                     a.SubItems.Add("fuck off" + i);
                     a.SubItems.Add("fuck off" + i);
                     a.SubItems.Add("fuck off" + i);
                     a.SubItems.Add("fuck off" + i);
                     listViewEx1.Items.Add(a);
                 }*/
            read_from_database_to_listview();
        }
        public void read_from_database_to_listview()
        {
            listViewEx1.Items.Clear();
            listViewEx1.BeginUpdate();
            SqlCommand sqlcom = sqlcon.CreateCommand();
            sqlcom.CommandText = "select * from book";
            SqlDataReader sqlreader = sqlcom.ExecuteReader();
            while(sqlreader.Read())
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
        public static add_book_frm getInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new add_book_frm();
            return uniqueInstance;
        }

        private void add_book_Click(object sender, EventArgs e)
        {
            MessageBoxEx.EnableGlass = false;
            if(bookid.Text==""||
                bookname.Text==""||
                price.Text==""||
                datetime.Text==""||
                publishing.Text==""||
                author.Text==""||
                kind.Text==""||
                number.Text=="")
            {
                MessageBoxEx.Show("图书信息不可为空！");
                return;
            }
            SqlCommand sqlcom = sqlcon.CreateCommand();

            sqlcom.CommandText = $"select count(*) from book where bookId={bookid.Text}";
            if(Convert.ToInt32(sqlcom.ExecuteScalar())!=0)
            {
                MessageBoxEx.Show("此书ID已存在！");
                return;
            }
            sqlcom.CommandText = $"insert into book values('{bookname.Text}',{bookid.Text},'{author.Text}',0,'{publishing.Text}',{price.Text},{number.Text},'{kind.Text}','{datetime.Value}')";
            int flag = sqlcom.ExecuteNonQuery();
            if(flag==1)
            {
                MessageBoxEx.Show("添加成功！");
            }
            else
            {
                MessageBoxEx.Show("添加失败！");
            }
            listViewEx1.Items.Clear();
            read_from_database_to_listview();
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Regex_int.IsInt(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
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
    }
}