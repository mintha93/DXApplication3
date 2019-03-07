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
        string addressFile;
        int SoReport_Frm3 = 2;

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
                if (listBoxTemle.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn shop");
                }
                else
                {
                    oFD.Filter = "Tất Cả Các File |*.*|Excel 2003 Files |*.xls|Excel 2007 File|*.xlsx";
                    oFD.FileName = "";
                    oFD.ShowDialog();
                    string connec = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""", addressFile);
                    string query = string.Format("Select * from [{0}]", "Sheet1$");
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connec);
                    DataTable tblImport = new DataTable();
                    adapter.Fill(tblImport);
                    if (tblImport.Rows.Count > 0)
                    {
                        String tenkho = listBoxTemle.SelectedValue.ToString();
                        String makho = tenkho.Substring(tenkho.Length - 3, 2);
                        gCtrlTemle.DataSource = tblImport;
                        DataTable dtall = new DataTable();
                        DataTable dttemp = new DataTable();
                        for (int i = 0; i < grvTemle.DataRowCount; i++)
                        {
                            dttemp = _BUS.GetdataTemle(grvTemle.GetRowCellValue(i, "MAVT").ToString(), makho, Convert.ToInt32(grvTemle.GetRowCellValue(i, "SOLUONG")));
                            dtall.Merge(dttemp);
                        }
                        gCtrlTemle.DataSource = dtall;
                       GIABANVND.SummaryItem.DisplayFormat = _BUS.getMultipleTotalVND(grvTemle);
                       GIABANUSD.SummaryItem.DisplayFormat = _BUS.getMultipleTotalUSD(grvTemle);
                    }
                    else
                    {
                        gCtrlTemle.DataSource = null;
                    }
                }
            }
            catch
            {
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
                else
                {
                    Double Curval_detail = _BUS.getCurval_Temle_Detail();
                    _BUS.Insertlabel_temle(_BUS.getCurval_Temle() + 1.0, listBoxTemle.SelectedValue.ToString(), DateTime.Now);
                    for (int i = 0; i < grvTemle.DataRowCount; i++)
                    {
                        _BUS.InsertLabel_temle_detail(Curval_detail + 1.0 + i, grvTemle.GetRowCellDisplayText(i, "MAVT"),
                            Convert.ToInt32(grvTemle.GetRowCellValue(i, "SOLUONG")), grvTemle.GetRowCellValue(i, "GIABAN_VND").ToString()
                            , grvTemle.GetRowCellValue(i, "GIABAN_NT").ToString(), _BUS.getCurval_Temle() + 1.0);
                    }
                    _BUS.updateSys_sequence_temle();
                    _BUS.updateSys_sequence_temle_detail((grvTemle.DataRowCount + Convert.ToInt32(Curval_detail)).ToString());
                    Form1 form1 = new Form1();
                    form1.PassvaluefromForm2(radioTemle.SelectedIndex.ToString(), Convert.ToInt32(_BUS.getCurval_Temle()), SoReport_Frm3);
                    form1.Show();
                    this.Hide();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void listBoxTemle_SelectedIndexChanged(object sender, EventArgs e)
        {
            String tenkho = listBoxTemle.SelectedValue.ToString();
            String makho = tenkho.Substring(tenkho.Length - 3, 2);
            DataTable dtall = new DataTable();
            DataTable dttemp = new DataTable();
            for (int i = 0; i < grvTemle.DataRowCount; i++)
            {
                dttemp = _BUS.GetdataTemle(grvTemle.GetRowCellValue(i, "MAVT").ToString(), makho, Convert.ToInt16(grvTemle.GetRowCellValue(i, "SOLUONG")));
                dtall.Merge(dttemp);

            }
            gCtrlTemle.DataSource = dtall;
            GIABANVND.SummaryItem.DisplayFormat = _BUS.getMultipleTotalVND(grvTemle);
            GIABANUSD.SummaryItem.DisplayFormat = _BUS.getMultipleTotalUSD(grvTemle);
        }
        private void Form3_Closing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Form2 frm2 = new Form2();
            frm2.Show();
        }

    }
}