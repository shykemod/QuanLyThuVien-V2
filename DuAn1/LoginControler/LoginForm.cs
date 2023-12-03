using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataControler;
using WindowsFormsApp1.DataControler.DataDuAnTableAdapters;

namespace WindowsFormsApp1.LoginControler
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUser.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbUser.Focus(); return;
            }
            if (tbPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbPassword.Focus(); return;
            }
            LoginRes.UserProperties = LoginRes.Login(tbUser.Text, tbPassword.Text);
            if (LoginRes.UserProperties == null)
            {
                MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
