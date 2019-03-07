using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
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
        string SCT;
        int Makho2 = 1;
        int Soreport;
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                reportDocument.Load(@"" + Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 9) + GetReportName(Soreport));
                reportDocument.SetDatabaseLogon("sa", "SQL@123@", "192.168.68.252", "DUYANH", false);
                if (Soreport == 1)
                {
                    reportDocument.SetParameterValue("@SCT", SCT);
                    reportDocument.SetParameterValue("@MAKHO2", Makho2);
                }
                else if (Soreport == 2)
                {
                    reportDocument.SetParameterValue("@KHOA", Makho2);
                    reportDocument.SetParameterValue("@CURRENCY", SCT);
                }
                crystalReportViewer1.ReportSource = reportDocument;
                crystalReportViewer1.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
            //    MessageBox.Show(SCT+","+Makho2.ToString()+"," +Soreport.ToString());
                ConnectionInfo crconnectioninfo = new ConnectionInfo();
                TableLogOnInfos crtablelogoninfos = new TableLogOnInfos();
                TableLogOnInfo crtablelogoninfo = new TableLogOnInfo();
                reportDocument.Load(@"" + Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 9) + GetReportName(Soreport));
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
                    reportDocument.Load(@""+ Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 9)+GetReportName(Soreport));
                    reportDocument.SetDatabaseLogon("sa", "SQL@123@", "192.168.68.252", "DUYANH", false);
                    if (Soreport == 1)
                    {
                        reportDocument.SetParameterValue("@SCT", SCT);
                        reportDocument.SetParameterValue("@MAKHO2", Makho2);
                    }
                    else if (Soreport == 2)
                    {
                        reportDocument.SetParameterValue("@KHOA", Makho2);
                        reportDocument.SetParameterValue("@CURRENCY", SCT);
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
        public void PassvaluefromForm2(string SCT_Frm2, int Makho_Frm2, int SoReport_Frm2)
        {
            SCT = SCT_Frm2.ToString();
            Makho2 = Makho_Frm2;
            Soreport = SoReport_Frm2;
        }
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                _BUS.InsertLabelNhapxuat(SCT);
                crystalReportViewer1.PrintReport();
                this.Hide();
                Form2 frm2 = new Form2();
                frm2.Show();
            }
            catch
            {
                MessageBox.Show("Phiếu đã in");
            }
        }

        private void Form1Closing(object sender, FormClosingEventArgs e)
        {
            if (Soreport == 1)
            {
                this.Hide();
                e.Cancel = true;
                Form2 frm2 = new Form2();
                frm2.Show();
            }
            else if (Soreport ==2)
            {
                _BUS.deleteTemle(Makho2.ToString());
                this.Hide();
                e.Cancel = true;
                Form2 frm2 = new Form2();
                frm2.Show();
            }
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            _BUS.Unlockphieu(SCT);
            MessageBox.Show("Đã mở khóa phiếu!");
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
                reportName = "BarcodeReport_Temle.rpt";
            }
            else reportName = "abc";
            return reportName;


       }
    }
}
