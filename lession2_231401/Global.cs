using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace lession2_231401
{
    internal class Global
    {

        public static String getThumucAnh()
        {
            

                String getstr =
           ConfigurationManager.ConnectionStrings["ThumucAnh"].ConnectionString;
            return getstr;
        }

        public static String getConnectionString()
        {
            //String getstr = @"Server=127.0.0.1,1435;Database=Northwind;User Id=sa;Password=Vietnam@123;TrustServerCertificate=True;";
            String getstr =
           ConfigurationManager.ConnectionStrings["Northwind_conn"].ConnectionString;
            return getstr;
        }

        public static SqlConnection GetConnection()
        {
            String conn_str = getConnectionString();
            SqlConnection conn = new SqlConnection(conn_str);
            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            return conn;
        }

        public static int  ToInt(object obj)
        {
            int i = 0;
            if (obj == null) return 0;

            if (obj != null)
            {

                int.TryParse(obj.ToString(), out i);
            }
            return i;

        }

        public static double ToDouble(object obj)
        {
            double i = 0;
            if (obj == null) return 0;

            if (obj != null)
            {

                double.TryParse(obj.ToString(), out i);
            }
            return i;

        }


    }
}
