using QuanLyKhoa.Models.TaiKhoan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoa
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (TaiKhoanData.CheckLogin(txtUsername.Text.Trim().ToString(), txtPassword.Text))
            {
                lblInvalid.Visible = false;
                this.Visible = false;
                frmMaintainSpeciality form = new frmMaintainSpeciality();
                form.LoginedUser = txtUsername.Text.Trim().ToString();
                form.Visible = true;
            } else
            {
                lblInvalid.Visible = true;
            }
        }
    }
}
