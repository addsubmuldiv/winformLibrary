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
        public Main_form()
        {
            InitializeComponent();
        }

        private void Main_form_Load(object sender, EventArgs e)
        {
            System.Threading.Thread Timethread = new System.Threading.Thread
                (
                () =>
                {
                    while (true)
                    {
                        this.Invoke(
                            (MethodInvoker)delegate ()
                            {
                                // this.Refresh();
                                try { this.labelItem5.Text = DateTime.Now.ToString(); }
                                catch { }
                            });
                        System.Threading.Thread.Sleep(1000);
                    }
                }
                );
            Timethread.IsBackground = true;
            Timethread.Start();
        }

        private void Main_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxEx.EnableGlass = false;
            if(MessageBoxEx.Show("��Ҫ�رմ��壬�Ƿ������","ѯ��",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            add_book_frm a = add_book_frm.getInstance();
            set_child_frm(a, panel1);
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
            if(e.Node.Name=="add_book")
                toolStripButton1_Click(sender, e);
        }
    }
}