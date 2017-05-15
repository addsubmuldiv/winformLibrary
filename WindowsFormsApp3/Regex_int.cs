using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Regex_int
    {
        public static bool IsInt(string value)
        {
            if (value == "\b") return true;
            return Regex.IsMatch(value, @"^[+-]?\d*$");
        }
    }
}
