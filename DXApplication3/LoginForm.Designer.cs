namespace DXApplication3
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnSignin = new DevExpress.XtraEditors.SimpleButton();
            this.teUsername = new DevExpress.XtraEditors.TextEdit();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            ((System.ComponentModel.ISupportInitialize)(this.teUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignin
            // 
            this.btnSignin.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin.Appearance.Options.UseFont = true;
            this.btnSignin.Location = new System.Drawing.Point(117, 209);
            this.btnSignin.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.btnSignin.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(274, 46);
            this.btnSignin.TabIndex = 0;
            this.btnSignin.Text = "Sign in";
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // teUsername
            // 
            this.teUsername.EditValue = "USERNAME";
            this.teUsername.Location = new System.Drawing.Point(144, 111);
            this.teUsername.Name = "teUsername";
            this.teUsername.Properties.Appearance.Font = new System.Drawing.Font("Vani", 13.75F);
            this.teUsername.Properties.Appearance.Options.UseFont = true;
            this.teUsername.Properties.Appearance.Options.UseTextOptions = true;
            this.teUsername.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.teUsername.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teUsername.Size = new System.Drawing.Size(221, 38);
            this.teUsername.TabIndex = 1;
            this.teUsername.EditValueChanged += new System.EventHandler(this.teUsername_EditValueChanged);
            this.teUsername.Click += new System.EventHandler(this.teUsername_Click);
            this.teUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.teUsername_KeyPress);
            this.teUsername.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.teUsername_PreviewKeyDown);
            // 
            // tePassword
            // 
            this.tePassword.EditValue = "PASSWORD";
            this.tePassword.Location = new System.Drawing.Point(144, 155);
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.Appearance.Font = new System.Drawing.Font("Vani", 13.75F);
            this.tePassword.Properties.Appearance.Options.UseFont = true;
            this.tePassword.Properties.Appearance.Options.UseTextOptions = true;
            this.tePassword.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tePassword.Size = new System.Drawing.Size(221, 38);
            this.tePassword.TabIndex = 2;
            this.tePassword.Click += new System.EventHandler(this.tePassword_Click);
            this.tePassword.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tePassword_PreviewKeyDown);
            // 
            // imageSlider1
            // 
            this.imageSlider1.CurrentImageIndex = 0;
            this.imageSlider1.Cursor = System.Windows.Forms.Cursors.Default;
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images"))));
            this.imageSlider1.Location = new System.Drawing.Point(225, 45);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(62, 60);
            this.imageSlider1.TabIndex = 3;
            this.imageSlider1.Text = "imageSlider1";
            // 
            // frmLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(77)))), ((int)(((byte)(153)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 305);
            this.Controls.Add(this.imageSlider1);
            this.Controls.Add(this.tePassword);
            this.Controls.Add(this.teUsername);
            this.Controls.Add(this.btnSignin);
            this.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(77)))), ((int)(((byte)(153)))));
            this.LookAndFeel.SkinName = "Springtime";
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosing2);
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSignin;
        private DevExpress.XtraEditors.TextEdit teUsername;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
    }
}