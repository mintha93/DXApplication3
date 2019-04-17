using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DXApplication3.BUS;

namespace DXApplication3
{
    public partial class Form2 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        int SoReport_Frm2 = 0;
        string SCT_Frm2 = "";
        int Makho_Frm2 = 0;
        string userName_frm2;
        int priority_frm2;
        clBUS _BUS = new clBUS();
        public Form2()
        {
            InitializeComponent();
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                gctrlDSach.DataSource = _BUS.getVCNB(dEdatefrom.DateTime.Date.ToString("yyyy/MM/dd"), dEdateto.DateTime.Date.ToString("yyyy/MM/dd"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dEdateto_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                gctrlDSach.DataSource = _BUS.getVCNB(dEdatefrom.DateTime.Date.ToString("yyyy/MM/dd"), dEdateto.DateTime.Date.ToString("yyyy/MM/dd"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabControl_SelectedPageChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTabPageIndex == 1)
            {
                tabControl.SelectedTabPage = tabPageDT;
                gctrlDetail.DataSource = _BUS.GET_VCNB_APP_DETAIL(grvDSach.GetFocusedRowCellDisplayText("SCT"));
                GIABAN_VND.SummaryItem.DisplayFormat = _BUS.getMultipleTotalVND(grvDetail);
                GIABAN_NT.SummaryItem.DisplayFormat = _BUS.getMultipleTotalUSD(grvDetail);
            }
            else if (tabControl.SelectedTabPageIndex == 0)
            {
            }
        }

        private void grvDSach_FocusedRowChanged(object sender, EventArgs e)
        {
            try
            {
                teSCT.EditValue = grvDSach.GetFocusedRowCellValue("SCT").ToString();
                teKhoxuat.EditValue = grvDSach.GetFocusedRowCellValue("TENKHO").ToString();
                teKhonhap.EditValue = grvDSach.GetFocusedRowCellValue("TENKHO2").ToString();
            }
            catch
            {

            }
        }
        private void grvDSach_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                gctrlDetail.DataSource = _BUS.GET_VCNB_APP_DETAIL(grvDSach.GetFocusedRowCellDisplayText("SCT"));
                tabControl.SelectedTabPage = tabPageDT;
                GIABAN_VND.SummaryItem.DisplayFormat = _BUS.getMultipleTotalVND(grvDetail);
                GIABAN_NT.SummaryItem.DisplayFormat = _BUS.getMultipleTotalUSD(grvDetail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void teSearchSCT_EditValueChanged(object sender, EventArgs e)
        {
            gctrlDSach.DataSource = _BUS.getVCNB_Search(teSearchSCT.EditValue.ToString(), dEdatefrom.DateTime.Date.ToString("yyyy/MM/dd"), dEdateto.DateTime.Date.ToString("yyyy/MM/dd"));
            tabControl.SelectedTabPage = tabPageDS;
        }
        private void Form2_Closing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                dEdateto.EditValue = DateTime.Now;
                dEdatefrom.EditValue = DateTime.Now.AddDays(-10);
                gctrlDSach.DataSource = _BUS.getVCNB(dEdatefrom.DateTime.Date.ToString("yyyy/MM/dd"), dEdateto.DateTime.Date.ToString("yyyy/MM/dd"));
                grvDSach.Columns[4].Visible = false;
                grvDSach.Columns[6].Visible = false;
                GIABAN_VND.SummaryItem.DisplayFormat = _BUS.getMultipleTotalVND(grvDetail);
                GIABAN_NT.SummaryItem.DisplayFormat = _BUS.getMultipleTotalUSD(grvDetail);
                lblWelcome.Text = "Hi "+userName_frm2+" !";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grvDSach_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string category = View.GetRowCellDisplayText(e.RowHandle, View.Columns["DONE"]);
                if (category == "Checked")
                {
                    e.Appearance.BackColor = Color.Salmon;
                    e.HighPriority = true;
                }
                else if (category == "Unchecked")
                {
                    e.Appearance.BackColor = Color.LightGreen;
                    e.HighPriority = true;
                }
            }
        }

        private void btnIntemle(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.PassvaluefromForm2(userName_frm2, priority_frm2);
            form3.Show();
        }
        private void barbtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Environment.Exit(0);
        }

    

        private void grvDSach_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            teSCT.EditValue = grvDSach.GetFocusedRowCellDisplayText("SCT");
            teKhoxuat.EditValue = grvDSach.GetFocusedRowCellDisplayText("TENKHO");
            teKhonhap.EditValue = grvDSach.GetFocusedRowCellDisplayText("TENKHO2");

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                SoReport_Frm2 = 1;
                SCT_Frm2 = grvDSach.GetFocusedRowCellDisplayText("SCT");
                Makho_Frm2 = Convert.ToInt16(grvDSach.GetFocusedRowCellDisplayText("MAKHO2"));
                Form1 form1 = new Form1();
                form1.PassvaluefromForm2(SCT_Frm2, Makho_Frm2, SoReport_Frm2,userName_frm2,priority_frm2);
                form1.Show();
                //this.Hide();
            }
            catch (Exception)
            {

            }
        }
        private void PreviewKeyDown_gctrlDsach(object sender, PreviewKeyDownEventArgs e)
        {

            if (e.KeyCode == Keys.F5)
            {
                try
                {
                    gctrlDSach.DataSource = _BUS.getVCNB(dEdatefrom.DateTime.Date.ToString("yyyy/MM/dd"), dEdateto.DateTime.Date.ToString("yyyy/MM/dd"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void PreviewKeyDown_Form2(object sender, PreviewKeyDownEventArgs e)
        {

            if (e.KeyCode == Keys.F5)
            {
                try
                {
                    gctrlDSach.DataSource = _BUS.getVCNB(dEdatefrom.DateTime.Date.ToString("yyyy/MM/dd"), dEdateto.DateTime.Date.ToString("yyyy/MM/dd"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        public void PassvaluefromFormLogin(string userName, int priority)
        {
            userName_frm2 = userName;
            priority_frm2 = priority;
        }
    }
}
