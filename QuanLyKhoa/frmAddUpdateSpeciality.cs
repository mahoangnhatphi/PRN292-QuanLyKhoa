using QuanLyKhoa.Models.Khoa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoa
{
    public partial class frmAddUpdateSpeciality : Form
    {
        public frmAddUpdateSpeciality()
        {
            InitializeComponent();
        }
        private bool isNew;
        private frmMaintainSpeciality maintainForm;
        public frmAddUpdateSpeciality(frmMaintainSpeciality maintainForm, bool isNew, Khoa khoa = null):this()
        {
            if (isNew)
            {
                txtSpecialtityFoundedYear.Visible = false;
                lblYear.Visible = false;
                txtSpecialtityFoundedYear.Text = DateTime.Now.Year.ToString();
                txtSpecialityCode.Text = string.Empty;
                txtSpecialityName.Text = string.Empty;
            } else
            {
                txtSpecialityCode.Text = khoa.MaKhoa;
                txtSpecialityName.Text = khoa.TenKhoa;
                txtSpecialtityFoundedYear.Text = khoa.NamThanhLap + "";
                //txtSpecialityCode.Enabled = false;
            }
            this.isNew = isNew;
            this.maintainForm = maintainForm;
            this.Text = isNew ? "Thêm mới khoa" : "Chỉnh sữa khoa";
        }

        private void frmAddUpdateSpeciality_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmAddUpdateSpeciality_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
        }

        private bool isValid()
        {
            return errSpecialityCodeLength.GetError(txtSpecialityCode).Length == 0 &&
                errSpecialityNameLength.GetError(txtSpecialityName).Length == 0 &&
                errSpecialtiyYear.GetError(txtSpecialtityFoundedYear).Length == 0;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                lblInvalid.Visible = false;
                bool result = false;
                if (isNew)
                {
                    result = KhoaData.AddNewKhoa(txtSpecialityCode.Text.Trim(), txtSpecialityName.Text.Trim(), int.Parse(txtSpecialtityFoundedYear.Text.Trim()));
                }
                else
                {
                    result = KhoaData.UpdateKhoa(txtSpecialityCode.Text.Trim(), txtSpecialityName.Text.Trim(), int.Parse(txtSpecialtityFoundedYear.Text.Trim()));
                }
                if (result)
                {
                    MessageBox.Show("Thành công");
                    maintainForm.GetAll();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi trong quá trình thực hiện");
                }
            } else
            {
                lblInvalid.Visible = true;
            }
        }

        private void txtSpecialityCode_Validating(object sender, CancelEventArgs e)
        {
            if (txtSpecialityCode.Text.Length < 1 || txtSpecialityCode.Text.Length >= 5)
            {
                this.errSpecialityCodeLength.SetError(txtSpecialityCode, "Mã Khoa yêu cầu từ 1 đến 4 kí tự");
            } else
            {
                this.errSpecialityCodeLength.SetError(txtSpecialityCode, "");
            }
        }

        private void txtSpecialityName_Validating(object sender, CancelEventArgs e)
        {
            if (txtSpecialityName.Text.Length < 5 || txtSpecialityName.Text.Length > 30)
            {
                this.errSpecialityNameLength.SetError(txtSpecialityName, "Tên Khoa yêu cầu từ 5 đến 30 kí tự");
            }
            else
            {
                this.errSpecialityNameLength.SetError(txtSpecialityName, "");
            }
        }

        private void frmAddUpdateSpeciality_Load(object sender, EventArgs e)
        {

        }

        private void txtSpecialtityFoundedYear_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"\d+");
            if (!regex.IsMatch(txtSpecialtityFoundedYear.Text.ToString()))
            {
                errSpecialtiyYear.SetError(txtSpecialtityFoundedYear, "Năm thành lập phải là số nguyên");
            } else
            {
                if (int.Parse(txtSpecialtityFoundedYear.Text.ToString().Trim()) > DateTime.Now.Year)
                {
                    errSpecialtiyYear.SetError(txtSpecialtityFoundedYear, "Năm thành lập chưa biết cụ thể thế nào");
                } else
                {
                    errSpecialtiyYear.SetError(txtSpecialtityFoundedYear, "");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
