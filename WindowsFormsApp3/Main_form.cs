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
                                this.labelItem5.Text = DateTime.Now.ToString();
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
            if(MessageBoxEx.Show("将要关闭窗体，是否继续？","询问",MessageBoxButtons.YesNo)==DialogResult.Yes)
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
            add_book_frm a = new add_book_frm();
            a.TopLevel = false;
            a.Parent = panel1;
            a.WindowState = FormWindowState.Maximized;
            a.Show();
        }
    }
}