using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DXApplication3.BUS;

namespace DXApplication3
{

    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        clBUS _BUS = new clBUS();
        string userName_frmLogin = "";
        int priority_frmLogin =0;
        public frmLogin()
        {
            InitializeComponent();
        }
        private void teUsername_Click(object sender, EventArgs e)
        {
            teUsername.EditValue = "";
        }
        private void tePassword_Click(object sender, EventArgs e)
        {
            tePassword.EditValue = "";
            tePassword.Properties.PasswordChar = '*';
        }
        private void teUsername_EditValueChanged(object sender, EventArgs e)
        {
        }
        private void teUsername_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                tePassword.EditValue = "";
                tePassword.Properties.PasswordChar = '*';
                tePassword.SelectionStart = tePassword.Text.Length;
                tePassword.SelectionLength = 0;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                try
                {
       
                    //if (_BUS.CreateMD5(tePassword.EditValue.ToString()).ToLower() == _BUS.GET_Password(teUsername.EditValue.ToString()))
                    //{
                    //    this.Hide();
                    //    var form2 = new Form2();
                    //    form2.Closed += (s, args) => this.Close();
                    //    form2.Show();
                    //}
                    //else
                    if (_BUS.getPriorityFromFileText(teUsername.EditValue.ToString(), tePassword.EditValue.ToString()) == 1)
                    {
                        Form2 frm2 = new Form2();
                        userName_frmLogin = teUsername.EditValue.ToString();
                        priority_frmLogin = 1;
                        frm2.PassvaluefromFormLogin(userName_frmLogin, priority_frmLogin);
                        this.Hide();
                        frm2.Closed += (s, args) => this.Close();
                        frm2.Show();
                    }
                    else if (_BUS.getPriorityFromFileText(teUsername.EditValue.ToString(), tePassword.EditValue.ToString()) == 2)
                    {
                        Form2 frm2 = new Form2();
                        userName_frmLogin = teUsername.EditValue.ToString();
                        priority_frmLogin = 2;
                        frm2.PassvaluefromFormLogin(userName_frmLogin, priority_frmLogin);
                        this.Hide();
                        frm2.Closed += (s, args) => this.Close();
                        frm2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Bạn nhập sai mật khẩu");
                    }
                }
                catch
                {
                    MessageBox.Show("Bạn nhập sai tên đăng nhập");
                }

            }
        }
        private void tePassword_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    //if (_BUS.CreateMD5(tePassword.EditValue.ToString()).ToLower() == _BUS.GET_Password(teUsername.EditValue.ToString()))
                    //{
                    //    this.Hide();
                    //    var form2 = new Form2();
                    //    form2.Closed += (s, args) => this.Close();
                    //    form2.Show();
                    //}
                    //else
                    if (_BUS.getPriorityFromFileText(teUsername.EditValue.ToString(), tePassword.EditValue.ToString()) == 1)
                    {
                        Form2 frm2 = new Form2();
                        userName_frmLogin = teUsername.EditValue.ToString();
                        priority_frmLogin = 1;
                        frm2.PassvaluefromFormLogin(userName_frmLogin, priority_frmLogin);
                        this.Hide();
                        frm2.Closed += (s, args) => this.Close();
                        frm2.Show();
                    }
                    else if (_BUS.getPriorityFromFileText(teUsername.EditValue.ToString(), tePassword.EditValue.ToString()) == 2)
                    {
                        Form2 frm2 = new Form2();
                        userName_frmLogin = teUsername.EditValue.ToString();
                        priority_frmLogin = 2;
                        frm2.PassvaluefromFormLogin(userName_frmLogin, priority_frmLogin);
                        this.Hide();
                        frm2.Closed += (s, args) => this.Close();
                        frm2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Bạn nhập sai mật khẩu");
                    }
                }
                catch
                {
                    MessageBox.Show("Bạn nhập sai tên đăng nhập");
                }
            }
        }
        private void teUsername_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)9)
            {
                MessageBox.Show("abcd");
                tePassword.EditValue = "";
                tePassword.Properties.PasswordChar = '*';
            }
        }
        private void XtraForm1_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.MinimizeBox = false;
            
        }
        private void btnSignin_Click(object sender, EventArgs e)
        {
            try
            {


                //if (_BUS.CreateMD5(tePassword.EditValue.ToString()).ToLower() == _BUS.GET_Password(teUsername.EditValue.ToString()))
                //{
                //    this.Hide();
                //    var form2 = new Form2();
                //    form2.Closed += (s, args) => this.Close();
                //    form2.Show();
                //}
                //else
                if (_BUS.getPriorityFromFileText(teUsername.EditValue.ToString(), tePassword.EditValue.ToString()) == 1)
                {
                    Form2 frm2 = new Form2();
                    userName_frmLogin = teUsername.EditValue.ToString();
                    priority_frmLogin = 1;
                    frm2.PassvaluefromFormLogin(userName_frmLogin, priority_frmLogin);
                    this.Hide();
                    frm2.Closed += (s, args) => this.Close();
                    frm2.Show();
                }
                else if (_BUS.getPriorityFromFileText(teUsername.EditValue.ToString(), tePassword.EditValue.ToString()) == 2)
                {
                    Form2 frm2 = new Form2();
                    userName_frmLogin = teUsername.EditValue.ToString();
                    priority_frmLogin = 2;
                    frm2.PassvaluefromFormLogin(userName_frmLogin, priority_frmLogin);
                    this.Hide();
                    frm2.Closed += (s, args) => this.Close();
                    frm2.Show();
                }
                else
                {
                    MessageBox.Show("Bạn nhập sai mật khẩu");
                }

            }
            catch 
            {
                MessageBox.Show("Bạn nhập sai tên đăng nhập");
            }
        }
        private void FormClosing2(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}