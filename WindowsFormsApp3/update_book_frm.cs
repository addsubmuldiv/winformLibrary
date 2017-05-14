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
        private void read_from_database_to_listview()
        {
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
            if(e.Column==bookid.TabIndex)
            {
                listViewEx1.Sorting = System.Windows.Forms.SortOrder.Ascending;
                listViewEx1.Sort();
            }
        }
    }
}