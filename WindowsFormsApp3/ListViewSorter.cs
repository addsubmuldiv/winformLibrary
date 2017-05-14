using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class ListViewSort : IComparer
    {
        private int col;
        private bool descK;
        public ListViewSort()
        {
            col = 0;
        }
        public ListViewSort(int column, object Desc)
        {
            descK = (bool)Desc;
            col = column; //当前列,0,1,2...,参数由ListView控件的ColumnClick事件传递 
        }
        public static bool IsNumeric(string value)
        {
            return Regex.IsMatch(value, @"^[+-]?\d*[.]?\d*$");
        }
        public static bool IsDate(string value)
        {
            return Regex.IsMatch(value, @"^\d{4}(\-|\/|\.)\d{1,2}\1\d{1,2}$");
        }
        public int Compare(object x, object y)
        {

            //   int tempInt = String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            int tempInt;

            if(IsDate(((ListViewItem)x).SubItems[col].Text)&&IsDate(((ListViewItem)y).SubItems[col].Text))
            {
                tempInt = DateTime.Parse(((ListViewItem)x).SubItems[col].Text) < DateTime.Parse(((ListViewItem)y).SubItems[col].Text) ? -1 : 1;
                if (descK)
                    return -tempInt;
                else
                    return tempInt;
            }

            if(IsNumeric(((ListViewItem)x).SubItems[col].Text)&&IsNumeric(((ListViewItem)y).SubItems[col].Text))
            {
                tempInt = double.Parse(((ListViewItem)x).SubItems[col].Text) < double.Parse(((ListViewItem)y).SubItems[col].Text) ? -1 : 1;
                if (descK)
                    return -tempInt;
                else
                    return tempInt;
            }
            tempInt = String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            if (descK) return -tempInt;
            else return tempInt;
        }
    }
}
