using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace WindowsFormsApp3
{
    public partial class Main_form : DevComponents.DotNetBar.OfficeForm
    {
        private System.Threading.Thread Timethread;
        private string userid;
        public string Userid
        {
            set { userid = value; }
            get { return userid; }
        }

        public Main_form()
        {
            InitializeComponent();
        }

        private void Main_form_Load(object sender, EventArgs e)
        {
                Timethread = new System.Threading.Thread
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
        }

        private void Main_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Timethread.Abort();
            MessageBoxEx.EnableGlass = false;
            if (MessageBoxEx.Show("将要关闭窗体，是否继续？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;
                System.Threading.Thread.Sleep(100);
                System.Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            add_book_frm frm = add_book_frm.getInstance();
            set_child_frm(frm, panel1);
            frm.read_from_database_to_listview();
            frm.BringToFront();
        }
        private void set_child_frm(Form frm,Panel panel)
        {
            frm.TopLevel = false;
            frm.Parent = panel;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void add_book_Click(object sender, EventArgs e)
        {
            toolStripButton1_Click(sender, e);
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Name == "add_book")
                toolStripButton1_Click(sender, e);
            else if (e.Node.Name == "update_book")
                toolStripButton5_Click(sender, e);
            else if (e.Node.Name == "delete_book")
                toolStripButton2_Click(sender, e);
            else if (e.Node.Name == "add_reader")
                toolStripButton3_Click(sender, e);
            else if (e.Node.Name == "update_reader")
                toolStripButton6_Click(sender, e);
            else if(e.Node.Name=="delete_reader")
                toolStripButton4_Click(sender, e);
            else if(e.Node.Name=="add_borrow")
                toolStripButton7_Click(sender, e);
            else
                toolStripButton8_Click(sender, e);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            update_book_frm frm = update_book_frm.getInstance();
            set_child_frm(frm, panel1);
            frm.read_from_database_to_listview();
            frm.BringToFront();
        }

        private void update_book_Click(object sender, EventArgs e)
        {
            toolStripButton5_Click(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            delete_frm frm = delete_frm.getInstance();
            set_child_frm(frm, panel1);
            frm.read_from_database_to_listview();
            frm.BringToFront();
        }

        private void delete_book_Click(object sender, EventArgs e)
        {
            toolStripButton2_Click(sender, e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            add_reader_frm frm = add_reader_frm.getInstance();
            set_child_frm(frm, panel1);
            frm.read_reader_from_database();
            frm.BringToFront();
        }

        private void add_reader_Click(object sender, EventArgs e)
        {
            toolStripButton3_Click(sender, e);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            update_reader_frm frm = update_reader_frm.getInstance();
            set_child_frm(frm, panel1);
            frm.read_reader_from_database();
            frm.BringToFront();
        }

        private void update_reader_Click(object sender, EventArgs e)
        {
            toolStripButton6_Click(sender, e);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            delete_reader_frm frm = delete_reader_frm.getInstance();
            set_child_frm(frm, panel1);
            frm.read_reader_from_database();
            frm.BringToFront();
        }

        private void delete_reader_Click(object sender, EventArgs e)
        {
            toolStripButton4_Click(sender, e);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            borrow_book_frm frm = borrow_book_frm.getInstance();
            set_child_frm(frm, panel1);
            frm.read_from_database_to_listview();
            frm.BringToFront();
        }

        private void add_borrow_Click(object sender, EventArgs e)
        {
            toolStripButton7_Click(sender, e);
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            return_handle_frm frm = return_handle_frm.getInstance();
            set_child_frm(frm, panel1);
            frm.read_borrow_from_database();
            frm.BringToFront();
        }

        private void return_handle_Click(object sender, EventArgs e)
        {
            toolStripButton8_Click(sender, e);
        }

        private void change_password_item_Click(object sender, EventArgs e)
        {
            change_password frm = change_password.getInstance();
            frm.Userid = this.Userid;
            frm.Show();
            frm.BringToFront();
        }
    }
}