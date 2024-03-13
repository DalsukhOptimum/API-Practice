using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQLHelper
{
    public class SqlConectionClass
    {
        public SqlConnection con;

        public SqlConectionClass()
        {
            //making connection string here so i can use that everywhere
            con = new SqlConnection("Data Source=OPTIMUM98\\SQLEXPRESS;Initial Catalog=monthlyexpense;Integrated Security=SSPI");
        }
        public SqlConnection GetConnection()
        {
            return con; 

        }

    }
}
