using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
namespace WindowsFormsApp3
{
    public partial class reader_form : DevComponents.DotNetBar.OfficeForm
    {
        private System.Threading.Thread Timethread;
        private SqlConnection sqlcon;
        public string userid;
        public string userpassword;
     
        public reader_form()
        {
            InitializeComponent();
            getSqlConnection getcon = new getSqlConnection();
            sqlcon = getcon.GetCon();
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
        private void reader_form_Load(object sender, EventArgs e)
        {
               Timethread= new System.Threading.Thread
               (
               () =>
               {
                   while (true)
                   {
                       try
                       {
                           this.Invoke(
                           (MethodInvoker)delegate ()
                           {
                                // this.Refresh();
                                try { this.labelItem5.Text = DateTime.Now.ToString(); }
                               catch { }
                           });
                       }
                       catch { }
                       System.Threading.Thread.Sleep(1000);
                   }
               }
               );
            Timethread.IsBackground = true;
            Timethread.Start();
            read_from_database_to_listview();
            read_borrow_from_database();
            SqlCommand sqlcom = sqlcon.CreateCommand();
            sqlcom.CommandText = $"select * from reader where readerId='{userid}'";
            SqlDataReader sqlreader = sqlcom.ExecuteReader();
            while(sqlreader.Read())
            {
                readerid_box.Text = sqlreader[0].ToString();
                password_box.Text = sqlreader[1].ToString();
                phone_box.Text = sqlreader[2].ToString();
                id_kind_box.Text = sqlreader[4].ToString();
                id_number_box.Text = sqlreader[5].ToString();
                dateTime_box.Value = DateTime.Parse(sqlreader[3].ToString());
            }
            sqlreader.Close();
        }

        private void reader_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxEx.EnableGlass = false;
            Timethread.Abort();
            sqlcon.Close();
            if (MessageBoxEx.Show("将要关闭窗体，是否继续？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;
                System.Threading.Thread.Sleep(100);
                try { System.Environment.Exit(0); }
                catch { }
            }
            else
            {
                e.Cancel = true;
            }
        }
        public void read_borrow_from_database()
        {
            listView1.Items.Clear();
            listView1.Update();
            SqlCommand sqlcom = sqlcon.CreateCommand();
            sqlcom.CommandText = $"select * from borrow where readerId='{userid}'";
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

        private void update_reader_Click(object sender, EventArgs e)
        {
            SqlCommand sqlcom = sqlcon.CreateCommand();
            sqlcom.CommandText = $"update reader set readerPassword='{password_box.Text}',phone='{phone_box.Text}',certificate_kind='{id_kind_box.Text}',certificate='{id_number_box.Text}' where readerId='{userid}'";
            int flag = sqlcom.ExecuteNonQuery();
            if(flag==1)
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.Show("更新成功！");
            }
        }

        private void phone_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex_int.IsInt(e.KeyChar.ToString()))
                e.Handled = true;
        }
    }
}