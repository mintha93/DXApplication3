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
        public void InsertLabelNhapxuat(String SCT)
        {
            _DAL.InsertLabelNhapxuat(SCT);
        }
        public void Unlockphieu(String SCT)
        {
            _DAL.Unlockphieu(SCT);
        }
        public DataTable GetdataTemle(String MAVT, String Makho, Int32 Soluong)
        {
            return _DAL.GetdataTemle(MAVT, Makho, Soluong);
        }
        public Double getCurval_Temle()
        {
            return _DAL.getCurval_Temle();
        }
        public Double getCurval_Temle_Detail()
        {
            return _DAL.getCurval_Temle_Detail();
        }
        public void Insertlabel_temle(Double KHOA, String Kho, DateTime Ngay)
        {
            _DAL.Insertlabel_temle(KHOA, Kho, Ngay);
        }
        public void InsertLabel_temle_detail(Double KHOA_CT, String MAVT, Int32 SOLUONG, String GIABANVND, String GIABANUSD, Double KHOA_TEMLE)
        {
            _DAL.InsertLabel_temle_detail(KHOA_CT, MAVT, SOLUONG, GIABANVND, GIABANUSD, KHOA_TEMLE);
        }
        public void updateSys_sequence_temle_detail(String Curval_detail)
        {
            _DAL.updateSys_sequence_temle_detail(Curval_detail);
        }
        public void updateSys_sequence_temle()
        {
            _DAL.updateSys_sequence_temle();
        }
        public void deleteTemle(String KHOA)
        {
            _DAL.deleteTemle(KHOA);
        }
            public String getMultipleTotalVND(GridView gridView)
        {
            return _DAL.getMultipleTotalVND(gridView);
        }
        public String getMultipleTotalUSD(GridView gridView)
        {
            return _DAL.getMultipleTotalUSD(gridView);
        }
        public String TestNull(string s)
        {
            return _DAL.TestNull(s);
        } 
        }
}
