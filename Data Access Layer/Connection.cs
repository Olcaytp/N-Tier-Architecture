using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public class Connection
    {
        public static SqlConnection connect = new SqlConnection(@"Data Source=LENOVO-PC\MSSQLSERVER2;Initial Catalog=DbPersonel;Integrated Security=True");
    }
}
