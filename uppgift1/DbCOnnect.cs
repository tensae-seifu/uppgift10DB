using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tesddb2
{
    internal class DbCOnnect
    {

        public SqlConnection _Conn;

        public DbCOnnect(SqlConnection Conn)

        {
            this._Conn = Conn;

        }

        public string Connect()

        {
            _Conn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Student;Integrated Security=True";

            _Conn.Open();

            return _Conn.ConnectionString;


        }


    }
}
