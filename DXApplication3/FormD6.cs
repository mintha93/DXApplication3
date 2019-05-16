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
using DXApplication3.BUS;
using System.Data.Common;
using System.Data.OleDb;
using DXApplication3;

namespace BarcodeLabel
{
    public partial class FormD6 : DevExpress.XtraEditors.XtraForm
    {
        clBUS _BUS = new clBUS();
        string addressFile;
        string userNameFrmD6 = "";
        string SCT_FrmD6 = "";
        int priorityFrmD6 = 0;
        int SoReport_FrmD6;
        public FormD6()
        {
            InitializeComponent();
        }
        private void teSearchSCTD6_EditValueChanged(object sender, EventArgs e)
        {
            gCtrlD6.DataSource = _BUS.GetDataD6(teSearchSCT.EditValue.ToString());
            teDgiai.EditValue = grvD6.GetRowCellDisplayText(0,"DIENGIAI");
            SoReport_FrmD6 = 6;
        }
        private void teSearchSCTD6_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }
        private void FormD6_Load(object sender, EventArgs e)
        {
            grvD6.Columns[4].Visible = false;
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
                gCtrlD6.DataSource = tblImport;
                if (tblImport.Rows.Count > 0)
                {
                    DataTable dtall = new DataTable();
                    DataTable dttemp = new DataTable();
                    DataTable dttemp1 = new DataTable();
                    dtall = _BUS.GetdataTemle("2182307000766", (int)2, "2.5");
                    for (int i = 0; i < grvD6.DataRowCount; i++)
                    {
                        dttemp = _BUS.GetdataTemle(grvD6.GetRowCellValue(i, "MAVT").ToString(), Convert.ToInt32(grvD6.GetRowCellValue(i, "SOLUONG")), grvD6.GetRowCellValue(i, "TEMGIA").ToString());
                        dtall = dtall.AsEnumerable().Union(dttemp.AsEnumerable()).CopyToDataTable<DataRow>();
                    }
                    dtall.Rows.Remove(dtall.Rows[0]);
                    gCtrlD6.DataSource = dtall;
                    TEMGIA.SummaryItem.DisplayFormat = _BUS.getMultipleTotalTemle(grvD6);
                    SoReport_FrmD6 = 5;
                }
                else
                {
                    gCtrlD6.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Bạn phải chọn file excel");
            }
        }
        private void oFD_FileOk(object sender, CancelEventArgs e)
        {
            addressFile = oFD.FileName;
            List<string> sheets = getListSheet(addressFile);
        }

        public void PassvaluefromForm2(string userName, int priority)
        {
            userNameFrmD6 = userName;
            priorityFrmD6 = priority;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                if(SoReport_FrmD6==5)
                {
                    String KHOA = _BUS.getMaxKhoaTemLe();
                    _BUS.Insertlabel_temle(KHOA, userNameFrmD6);
                    for (int i = 0; i < grvD6.DataRowCount; i++)
                    {
                        _BUS.InsertLabel_temle_detail(KHOA, grvD6.GetRowCellDisplayText(i, "MAVT"),
                            Convert.ToInt32(grvD6.GetRowCellValue(i, "SOLUONG")), Convert.ToDouble(grvD6.GetRowCellValue(i, "TEMGIA")), "VND");
                    }
                    Form1 form1 = new Form1();
                    form1.PassvaluefromFormD6("",KHOA, SoReport_FrmD6, userNameFrmD6, priorityFrmD6);
                    form1.Show();
                    this.Hide();
                }
                else if (SoReport_FrmD6 == 6)
                {
                    SCT_FrmD6 = teSearchSCT.EditValue.ToString();
                    Form1 form1 = new Form1();
                    form1.PassvaluefromFormD6(SCT_FrmD6, "", SoReport_FrmD6, userNameFrmD6, priorityFrmD6);
                    form1.Show();
                    this.Hide();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}