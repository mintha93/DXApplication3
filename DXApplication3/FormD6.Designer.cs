namespace BarcodeLabel
{
    partial class FormD6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormD6));
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.teDgiai = new DevExpress.XtraEditors.TextEdit();
            this.teSearchSCT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gCtrlD6 = new DevExpress.XtraGrid.GridControl();
            this.grvD6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEMGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIENGIAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.oFD = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teDgiai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSearchSCT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCtrlD6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvD6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.groupControl2);
            this.panel2.Controls.Add(this.btnPreview);
            this.panel2.Controls.Add(this.groupControl1);
            this.panel2.Location = new System.Drawing.Point(3, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 84);
            this.panel2.TabIndex = 3;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.teDgiai);
            this.groupControl2.Controls.Add(this.teSearchSCT);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Location = new System.Drawing.Point(372, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(431, 80);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "In theo phiếu";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(14, 55);
            this.labelControl3.LookAndFeel.SkinName = "Money Twins";
            this.labelControl3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 15);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Diễn giải:";
            // 
            // teDgiai
            // 
            this.teDgiai.Location = new System.Drawing.Point(124, 52);
            this.teDgiai.Name = "teDgiai";
            this.teDgiai.Size = new System.Drawing.Size(303, 20);
            this.teDgiai.TabIndex = 12;
            // 
            // teSearchSCT
            // 
            this.teSearchSCT.Location = new System.Drawing.Point(124, 26);
            this.teSearchSCT.Name = "teSearchSCT";
            this.teSearchSCT.Size = new System.Drawing.Size(210, 20);
            this.teSearchSCT.TabIndex = 11;
            this.teSearchSCT.EditValueChanged += new System.EventHandler(this.teSearchSCTD6_EditValueChanged);
            this.teSearchSCT.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.teSearchSCTD6_PreviewKeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(14, 26);
            this.labelControl2.LookAndFeel.SkinName = "McSkin";
            this.labelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(104, 18);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Nhập vào số phiếu";
            // 
            // btnPreview
            // 
            this.btnPreview.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPreview.ImageOptions.Image")));
            this.btnPreview.Location = new System.Drawing.Point(3, 3);
            this.btnPreview.LookAndFeel.SkinName = "Black";
            this.btnPreview.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(108, 80);
            this.btnPreview.TabIndex = 7;
            this.btnPreview.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.btnImport);
            this.groupControl1.Location = new System.Drawing.Point(117, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(249, 80);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "In tem lẻ";
            // 
            // btnImport
            // 
            this.btnImport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.ImageOptions.Image")));
            this.btnImport.Location = new System.Drawing.Point(5, 23);
            this.btnImport.LookAndFeel.SkinName = "Black";
            this.btnImport.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnImport.Name = "btnImport";
            this.btnImport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnImport.Size = new System.Drawing.Size(80, 36);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "Import";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gCtrlD6);
            this.panel1.Location = new System.Drawing.Point(3, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 362);
            this.panel1.TabIndex = 4;
            // 
            // gCtrlD6
            // 
            this.gCtrlD6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gCtrlD6.Location = new System.Drawing.Point(3, 3);
            this.gCtrlD6.LookAndFeel.SkinName = "Blue";
            this.gCtrlD6.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gCtrlD6.MainView = this.grvD6;
            this.gCtrlD6.Name = "gCtrlD6";
            this.gCtrlD6.Size = new System.Drawing.Size(798, 356);
            this.gCtrlD6.TabIndex = 0;
            this.gCtrlD6.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvD6});
            // 
            // grvD6
            // 
            this.grvD6.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grvD6.Appearance.FooterPanel.Options.UseFont = true;
            this.grvD6.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.grvD6.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvD6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAVT,
            this.TENVT,
            this.SOLUONG,
            this.TEMGIA,
            this.DIENGIAI});
            this.grvD6.CustomizationFormBounds = new System.Drawing.Rectangle(714, 466, 206, 170);
            this.grvD6.GridControl = this.gCtrlD6;
            this.grvD6.Name = "grvD6";
            this.grvD6.OptionsView.ColumnAutoWidth = false;
            this.grvD6.OptionsView.ShowFooter = true;
            // 
            // MAVT
            // 
            this.MAVT.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.MAVT.AppearanceHeader.Options.UseFont = true;
            this.MAVT.Caption = "MÃ VT";
            this.MAVT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.MAVT.FieldName = "MAVT";
            this.MAVT.Name = "MAVT";
            this.MAVT.Visible = true;
            this.MAVT.VisibleIndex = 0;
            this.MAVT.Width = 117;
            // 
            // TENVT
            // 
            this.TENVT.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.TENVT.AppearanceHeader.Options.UseFont = true;
            this.TENVT.Caption = "Tên vật tư";
            this.TENVT.FieldName = "TENVT";
            this.TENVT.Name = "TENVT";
            this.TENVT.Visible = true;
            this.TENVT.VisibleIndex = 1;
            this.TENVT.Width = 361;
            // 
            // SOLUONG
            // 
            this.SOLUONG.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.SOLUONG.AppearanceHeader.Options.UseFont = true;
            this.SOLUONG.Caption = "Số lượng";
            this.SOLUONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SOLUONG.FieldName = "SOLUONG";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SOLUONG", "{0:0.##}")});
            this.SOLUONG.Visible = true;
            this.SOLUONG.VisibleIndex = 3;
            this.SOLUONG.Width = 121;
            // 
            // TEMGIA
            // 
            this.TEMGIA.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.TEMGIA.AppearanceHeader.Options.UseFont = true;
            this.TEMGIA.Caption = "Tem Giá";
            this.TEMGIA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TEMGIA.FieldName = "TEMGIA";
            this.TEMGIA.Name = "TEMGIA";
            this.TEMGIA.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TEMGIA", "{0:0.##}")});
            this.TEMGIA.Visible = true;
            this.TEMGIA.VisibleIndex = 4;
            this.TEMGIA.Width = 160;
            // 
            // DIENGIAI
            // 
            this.DIENGIAI.Caption = "Diễn giải";
            this.DIENGIAI.FieldName = "DIENGIAI";
            this.DIENGIAI.Name = "DIENGIAI";
            this.DIENGIAI.Visible = true;
            this.DIENGIAI.VisibleIndex = 2;
            this.DIENGIAI.Width = 20;
            // 
            // oFD
            // 
            this.oFD.FileName = "openFileDialog1";
            this.oFD.FileOk += new System.ComponentModel.CancelEventHandler(this.oFD_FileOk);
            // 
            // FormD6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormD6";
            this.Text = "In tem cỡ nhỏ";
            this.Load += new System.EventHandler(this.FormD6_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teDgiai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSearchSCT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCtrlD6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvD6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraEditors.TextEdit teSearchSCT;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gCtrlD6;
        private DevExpress.XtraGrid.Views.Grid.GridView grvD6;
        private DevExpress.XtraGrid.Columns.GridColumn MAVT;
        private DevExpress.XtraGrid.Columns.GridColumn TENVT;
        private DevExpress.XtraGrid.Columns.GridColumn SOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn TEMGIA;
        private DevExpress.XtraEditors.TextEdit teDgiai;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn DIENGIAI;
        private System.Windows.Forms.OpenFileDialog oFD;
    }
}