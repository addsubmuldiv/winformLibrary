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
            while(sqlreader.Read())
            {
                ListViewItem lv = new ListViewItem(sqlreader[0].ToString());
                lv.SubItems.Add(sqlreader[1].ToString());
                lv.SubItems.Add(Convert.ToDateTime(sqlreader[2]).ToShortDateString());
                lv.SubItems.Add(Convert.ToDateTime(sqlreader[3]).ToShortDateString());
                lv.SubItems.Add(Convert.ToDateTime(sqlreader[4]).ToShortDateString());
           //     lv.SubItems.Add(sqlreader[5].ToString());
                lv.SubItems.Add((sqlreader[5].ToString()=="False"? "否":"是"));
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

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }
    }
}