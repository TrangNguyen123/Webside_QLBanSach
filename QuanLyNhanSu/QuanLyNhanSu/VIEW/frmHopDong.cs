using QuanLyNhanSu.CONTROL;
using QuanLyNhanSu.DOITUONG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.VIEW
{
    public partial class frmHopDong : Form
    {
        HopDongCTRL hd = new HopDongCTRL();
        HopDongLaoDongDT dtHD = new HopDongLaoDongDT();
        DataTable dt = new DataTable();
        public frmHopDong()
        {
            InitializeComponent();
        }

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            dt = hd.GetData();
            dgvHopDong.DataSource = dt;
            KL();
        }
        void KL()
        {
            txtMaHopDong.DataBindings.Clear();
            txtMaHopDong.DataBindings.Add("Text", dgvHopDong.DataSource, "mahopdong");
            txtLoaiHopDong.DataBindings.Clear();
            txtLoaiHopDong.DataBindings.Add("Text", dgvHopDong.DataSource, "loaihopdong");
            dtpTuNgay.DataBindings.Clear();
            dtpTuNgay.DataBindings.Add("Text", dgvHopDong.DataSource,"tungay");
            dtpDenNgay.DataBindings.Clear();
            dtpDenNgay.DataBindings.Add("Text", dgvHopDong.DataSource, "denngay");
            cmbTenNhanVien.DataBindings.Clear();
            cmbTenNhanVien.DataBindings.Add("Text", dgvHopDong.DataSource, "tennhanvien");
           
        }
        private void loadNhanVien()
        {
            NhanVienCTRL b = new NhanVienCTRL();
            cmbTenNhanVien.DataSource = b.GetData();
            cmbTenNhanVien.DisplayMember = "tennhanvien";
            cmbTenNhanVien.ValueMember = "manhanvien";
        }
        
        private void Cleardata()
        {
            txtMaHopDong.Text = "";
            txtLoaiHopDong.Text = "";
            dtpTuNgay.Text = "";
            dtpDenNgay.Text = "";
            cmbTenNhanVien.Text = "";

        }
        //ham lay du lieu tu cotroller
        void ganDL(HopDongLaoDongDT dtHD)
        {
            dtHD.Mahopdong = txtMaHopDong.Text.Trim();
            dtHD.Loaihopdong = txtLoaiHopDong.Text.Trim();
            dtHD.Tungay = dtpTuNgay.Text.Trim();
            dtHD.Denngay = dtpDenNgay.Text.Trim();
            dtHD.Manhanvien = cmbTenNhanVien.SelectedValue.ToString();

        }
        //cài đặt ẳn hiện của các btn ,textbox
        void ANTT(bool e)
        {
            txtMaHopDong.Enabled = e;
            txtLoaiHopDong.Enabled = e;
            dtpTuNgay.Enabled = e;
            dtpDenNgay.Enabled = e;
            cmbTenNhanVien.Enabled = e;

            btnCapNhat.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;


        }

        int chon;
        private void btnThem_Click(object sender, EventArgs e)
        {
            chon = 0;
            ANTT(true);
            Cleardata();
            loadNhanVien();
           
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            chon = 1;
            ANTT(true);
            loadNhanVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("bạn chắc chắn muốn xóa", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dl == DialogResult.OK)
            {
                //thì xóa
                if (hd.DeleteData(txtMaHopDong.Text.Trim()))
                    MessageBox.Show("Xóa thành công ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
                return;

            frmHopDong_Load(sender, e);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            ANTT(false);
            ganDL(dtHD);
            if (chon == 0)
            {


                //them moi
                if (hd.AddData(dtHD))
                    MessageBox.Show("thêm thành công ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("thêm thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                //sua
                if (hd.UpdateData(dtHD))
                    MessageBox.Show("Sửa thành công ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            frmHopDong_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ANTT(false);
            frmHopDong_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
