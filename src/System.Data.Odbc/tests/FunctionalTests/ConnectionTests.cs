using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace System.Data.Odbc.Tests
{
    public class ConnectionTests
    {
        [Fact]
        public void NorthwindTest()
        {
            // have an ODBC DSN setup named MYSQLDSN
            // that accesses a MySQL database via
            // MyODBC driver for ODBC with a
            // hostname of localhost and database test
            string connectionString =
               "DSN=MYSQLDSN;" +
               "UID=myuserid;" +
               "PWD=mypassword";
            IDbConnection dbcon;
            dbcon = new OdbcConnection(connectionString);
            dbcon.Open();
            IDbCommand dbcmd = dbcon.CreateCommand();
            // requires a table to be created named employee
            // with columns firstname and lastname
            // such as,
            //        CREATE TABLE employee (
            //           firstname varchar(32),
            //           lastname varchar(32));
            string sql =
                "SELECT firstname, lastname " +
                "FROM employee";
            dbcmd.CommandText = sql;
            IDataReader reader = dbcmd.ExecuteReader();
            while (reader.Read())
            {
                string FirstName = (string)reader["firstname"];
                string LastName = (string)reader["lastname"];
                Console.WriteLine("Name: " +
                    FirstName + " " + LastName);
            }
            // clean up
            reader.Close();
            reader = null;
            dbcmd.Dispose();
            dbcmd = null;
            dbcon.Close();
            dbcon = null;
        }
    }
}
