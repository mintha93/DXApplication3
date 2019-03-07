using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DXApplication3.DTO;
namespace DXApplication3.DAL
{
    class clDAL
    {
        SqlConnection _conn = null;
        //string addressFile;
        public void InsertLabelNhapxuat( String SCT)
        {
                _conn = ConnectSql.getConnect();
                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.LABEL_NHAPXUAT SELECT SCT,1,NGAY,SOLUONG FROM NHAPXUAT WHERE SCT = @SCT", _conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@SCT", SCT);
                cmd.ExecuteNonQuery();     
        }
        public void Unlockphieu(String SCT)
        {
            _conn = ConnectSql.getConnect();
            SqlCommand cmd = new SqlCommand("DELETE dbo.LABEL_NHAPXUAT WHERE SCT = @SCT", _conn);
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
        public DataTable GetdataTemle(String MAVT, String Makho, Int32 Soluong)
        {
            _conn = ConnectSql.getConnect();
            SqlCommand cmd = new SqlCommand("GET_VCNB_APP_TEMLE", _conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MAVT", SqlDbType.NVarChar);
            cmd.Parameters["@MAVT"].Value = MAVT;
            cmd.Parameters.Add("@MAKHO", SqlDbType.NVarChar);
            cmd.Parameters["@MAKHO"].Value = Makho;
            cmd.Parameters.Add("@SOLUONG", SqlDbType.Int);
            cmd.Parameters["@SOLUONG"].Value = Soluong;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public Double getCurval_Temle()
        {
            _conn = ConnectSql.getConnect();
            SqlCommand Command = new SqlCommand();
            Command = _conn.CreateCommand();
            Command.CommandText = @"SELECT SEQ_CURVAL FROM SYS_SEQUENCE WHERE SEQ_NAME = 'LABEL_TEMLE'";
            Double Curval = (Double)Command.ExecuteScalar();
            return Curval;
        }
        public Double getCurval_Temle_Detail()
        {
            _conn = ConnectSql.getConnect();
            SqlCommand Command = new SqlCommand();
            Command = _conn.CreateCommand();
            Command.CommandText = @"SELECT SEQ_CURVAL FROM SYS_SEQUENCE WHERE SEQ_NAME = 'LABEL_TEMLE_DETAIL'";
            Double Curval = (Double)Command.ExecuteScalar();
            return Curval;
        }
        public void Insertlabel_temle(Double KHOA,String Kho,DateTime Ngay)
        {
            _conn = ConnectSql.getConnect();
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.LABEL_TEMLE " +
                "VALUES (@KHOA,@KHO,@NGAY)", _conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@KHOA", KHOA);
            cmd.Parameters.AddWithValue("@KHO", Kho);
            cmd.Parameters.AddWithValue("@NGAY", Ngay);
            cmd.ExecuteNonQuery();
        }
        public void InsertLabel_temle_detail(Double KHOA_CT, String MAVT, Int32 SOLUONG, String GIABANVND, String GIABANUSD, Double KHOA_TEMLE)
        {
            _conn = ConnectSql.getConnect();
            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.LABEL_TEMLE_DETAIL (KHOA_CT,MAVT,SOLUONG,GIABANVND,GIABANUSD,KHOA_TEMLE)"+
                                            "VALUES  (@KHOA_CT,@MAVT,@SOLUONG,@GIABANVND,@GIABANUSD,@KHOA_TEMLE)", _conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@KHOA_CT", KHOA_CT);
            cmd.Parameters.AddWithValue("@MAVT", MAVT);
            cmd.Parameters.AddWithValue("@SOLUONG", SOLUONG);
            cmd.Parameters.AddWithValue("@GIABANVND", GIABANVND);
            cmd.Parameters.AddWithValue("@GIABANUSD", GIABANUSD);
            cmd.Parameters.AddWithValue("@KHOA_TEMLE", KHOA_TEMLE);
            cmd.ExecuteNonQuery();
        }
        public void updateSys_sequence_temle_detail(String Curval_detail)
        {
            _conn = ConnectSql.getConnect();
            SqlCommand Command = new SqlCommand();
            Command = _conn.CreateCommand();
            Command.CommandText = @"UPDATE SYS_SEQUENCE SET SEQ_CURVAL = '" + Curval_detail + "' WHERE SEQ_NAME = 'LABEL_TEMLE_DETAIL'";

            Command.ExecuteNonQuery();
        }
        public void updateSys_sequence_temle()
        {
            _conn = ConnectSql.getConnect();
            SqlCommand Command = new SqlCommand();
            Command = _conn.CreateCommand();
            Command.CommandText = @"UPDATE SYS_SEQUENCE SET SEQ_CURVAL = SEQ_CURVAL + 1 WHERE SEQ_NAME = 'LABEL_TEMLE'";

            Command.ExecuteNonQuery();
        }
        public void deleteTemle(String KHOA)
        {
            _conn = ConnectSql.getConnect();
            SqlCommand cmd = new SqlCommand("DELETE dbo.LABEL_TEMLE WHERE KHOA = @KHOA" +
                "  UPDATE SYS_SEQUENCE SET SEQ_CURVAL = @KHOA -1  WHERE SEQ_NAME = 'LABEL_TEMLE'" +
                "  UPDATE SYS_SEQUENCE SET SEQ_CURVAL = (SELECT MAX(KHOA_CT) FROM LABEL_TEMLE_DETAIL WHERE KHOA_TEMLE = @KHOA -1)" +
                "  WHERE SEQ_NAME = 'LABEL_TEMLE_DETAIL'", _conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@KHOA", KHOA);
            cmd.ExecuteNonQuery();
        }
        public String getMultipleTotalVND(GridView gridView)
        {
            Double totalVND = 0;
            for (int i = 0; i < gridView.DataRowCount; i++)
            {
                totalVND = totalVND + Convert.ToDouble(gridView.GetRowCellValue(i, "SOLUONG")) * Convert.ToDouble(TestNull(gridView.GetRowCellValue(i, "GIABAN_VND").ToString()));
            }
            return totalVND.ToString();

        }
        public String getMultipleTotalUSD(GridView gridView)
        {
            Double totalUSD = 0;
            for (int i = 0; i < gridView.DataRowCount; i++)
            {
                totalUSD = totalUSD + Convert.ToDouble(gridView.GetRowCellValue(i, "SOLUONG")) * (Convert.ToDouble(TestNull(gridView.GetRowCellValue(i, "GIABAN_NT").ToString())));
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

    }
}
