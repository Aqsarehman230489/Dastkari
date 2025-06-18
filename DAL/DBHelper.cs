using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DAL
{
    public class DBHelper
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=DESKTOP-F550SAA\\SQLEXPRESS;Initial Catalog=DBdastkari;Integrated Security=True;Trust Server Certificate=True");
        }

    }
}
