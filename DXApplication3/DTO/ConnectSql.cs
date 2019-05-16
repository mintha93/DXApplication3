using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

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
                    //con = new SqlConnection("Data Source=192.168.68.252;Network Library=DBMSSOCN;Initial Catalog=DUYANH;User ID=sa;Password=SQL@123@");
                    con = new SqlConnection(getPath(1));

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

        public static string  getPath(int value)
        {
            List<string> strList = new List<string>();
            FileStream fs = new FileStream("D:\\Intem\\Report\\Path.txt", FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            String line1 = rd.ReadLine();
            String line2 = rd.ReadLine();
            strList.Add(line1.Substring(7, line1.Length - 7));
            strList.Add(line2.Substring(17, line2.Length - 17));
            rd.Close();
            return strList[value];
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
