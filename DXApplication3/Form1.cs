using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using DXApplication3.BUS;
namespace DXApplication3
{

    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        ReportDocument reportDocument = new ReportDocument();
        ParameterField parameterField = new ParameterField();
        ParameterFields parameterFields = new ParameterFields();
        ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();
        clBUS _BUS = new clBUS();
        String SCT_Frm1;
        String khoaTemLe_Frm1;
        String Currency_Frm1;
        String userName_Frm1;
        int Makho_Frm1 = 1;
        int Soreport_Frm1;
        int priority_Frm1;
        public Form1()
        {
            InitializeComponent();
        }

        //private void simpleButton1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        reportDocument.Load(_BUS.getPath(0) + GetReportName(Soreport_Frm1));
        //        reportDocument.SetDatabaseLogon("sa", "SQL@123@", "192.168.68.252", "DUYANH", false);
        //        if (Soreport_Frm1 == 1)
        //        {
        //            reportDocument.SetParameterValue("@SCT", SCT_Frm1);
        //            reportDocument.SetParameterValue("@MAKHO2", Makho_Frm1);
        //        }
        //        else if (Soreport_Frm1 == 2)
        //        {
        //            reportDocument.SetParameterValue("@KHOA", khoaTemLe_Frm1);
        //            reportDocument.SetParameterValue("@CURRENCY", Currency_Frm1);
        //        }
        //        crystalReportViewer1.ReportSource = reportDocument;
        //        crystalReportViewer1.Refresh();

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ConnectionInfo crconnectioninfo = new ConnectionInfo();
                TableLogOnInfos crtablelogoninfos = new TableLogOnInfos();
                TableLogOnInfo crtablelogoninfo = new TableLogOnInfo();
                lblSochungtu.Text = SCT_Frm1;
                reportDocument.Load(@""+ _BUS.getPath(0) + GetReportName(Soreport_Frm1));
                Tables CrTables;
                crconnectioninfo.ServerName = "192.168.68.252";
                crconnectioninfo.DatabaseName = "DUYANH";
                crconnectioninfo.UserID = "sa";
                crconnectioninfo.Password = "SQL@123@";
                CrTables = reportDocument.Database.Tables;

                foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
                {
                    crtablelogoninfo = CrTable.LogOnInfo;
                    crtablelogoninfo.ConnectionInfo = crconnectioninfo;
                    CrTable.ApplyLogOnInfo(crtablelogoninfo);
                }
                try
                {
                    reportDocument.Load(@""+ _BUS.getPath(0) + GetReportName(Soreport_Frm1));
                    reportDocument.SetDatabaseLogon("sa", "SQL@123@", "192.168.68.252", "DUYANH", false);
                    if (Soreport_Frm1 == 1)
                    {
                        reportDocument.SetParameterValue("@SCT", SCT_Frm1);
                        reportDocument.SetParameterValue("@MAKHO2", Makho_Frm1);
                    }
                    else if (Soreport_Frm1 == 2)
                    {
                        reportDocument.SetParameterValue("@KHOA", khoaTemLe_Frm1);
                        reportDocument.SetParameterValue("@CURRENCY", Currency_Frm1);
                    }
                    crystalReportViewer1.ReportSource = reportDocument;
                    crystalReportViewer1.Refresh();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Soreport_Frm1 == 1)
                {
                    _BUS.InsertLabelNhapxuat(SCT_Frm1,userName_Frm1);
                    crystalReportViewer1.PrintReport();
                    this.Hide();
                }
                else if (Soreport_Frm1 ==2)
                {
                    crystalReportViewer1.PrintReport();
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Phiếu đã in");
            }
        }

        private void Form1Closing(object sender, FormClosingEventArgs e)
        {
            if (Soreport_Frm1 == 1)
            {
                this.Hide();
                e.Cancel = true;
            }
            else if (Soreport_Frm1 == 2)
            {
                _BUS.deleteTemle(khoaTemLe_Frm1);
                this.Hide();
                e.Cancel = true;
            }
        }
        private string GetReportName(int Soreport)
       {
            String reportName = "";
            if (Soreport == 1)
            {
                reportName = "BarcodeReport.rpt";
            }
            else if  (Soreport == 2)
            {
                reportName = "BarcodeReport - Temle.rpt";
            }
            else reportName = "abc";
            return reportName;
       }
        private void btnUnlock_Click_1(object sender, EventArgs e)
        {
            if(priority_Frm1==1)
            {
                MessageBox.Show("Bạn không có quyền mở khóa phiếu");
            }
            else if(priority_Frm1==2)
            {
                try
                {
                    _BUS.Unlockphieu(SCT_Frm1);
                    MessageBox.Show("Mở khóa phiếu thành công");
                }
                catch
                {
                    MessageBox.Show("Phiếu này đã mở khóa");
                }
            }
        }
        public void PassvaluefromForm2(string SCT_Frm2, int Makho_Frm2, int SoReport_Frm2, string userName_Frm2, int priority_Frm2)
        {
            SCT_Frm1 = SCT_Frm2.ToString();
            Makho_Frm1 = Makho_Frm2;
            Soreport_Frm1 = SoReport_Frm2;
            userName_Frm1 = userName_Frm2;
            priority_Frm1 = priority_Frm2;
        }
        public void PassvaluefromForm3(string khoa, String currency, int soReport, string userName, int priority)
        {
            khoaTemLe_Frm1 = khoa;
            Currency_Frm1 = currency;
            Soreport_Frm1 = soReport;
            userName_Frm1 = userName;
            priority_Frm1 = priority;
        }
    }
}
