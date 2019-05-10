using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;using System.Text;
using DevExpress.XtraGrid.Views.Grid;
using DXApplication3.DTO;
namespace DXApplication3.DAL
{
    class clDAL
    {
        SqlConnection _conn = null;
        public void InsertLabelNhapxuat( String SCT,String userName)
        {
                _conn = ConnectSql.getConnect();
                SqlCommand cmd = new SqlCommand("if (select 1 from dbo.LABEL_NHAPXUAT where SCT = @SCT and DONE=0)=1 "
                                                    +"begin "
                                                     +"update dbo.LABEL_NHAPXUAT "
                                                     +"set INLAI = INLAI + 1,DONE=1,COMPUTERNAME=HOST_NAME(),USERNAME=@USERNAME,GIOIN = GETDATE() "
                                                     +"where SCT = @SCT "
                                                    +"end "
                                                 +"else "
                                                    +"begin "
                                                    +"INSERT INTO dbo.LABEL_NHAPXUAT SELECT SCT, 1, NGAY, SOLUONG, HOST_NAME(), @USERNAME, GETDATE(),0 FROM NHAPXUAT WHERE SCT = @SCT "
                                                    +"end"
                                                    , _conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@SCT", SCT);
                cmd.Parameters.AddWithValue("@USERNAME", userName);
            cmd.ExecuteNonQuery();     
        }
        public void Unlockphieu(String SCT)
        {
            _conn = ConnectSql.getConnect();
            SqlCommand cmd = new SqlCommand("if (select 1 from dbo.LABEL_NHAPXUAT where SCT = @SCT and DONE=1)=1 "
                                                    +"begin "
                                                        +"update dbo.LABEL_NHAPXUAT "
                                                        +"set DONE = 0 "
                                                        +"where SCT = @SCT "
                                                    +"end"
                                                    , _conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@SCT", SCT);
            cmd.ExecuteNonQuery();
        }
        public DataTable getVCNB(String Date1, String Date2)
        {
            _conn = ConnectSql.getConnect();
            SqlCommand cmd = new SqlCommand("GET_VCNB_APP", _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@DATE1", SqlDbType.NVarChar);
            cmd.Parameters["@DATE1"].Value = Date1;
            cmd.Parameters.Add("@DATE2", SqlDbType.NVarChar);
            cmd.Parameters["@DATE2"].Value = Date2;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getVCNB_Search(String SCT, String Date1, String Date2)
        {
            _conn = ConnectSql.getConnect();
            SqlCommand cmd = new SqlCommand("GET_VCNB_APP_SEARCH", _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@SCT", SqlDbType.NVarChar);
            cmd.Parameters["@SCT"].Value = SCT;
            cmd.Parameters.Add("@DATE1", SqlDbType.NVarChar);
            cmd.Parameters["@DATE1"].Value = Date1;
            cmd.Parameters.Add("@DATE2", SqlDbType.NVarChar);
            cmd.Parameters["@DATE2"].Value = Date2;


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GET_VCNB_APP_DETAIL(String SCT)
        {
            _conn = ConnectSql.getConnect();
            SqlCommand cmd = new SqlCommand("GET_VCNB_APP_DETAIL", _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@SCT", SqlDbType.NVarChar);
            cmd.Parameters["@SCT"].Value = SCT;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public String GET_Password(String Username)
        {
         
                _conn = ConnectSql.getConnect();
                SqlCommand cmd = new SqlCommand("SELECT PASSWD FROM SYS_USER WHERE USERNAME = '" + Username+"'", _conn);
                cmd.CommandType = CommandType.Text;
                return cmd.ExecuteScalar().ToString();
        }
        public string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
        //-------------------------------------TEMLE-------------------------------------------//
        public DataTable GetdataTemle(String MAVT, Int32 Soluong, String Temgia)
        {
            _conn = ConnectSql.getConnect();
            SqlCommand cmd = new SqlCommand("GET_VCNB_APP_TEMLE", _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MAVT", SqlDbType.NVarChar);
            cmd.Parameters["@MAVT"].Value = MAVT;
            cmd.Parameters.Add("@SOLUONG", SqlDbType.Int);
            cmd.Parameters["@SOLUONG"].Value = Soluong;
            cmd.Parameters.Add("@TEMGIA", SqlDbType.Float);
            cmd.Parameters["@TEMGIA"].Value = Temgia;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public String getMaxKhoaTemLe()
        {
            _conn = ConnectSql.getConnect();
            SqlCommand Command = new SqlCommand();
            Command = _conn.CreateCommand();
            Command.CommandText = @"SELECT 'TEMLE' + RIGHT('0000000' + CONVERT(VARCHAR(7), MAX(CONVERT(INT,SUBSTRING(KHOA,6,LEN(KHOA)-5)))+1), 7)  FROM dbo.LABEL_TEMLE";
            String khoa = (String)Command.ExecuteScalar();
            return khoa;
        }

        public void Insertlabel_temle(String KHOA,String userName)
        {
            _conn = ConnectSql.getConnect();
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.LABEL_TEMLE " +
                "VALUES (@KHOA,HOST_NAME(),@USERNAME,GETDATE())", _conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@KHOA", KHOA);
            cmd.Parameters.AddWithValue("@USERNAME", userName);
            cmd.ExecuteNonQuery();
        }
        public void InsertLabel_temle_detail(String KHOA, String MAVT, Int32 SOLUONG, Double Temgia, String Currency)
        {
            _conn = ConnectSql.getConnect();
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.LABEL_TEMLE_DETAIL "+
                                            "VALUES  (@KHOA,@MAVT,@SOLUONG,@TEMGIA,@CURRENCY)", _conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@KHOA", KHOA);
            cmd.Parameters.AddWithValue("@MAVT", MAVT);
            cmd.Parameters.AddWithValue("@SOLUONG", SOLUONG);
            cmd.Parameters.AddWithValue("@TEMGIA", Temgia);
            cmd.Parameters.AddWithValue("@CURRENCY", Currency);
            cmd.ExecuteNonQuery();
        }
        public void deleteTemle(String KHOA)
        {
            _conn = ConnectSql.getConnect();
            SqlCommand cmd = new SqlCommand("DELETE dbo.LABEL_TEMLE WHERE KHOA = @KHOA" , _conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@KHOA", KHOA);
            cmd.ExecuteNonQuery();
        }
        public String getMultipleTotal(GridView gridView)
        {
            Double totalVND = 0;
            for (int i = 0; i < gridView.DataRowCount; i++)
            {
                totalVND = totalVND + Convert.ToDouble(gridView.GetRowCellValue(i, "SOLUONG")) * Convert.ToDouble(TestNull(gridView.GetRowCellValue(i, "GIABAN").ToString()));
            }
            return totalVND.ToString();

        }
        public String getMultipleTotalTemle(GridView gridView)
        {
            Double totalUSD = 0;
            for (int i = 0; i < gridView.DataRowCount; i++)
            {
                totalUSD = totalUSD + Convert.ToDouble(gridView.GetRowCellValue(i, "SOLUONG")) * (Convert.ToDouble(TestNull(gridView.GetRowCellValue(i, "TEMGIA").ToString())));
            }
            return totalUSD.ToString();

        }
        public  String TestNull(string s)
        {
            if (String.IsNullOrEmpty(s))
                return "0";
            else
                return s;
        }
        public string getPath(int value)
        {
            List<string> strList = new List<string>();
            FileStream fs = new FileStream("D:\\Intem\\Report\\Path.txt", FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            String line1 = rd.ReadLine();
            String line2 = rd.ReadLine();
            String line3 = rd.ReadLine();
            String line4 = rd.ReadLine();
            strList.Add(line1.Substring(7, line1.Length - 7));
            strList.Add(line2.Substring(17, line2.Length - 17));
            strList.Add(line3.Substring(12, line3.Length - 12));
            strList.Add(line4.Substring(10, line4.Length - 10));
            rd.Close();
            return strList[value];
        }
        //---------------------------------------------------------TEM D6-----------------------------------------------------------------------//

        public DataTable GetDataD6(String SCT)
        {
            _conn = ConnectSql.getConnect();
            SqlCommand cmd = new SqlCommand("SELECT B.MAVT, D.TENVT, B.SOLUONG, B.GIABAN2 AS TEMGIA,A.DGIAI AS DIENGIAI"
                                                + " FROM NHAPXUAT A"
                                                     +" JOIN dbo.NHAPXUAT_CT B ON B.KHOA = A.KHOA AND B.LOC = A.LOC"
                                                     +" JOIN dbo.DM_HH_CT C ON C.MABH = B.MAVT"
                                                     +" JOIN dbo.DM_HH D ON D.MAVT = C.MAVT"
                                                +" WHERE A.LCT = 'CKHO' AND A.MAKHO2 = 43 AND A.SCT = @SCT"
                                                +" ORDER BY B.MAVT ", _conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@SCT", SqlDbType.NVarChar);
            cmd.Parameters["@SCT"].Value = SCT;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
