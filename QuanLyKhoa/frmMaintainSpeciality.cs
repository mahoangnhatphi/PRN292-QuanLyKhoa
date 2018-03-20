using QuanLyKhoa.Models.Khoa;
using QuanLyKhoa.Models.SVien;
using QuanLyKhoa.Models.TaiKhoan;
using QuanLyKhoa.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyKhoa
{
    public partial class frmMaintainSpeciality : Form
    {
        public string LoginedUser { set; get; }

        private List<Khoa> dsKhoa;
        public frmMaintainSpeciality()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void GetAll(string type = null)
        {
            if (type == null) { 
                dsKhoa = KhoaData.FindAll();
            }
            else
            {
                dsKhoa = KhoaData.FindNotStudentEnroll();
            }
            if (dsKhoa != null)
            {
                dgvSpeciality.DataSource = dsKhoa;
                dgvSpeciality.Columns["NamThanhLap"].Visible = false;
                dgvSpeciality.Columns["TuyenSinh"].Visible = false;
                lblNumber.Text = "Có " + dsKhoa.Count + " khoa";
                cbSpeciality.DataBindings.Clear();
                txtSpecialistName.DataBindings.Clear();
                cbSpeciality.DataBindings.Add("text", dsKhoa, "MaKhoa");
                txtSpecialistName.DataBindings.Add("text", dsKhoa, "TenKhoa");
                cbSpeciality.DataSource = dsKhoa;
                cbSpeciality.ValueMember = "MaKhoa";
                cbSpeciality.DisplayMember = "MaKhoa";
                dgvSpeciality.Visible = true;
                lblSpeciality.Visible = false;
                int count;
                lblNumberStudent.Text = (count = SVienData.CountNumberStudent(cbSpeciality.Text.ToString())) != 0 ?
                "Khoa " + txtSpecialistName.Text + " có " + count + " sinh viên" : "Chưa có sinh viên";
            }
            else
            {
                dgvSpeciality.Visible = false;
                lblSpeciality.Visible = true;
                lblSpeciality.Text = "Chưa có khoa";
                cbSpeciality.DataBindings.Clear();
                txtSpecialistName.DataBindings.Clear();
                cbSpeciality.Text = string.Empty;
                cbSpeciality.DataSource = null;
                txtSpecialistName.Text = string.Empty;
                lblNumber.Text = "Chưa có khoa";
                lblNumberStudent.Text = "Chưa có sinh viên";
            }
        }

        private void frmMaintainSpeciality_Load(object sender, EventArgs e)
        {
            GetAll();
            pbAvatar.Image = PhotoUtilities.ByteToImage(TaiKhoanData.GetAvatar(LoginedUser));
            lblLoginedUser.Text = "Chào " + TaiKhoanData.GetHoTen(LoginedUser);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdateSpeciality form = new frmAddUpdateSpeciality(this, true);
            form.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbSpeciality.Text.ToString() != string.Empty)
            {
                frmAddUpdateSpeciality form = new frmAddUpdateSpeciality(this, false, dsKhoa.Where<Khoa>(k => k.MaKhoa == lblMaKhoa.Text.ToString()).FirstOrDefault());
                form.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblMaKhoa.Text.ToString() != string.Empty)
            {
                DialogResult option = MessageBox.Show("Bạn có muốn xóa Khoa " + lblMaKhoa.Text.ToString() + "?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo);
                if (option == DialogResult.Yes)
                {
                    bool r = KhoaData.DeleteKhoa(lblMaKhoa.Text.ToString());
                    if (r)
                    {
                        MessageBox.Show("Thành công");
                        GetAll();
                    }
                    else
                    {
                        MessageBox.Show("Xảy ra lỗi khi thực hiện");
                    }
                }
            }
        }

        private void dgvSpeciality_CursorChanged(object sender, EventArgs e)
        {
        }

        private void dgvSpeciality_SelectionChanged(object sender, EventArgs e)
        {
            cbSpeciality.DataSource = null;
            cbSpeciality.DataBindings.Clear();
            cbSpeciality.DataBindings.Add("text", dsKhoa, "MaKhoa");
            txtSpecialistName.DataBindings.Clear();
            txtSpecialistName.DataBindings.Add("text", dsKhoa, "TenKhoa");
            lblMaKhoa.Text = cbSpeciality.Text;
            cbSpeciality.DataSource = dsKhoa;
            cbSpeciality.ValueMember = "MaKhoa";
            cbSpeciality.DisplayMember = "MaKhoa";
            int count;
            lblNumberStudent.Text = (count =SVienData.CountNumberStudent(cbSpeciality.Text.ToString())) != 0 ?
                 "Khoa " + txtSpecialistName.Text + " có " + count + " sinh viên" : "Chưa có sinh viên";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thực sự muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvSpeciality_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbSpeciality_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSpeciality.DataBindings.Clear();
            txtSpecialistName.DataBindings.Clear();
        }

        private void khoaĐãNgưngĐàoTạoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetAll("Khoa ngung dao tao");
            btnAdd.Visible = false;
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnPhysicalDelete.Visible = true;
            btnReopen.Visible = true;
        }

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetAll();
            btnAdd.Visible = true;
            btnDelete.Visible = true;
            btnUpdate.Visible = true;
            btnReopen.Visible = false;
            btnPhysicalDelete.Visible = false;
        }

        private void btnReopen_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dgvSpeciality.SelectedRows;
            foreach (DataGridViewRow row in rows)
            {
                KhoaData.ReopenKhoa(row.Cells[0].Value.ToString());
            }
            GetAll("Khoa ngung dao tao");
        }

        private void btnPhysicalDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dgvSpeciality.SelectedRows;
            foreach (DataGridViewRow row in rows)
            {
                KhoaData.PhysicalDeleteKhoa(row.Cells[0].Value.ToString());
            }
            GetAll("Khoa ngung dao tao");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmMaintainSpeciality_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
