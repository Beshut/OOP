using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial.SqlConn;
using MySql.Data.MySqlClient;
using CsMySQLTutorial;

namespace ConnectMySQL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting Connection ...");
            MySqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                Console.WriteLine("Openning Connection ...");
                conn.Open();
                Console.WriteLine("Connection successful!");

                QueryDataExample example = new QueryDataExample();
                example.run(conn);
                Console.WriteLine("-------------INSERT DATA---------------");
                example.insertData(conn);
                example.updateData(conn);
                example.removeData(conn);
                example.scalarExample(conn);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            Console.Read();
        }
    }
}
