namespace DXApplication3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.barcodeReport1 = new DXApplication3.BarcodeReport();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnUnlock = new DevExpress.XtraEditors.SimpleButton();
            this.lblSCT = new DevExpress.XtraEditors.LabelControl();
            this.lblSochungtu = new DevExpress.XtraEditors.LabelControl();
            this.sidePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sidePanel1.Controls.Add(this.crystalReportViewer1);
            this.sidePanel1.Location = new System.Drawing.Point(1, 75);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(846, 325);
            this.sidePanel1.TabIndex = 1;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.ForeColor = System.Drawing.Color.Black;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowPrintButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(846, 325);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 31);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(41, 38);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // btnUnlock
            // 
            this.btnUnlock.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUnlock.ImageOptions.Image")));
            this.btnUnlock.Location = new System.Drawing.Point(69, 31);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(41, 38);
            this.btnUnlock.TabIndex = 5;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click_1);
            // 
            // lblSCT
            // 
            this.lblSCT.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSCT.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblSCT.Appearance.Options.UseFont = true;
            this.lblSCT.Appearance.Options.UseForeColor = true;
            this.lblSCT.Location = new System.Drawing.Point(228, 12);
            this.lblSCT.LookAndFeel.SkinName = "Money Twins";
            this.lblSCT.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lblSCT.Name = "lblSCT";
            this.lblSCT.Size = new System.Drawing.Size(103, 22);
            this.lblSCT.TabIndex = 12;
            this.lblSCT.Text = "Số chứng từ:";
            // 
            // lblSochungtu
            // 
            this.lblSochungtu.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSochungtu.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblSochungtu.Appearance.Options.UseFont = true;
            this.lblSochungtu.Appearance.Options.UseForeColor = true;
            this.lblSochungtu.Location = new System.Drawing.Point(373, 12);
            this.lblSochungtu.LookAndFeel.SkinName = "Money Twins";
            this.lblSochungtu.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lblSochungtu.Name = "lblSochungtu";
            this.lblSochungtu.Size = new System.Drawing.Size(0, 22);
            this.lblSochungtu.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 427);
            this.Controls.Add(this.lblSochungtu);
            this.Controls.Add(this.lblSCT);
            this.Controls.Add(this.btnUnlock);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.sidePanel1);
            this.LookAndFeel.SkinName = "Money Twins";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidePanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private BarcodeReport barcodeReport1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnUnlock;
        private DevExpress.XtraEditors.LabelControl lblSCT;
        private DevExpress.XtraEditors.LabelControl lblSochungtu;
    }
}

