using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.OleDb;
using DXApplication3.BUS;
using System.Data.Common;
using System.IO;

namespace DXApplication3
{
    public partial class Form3 : DevExpress.XtraEditors.XtraForm
    {
        clBUS _BUS = new clBUS();
        string userNameFrm3 = "";
        int priorityFrm3;
        string addressFile;
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            grvTemle.AddNewRow();
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                    oFD.Filter = "Tất Cả Các File |*.*|Excel 2003 Files |*.xls|Excel 2007 File|*.xlsx";
                    oFD.FileName = "";
                    oFD.ShowDialog();
                    string connec = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""", addressFile);
                    string query = string.Format("Select * from [{0}]", "Sheet1$");
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connec);
                    DataTable tblImport = new DataTable();
                    adapter.Fill(tblImport);
                gCtrlTemle.DataSource = tblImport;
                if (tblImport.Rows.Count > 0)
                {
                    DataTable dtall = new DataTable();
                    DataTable dttemp = new DataTable();
                    DataTable dttemp1 = new DataTable();
                    dtall = _BUS.GetdataTemle("2181502000847", (int)2, "2.5");
                    for (int i = 0; i < grvTemle.DataRowCount; i++)
                    {
                        dttemp = _BUS.GetdataTemle(grvTemle.GetRowCellValue(i, "MAVT").ToString(), Convert.ToInt32(grvTemle.GetRowCellValue(i, "SOLUONG")), grvTemle.GetRowCellValue(i, "TEMGIA").ToString());
                        dtall = dtall.AsEnumerable().Union(dttemp.AsEnumerable()).CopyToDataTable<DataRow>();
                    }
                    dtall.Rows.Remove(dtall.Rows[0]);
                    gCtrlTemle.DataSource = dtall;
                    TEMGIA.SummaryItem.DisplayFormat = _BUS.getMultipleTotalTemle(grvTemle);
                }
                else
                {
                    gCtrlTemle.DataSource = null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Bạn phải chọn file excel");
            }
        }
        private List<string> getListSheet(string urlFile)
        {
            try
            {
                List<string> sheets = new List<string>();
                string connec = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""", urlFile);
                DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.OleDb");
                DbConnection connection = factory.CreateConnection();
                connection.ConnectionString = connec;
                connection.Open();
                DataTable dt = connection.GetSchema("Tables");
                connection.Close();
                foreach (DataRow row in dt.Rows)
                {
                    string sheetnames = (string)row["TABLE_NAME"];
                    sheets.Add(sheetnames);
                }
                return sheets;

            }
            catch (Exception)
            {
                return null;
            }
        }
        private void oFD_FileOk(object sender, CancelEventArgs e)
        {
            addressFile = oFD.FileName;
            List<string> sheets = getListSheet(addressFile);
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioTemle.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn loại tiền tệ");
                }
                else if (radioTemle.SelectedIndex == 0)
                {
                    String KHOA = _BUS.getMaxKhoaTemLe();
                    String Currency = radioTemle.Properties.Items[radioTemle.SelectedIndex].Description;
                    _BUS.Insertlabel_temle(KHOA, userNameFrm3);
                    for (int i = 0; i < grvTemle.DataRowCount; i++)
                    {
                        _BUS.InsertLabel_temle_detail(KHOA, grvTemle.GetRowCellDisplayText(i, "MAVT"),
                            Convert.ToInt32(grvTemle.GetRowCellValue(i, "SOLUONG")), Convert.ToDouble(grvTemle.GetRowCellValue(i, "TEMGIA")), Currency);
                    }
                    Form1 form1 = new Form1();
                    form1.PassvaluefromForm3(KHOA, Currency, 4, userNameFrm3, priorityFrm3);
                    form1.Show();
                    this.Hide();

                }
                else if (radioTemle.SelectedIndex == 1)
                {
                    String KHOA = _BUS.getMaxKhoaTemLe();
                    String Currency = radioTemle.Properties.Items[radioTemle.SelectedIndex].Description;
                    _BUS.Insertlabel_temle(KHOA, userNameFrm3);
                    for (int i = 0; i < grvTemle.DataRowCount; i++)
                    {
                        _BUS.InsertLabel_temle_detail(KHOA, grvTemle.GetRowCellDisplayText(i, "MAVT"),
                            Convert.ToInt32(grvTemle.GetRowCellValue(i, "SOLUONG")), Convert.ToDouble(grvTemle.GetRowCellValue(i, "TEMGIA")), Currency);
                    }
                    Form1 form1 = new Form1();
                    form1.PassvaluefromForm3(KHOA, Currency, 3, userNameFrm3, priorityFrm3);
                    form1.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form3_Closing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
        public void PassvaluefromForm2(string userName, int priority)
        {
            userNameFrm3 = userName;
            priorityFrm3 = priority;
        }
    }
}