using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WindowsFormsApp3
{
    public class getSqlConnection
    {
        String connection_str = "Data Source=DESKTOP-RSHU6JN;database=BooksInfo;uid=sa;pwd=Cloud19970613";
        SqlConnection sqlcon;
        public SqlConnection GetCon()
        {
            sqlcon = new SqlConnection(connection_str);
            sqlcon.Open();
            return sqlcon;
        }
    }
}
