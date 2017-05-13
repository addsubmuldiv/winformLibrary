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
    }
}