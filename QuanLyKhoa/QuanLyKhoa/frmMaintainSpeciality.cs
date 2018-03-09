using QuanLyKhoa.Models.Khoa;
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
    public partial class frmMaintainSpeciality : Form
    {
        private List<Khoa> dsKhoa;
        public frmMaintainSpeciality()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void GetAll()
        {
            dsKhoa = KhoaData.FindAll();
            if (dsKhoa != null)
            {
                dgvSpeciality.DataSource = dsKhoa;
                dgvSpeciality.Columns["NamThanhLap"].Visible = false;
                dgvSpeciality.Columns["TuyenSinh"].Visible = false;
                lblNumber.Text = dsKhoa.Count + " khoa";
                cbSpeciality.DataBindings.Clear();
                txtSpecialistName.DataBindings.Clear();
                cbSpeciality.DataBindings.Add("text", dsKhoa, "MaKhoa");
                txtSpecialistName.DataBindings.Add("text", dsKhoa, "TenKhoa");
                cbSpeciality.DataSource = dsKhoa;
                cbSpeciality.ValueMember = "MaKhoa";
                dgvSpeciality.Visible = true;
                lblSpeciality.Visible = false;
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
            }
        }

        private void frmMaintainSpeciality_Load(object sender, EventArgs e)
        {
            GetAll();
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
                frmAddUpdateSpeciality form = new frmAddUpdateSpeciality(this, false, dsKhoa.Where<Khoa>(k => k.MaKhoa == cbSpeciality.Text.ToString()).FirstOrDefault());
                form.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbSpeciality.Text.ToString() != string.Empty)
            {
                DialogResult option = MessageBox.Show("Bạn có muốn xóa Khoa " + cbSpeciality.Text.ToString() + "?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo);
                if (option == DialogResult.Yes)
                {
                    bool r = KhoaData.DeleteKhoa(cbSpeciality.Text.ToString());
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
            cbSpeciality.DataBindings.Clear();
            cbSpeciality.DataBindings.Add("text", dsKhoa, "MaKhoa");
            txtSpecialistName.DataBindings.Clear();
            txtSpecialistName.DataBindings.Add("text", dsKhoa, "TenKhoa");
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
    }
}
