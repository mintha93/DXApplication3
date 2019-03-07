namespace DXApplication3
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.gCtrlTemle = new DevExpress.XtraGrid.GridControl();
            this.grvTemle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIABANVND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIABANUSD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.oFD = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBoxTemle = new DevExpress.XtraEditors.ListBoxControl();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.radioTemle = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.gCtrlTemle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTemle)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxTemle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioTemle.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gCtrlTemle
            // 
            this.gCtrlTemle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gCtrlTemle.Location = new System.Drawing.Point(3, 3);
            this.gCtrlTemle.LookAndFeel.SkinName = "Blue";
            this.gCtrlTemle.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gCtrlTemle.MainView = this.grvTemle;
            this.gCtrlTemle.Name = "gCtrlTemle";
            this.gCtrlTemle.Size = new System.Drawing.Size(734, 295);
            this.gCtrlTemle.TabIndex = 0;
            this.gCtrlTemle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTemle});
            // 
            // grvTemle
            // 
            this.grvTemle.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvTemle.Appearance.FooterPanel.Options.UseFont = true;
            this.grvTemle.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvTemle.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvTemle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAVT,
            this.TENVT,
            this.SOLUONG,
            this.GIABANVND,
            this.GIABANUSD});
            this.grvTemle.GridControl = this.gCtrlTemle;
            this.grvTemle.Name = "grvTemle";
            this.grvTemle.OptionsView.ColumnAutoWidth = false;
            this.grvTemle.OptionsView.ShowFooter = true;
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
            this.TENVT.Width = 322;
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
            this.SOLUONG.VisibleIndex = 2;
            this.SOLUONG.Width = 61;
            // 
            // GIABANVND
            // 
            this.GIABANVND.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.GIABANVND.AppearanceHeader.Options.UseFont = true;
            this.GIABANVND.Caption = "Giá bán VND";
            this.GIABANVND.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GIABANVND.FieldName = "GIABAN_VND";
            this.GIABANVND.Name = "GIABANVND";
            this.GIABANVND.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GIABAN_VND", "{0:0.##}")});
            this.GIABANVND.Visible = true;
            this.GIABANVND.VisibleIndex = 3;
            this.GIABANVND.Width = 106;
            // 
            // GIABANUSD
            // 
            this.GIABANUSD.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.GIABANUSD.AppearanceHeader.Options.UseFont = true;
            this.GIABANUSD.Caption = "Giá bán USD";
            this.GIABANUSD.FieldName = "GIABAN_NT";
            this.GIABANUSD.Name = "GIABANUSD";
            this.GIABANUSD.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GIABAN_NT", "{0:0.##}")});
            this.GIABANUSD.Visible = true;
            this.GIABANUSD.VisibleIndex = 4;
            this.GIABANUSD.Width = 81;
            // 
            // oFD
            // 
            this.oFD.FileName = "openFileDialog1";
            this.oFD.FileOk += new System.ComponentModel.CancelEventHandler(this.oFD_FileOk);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gCtrlTemle);
            this.panel1.Location = new System.Drawing.Point(3, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 314);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.listBoxTemle);
            this.panel2.Controls.Add(this.btnPreview);
            this.panel2.Controls.Add(this.btnImport);
            this.panel2.Controls.Add(this.labelControl3);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Controls.Add(this.radioTemle);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(743, 109);
            this.panel2.TabIndex = 2;
            // 
            // listBoxTemle
            // 
            this.listBoxTemle.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.listBoxTemle.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTemle.Appearance.Options.UseBackColor = true;
            this.listBoxTemle.Appearance.Options.UseFont = true;
            this.listBoxTemle.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxTemle.Items.AddRange(new object[] {
            "CR S27 THUYỀN RỒNG(93)",
            "CR S28 THÁP CHÀM (94)",
            "CR T1(88)",
            "DN I1(28)",
            "DN I2(29)",
            "THOMAS SABO TAKASHIMAYA(48)",
            "TSN D2(07)",
            "TSN D3(40)",
            "TSN D4(41)",
            "TSN D5(42)",
            "TSN D6(43)",
            "TSN I1(04)",
            "TSN I2(06)",
            "TTP TRÀNG TIỀN(69)",
            "VIET HOUSE F22(96)"});
            this.listBoxTemle.Location = new System.Drawing.Point(473, 0);
            this.listBoxTemle.LookAndFeel.SkinName = "Liquid Sky";
            this.listBoxTemle.LookAndFeel.UseDefaultLookAndFeel = false;
            this.listBoxTemle.Name = "listBoxTemle";
            this.listBoxTemle.Size = new System.Drawing.Size(270, 106);
            this.listBoxTemle.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.listBoxTemle.TabIndex = 8;
            this.listBoxTemle.SelectedIndexChanged += new System.EventHandler(this.listBoxTemle_SelectedIndexChanged);
            // 
            // btnPreview
            // 
            this.btnPreview.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPreview.ImageOptions.Image")));
            this.btnPreview.Location = new System.Drawing.Point(22, 53);
            this.btnPreview.LookAndFeel.SkinName = "Black";
            this.btnPreview.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(90, 35);
            this.btnPreview.TabIndex = 7;
            this.btnPreview.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnImport
            // 
            this.btnImport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.ImageOptions.Image")));
            this.btnImport.Location = new System.Drawing.Point(22, 11);
            this.btnImport.LookAndFeel.SkinName = "Black";
            this.btnImport.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnImport.Name = "btnImport";
            this.btnImport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnImport.Size = new System.Drawing.Size(90, 35);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "Import";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(166, 16);
            this.labelControl3.LookAndFeel.SkinName = "McSkin";
            this.labelControl3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 18);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Loại tiền tệ:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(418, 21);
            this.labelControl1.LookAndFeel.SkinName = "McSkin";
            this.labelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Kho:";
            // 
            // radioTemle
            // 
            this.radioTemle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radioTemle.EditValue = "abc";
            this.radioTemle.Location = new System.Drawing.Point(267, 3);
            this.radioTemle.Name = "radioTemle";
            this.radioTemle.Properties.Appearance.BackColor = System.Drawing.SystemColors.MenuBar;
            this.radioTemle.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.radioTemle.Properties.Appearance.Options.UseBackColor = true;
            this.radioTemle.Properties.Appearance.Options.UseForeColor = true;
            this.radioTemle.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.radioTemle.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "USD"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "VND")});
            this.radioTemle.Properties.LookAndFeel.SkinName = "Lilian";
            this.radioTemle.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.radioTemle.Size = new System.Drawing.Size(100, 48);
            this.radioTemle.TabIndex = 1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 425);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In tem lẻ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_Closing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gCtrlTemle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTemle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxTemle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioTemle.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gCtrlTemle;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTemle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn MAVT;
        private DevExpress.XtraGrid.Columns.GridColumn SOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn GIABANVND;
        private DevExpress.XtraGrid.Columns.GridColumn GIABANUSD;
        private DevExpress.XtraEditors.RadioGroup radioTemle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private System.Windows.Forms.OpenFileDialog oFD;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn TENVT;
        private DevExpress.XtraEditors.ListBoxControl listBoxTemle;
    }
}