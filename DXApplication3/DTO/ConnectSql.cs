using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DXApplication3.DTO
{
    class ConnectSql
    {
        private static SqlConnection con;

        public static SqlConnection getConnect()
        {
            try
            {
                if (con == null)
                {
                    //con = new SqlConnection("Data Source = DESKTOP-B9QFJSF; Initial Catalog = DUYANH; Integrated Security = True");
                    //con = new SqlConnection("Data Source=113.161.91.59,1433;Network Library=DBMSSOCN;Initial Catalog=DUYANH;User ID=sa;Password=SQL@123@");
                    con = new SqlConnection("Data Source=192.168.68.252;Network Library=DBMSSOCN;Initial Catalog=DUYANH;User ID=sa;Password=SQL@123@");

                    con.Open();
                }

                return con;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to database [SQL]");
                Console.WriteLine(ex.ToString());
            }

            return null;
        }

        public static void closeConnect()
        {
            if (con != null)
            {
                con.Close();
                con.Dispose();
            }
        }
    }
}
