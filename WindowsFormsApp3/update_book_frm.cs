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
    public partial class update_book_frm : DevComponents.DotNetBar.OfficeForm
    {
        private static update_book_frm uniqueInstance;
        private update_book_frm()
        {
            InitializeComponent();
            this.TopLevel = false;
        }
        public static update_book_frm getInstance()
        {
            if(uniqueInstance==null)
            {
                uniqueInstance = new update_book_frm();
            }
            return uniqueInstance;
        }
    }
}