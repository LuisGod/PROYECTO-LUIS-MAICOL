using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PRIMER_PROYECTO_UAM
{
    public class Conexion
    {

        private string sqlConnection = "Data Source=LUIS\\SQLEXPRESS2012;Initial Catalog=PROYECTO_UAM_technologies;Integrated Security=True";

       

                                   

        public string SQLConnection
        {
            get
            {
                return sqlConnection;
            }
        }

        public SqlConnection CreateConnection()
        {
            SqlConnection connection = new SqlConnection(sqlConnection);
            return connection;
        }

        public SqlCommand CreateCommand(SqlConnection cnn)
        {
            SqlCommand sqlcommand = new SqlCommand(sqlConnection, cnn);
            return sqlcommand;
        }


    }
}

