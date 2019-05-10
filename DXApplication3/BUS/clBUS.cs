using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DXApplication3.DAL;

namespace DXApplication3.BUS
{
    class clBUS
    {
        clDAL _DAL = new clDAL();
        public DataTable getVCNB(String Date1, String Date2)
        {
            return _DAL.getVCNB(Date1, Date2);
        }
        public DataTable getVCNB_Search(String SCT, String Date1, String Date2)
        {
            return _DAL.getVCNB_Search(SCT, Date1, Date2);
        }
        public DataTable GET_VCNB_APP_DETAIL(String SCT)
        {
            return _DAL.GET_VCNB_APP_DETAIL(SCT);
        }
        public String GET_Password(String Username)
        {
            return _DAL.GET_Password(Username);
        }
        public string CreateMD5(string input)
        {
            return _DAL.CreateMD5(input);
        }
        public void InsertLabelNhapxuat(String SCT,String userName)
        {
            _DAL.InsertLabelNhapxuat(SCT,userName);
        }
        public void Unlockphieu(String SCT)
        {
            _DAL.Unlockphieu(SCT);
        }
        public DataTable GetdataTemle(String MAVT, Int32 Soluong, String Temgia)
        {
            return _DAL.GetdataTemle(MAVT, Soluong, Temgia);
        }
        public String getMaxKhoaTemLe()
        {
            return _DAL.getMaxKhoaTemLe();
        }
        public void Insertlabel_temle(String KHOA, String userName)
        {
            _DAL.Insertlabel_temle(KHOA, userName);
        }
        public void InsertLabel_temle_detail(String KHOA, String MAVT, Int32 SOLUONG, Double Temgia, String Currency)
        {
            _DAL.InsertLabel_temle_detail(KHOA, MAVT, SOLUONG, Temgia, Currency);
        }
        public void deleteTemle(String KHOA)
        {
            _DAL.deleteTemle(KHOA);
        }
            public String getMultipleTotal(GridView gridView)
        {
            return _DAL.getMultipleTotal(gridView);
        }
        public String getMultipleTotalTemle(GridView gridView)
        {
            return _DAL.getMultipleTotalTemle(gridView);
        }
        public String TestNull(string s)
        {
            return _DAL.TestNull(s);
        }
        public string getPath(int value)
        {
            return _DAL.getPath(value);
        }
        public int getPriorityFromFileText(String userName,String passWord)
        {
            String line3 = _DAL.getPath(2);
            String line4 = _DAL.getPath(3);
            if (line3.Substring(0, line3.IndexOf('/') ).Trim() == userName && line3.Substring(line3.IndexOf('/') + 1, line3.Length - line3.IndexOf('/') -1 ).Trim() == passWord)
                return 1;
            else if (line4.Substring(0, line4.IndexOf('/')).Trim() == userName && line4.Substring(line4.IndexOf('/') + 1, line4.Length - line4.IndexOf('/') -1).Trim() == passWord)
                return 2;
            else
                return 3;
        }
        public String getuserNameFromFileText(int temp)
        {
            String line3 = _DAL.getPath(2);
            String line4 = _DAL.getPath(3);
            if (temp==1)
                return line3.Substring(0, line3.IndexOf('/'));
            else if (temp == 2)
                return line3.Substring(line3.IndexOf('/') + 1 , line3.Length - line3.IndexOf('/')-1);
            else
                return "";
        }

        public DataTable GetDataD6(String SCT)
        {
            return _DAL.GetDataD6(SCT);
        }
        }
}
