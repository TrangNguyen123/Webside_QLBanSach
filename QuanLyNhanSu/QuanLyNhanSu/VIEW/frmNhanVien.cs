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
    public partial class frmNhanVien : Form
    {
        NhanVienCTRL nv = new NhanVienCTRL();
        NhanVienDT dtNV = new NhanVienDT();
        DataTable dt = new DataTable();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {

            dt = nv.GetData();
            dgvNhanVien.DataSource = dt;
            KL();
        }
        void KL()
        {
            txtMaNhanVien.DataBindings.Clear();
            txtMaNhanVien.DataBindings.Add("Text", dgvNhanVien.DataSource, "manhanvien");
            txtTenNhanVien.DataBindings.Clear();
            txtTenNhanVien.DataBindings.Add("Text", dgvNhanVien.DataSource, "tennhanvien");
            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", dgvNhanVien.DataSource, "ngaysinh");
            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", dgvNhanVien.DataSource, "gioitinh");
            txtDanToc.DataBindings.Clear();
            txtDanToc.DataBindings.Add("Text", dgvNhanVien.DataSource, "dantoc");
            txtSoDienThoai.DataBindings.Clear();
            txtSoDienThoai.DataBindings.Add("Text", dgvNhanVien.DataSource, "sodienthoai");
            txtQueQuan.DataBindings.Clear();
            txtQueQuan.DataBindings.Add("Text", dgvNhanVien.DataSource, "quequan");
            cmbChucVu.DataBindings.Clear();
            cmbChucVu.DataBindings.Add("Text", dgvNhanVien.DataSource, "tenchucvu");
            cmbBacLuong.DataBindings.Clear();
            cmbBacLuong.DataBindings.Add("Text", dgvNhanVien.DataSource, "bacluong");
            cmbPhongBan.DataBindings.Clear();
            cmbPhongBan.DataBindings.Add("Text", dgvNhanVien.DataSource, "tenphongban");
            cmbTrinhDoHocVan.DataBindings.Clear();
            cmbTrinhDoHocVan.DataBindings.Add("Text", dgvNhanVien.DataSource, "tentrinhdohocvan");
        }
        private void loadChucVu()
        {
            ChucVuCTRL b = new ChucVuCTRL();
            cmbChucVu.DataSource = b.GetData();
            cmbChucVu.DisplayMember = "tenchucvu";
            cmbChucVu.ValueMember = "machucvu";
        }
        private void loadPhongBan()
        {
            PhongBanCTRL b = new PhongBanCTRL();
            cmbPhongBan.DataSource = b.GetData();
            cmbPhongBan.DisplayMember = "tenphongban";
            cmbPhongBan.ValueMember = "maphongban";
        }
        private void loadTrinhDoHocVan()
        {
            TrinhDoHocVanCTRL b = new TrinhDoHocVanCTRL();
            cmbTrinhDoHocVan.DataSource = b.GetData();
            cmbTrinhDoHocVan.DisplayMember = "tentrinhdohocvan";
            cmbTrinhDoHocVan.ValueMember = "matrinhdohocvan";
        }
        private void loadBacLuong()
        {
            LuongCTRL b = new LuongCTRL();
            cmbBacLuong.DataSource = b.GetData();
            cmbBacLuong.DisplayMember = "bacluong";
            cmbBacLuong.ValueMember = "bacluong";
        }
        private void Cleardata()
        {
            txtMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            txtSoDienThoai.Text = "";
            txtDanToc.Text = "";
            txtGioiTinh.Text = "";
            txtQueQuan.Text = "";
            dtpNgaySinh.Text = "";
            cmbPhongBan.Text = "";
            cmbChucVu.Text = "";
            cmbBacLuong.Text = "";
            cmbTrinhDoHocVan.Text = "";

        }
        //ham lay du lieu tu cotroller
        void ganDL(NhanVienDT dtNV)
        {
            dtNV.Manhanvien = txtMaNhanVien.Text.Trim();
            dtNV.Tennhanvien = txtTenNhanVien.Text.Trim();
            dtNV.Quequan = txtQueQuan.Text.Trim();
            dtNV.Sodienthoai = txtSoDienThoai.Text.Trim();
            dtNV.Dantoc = txtDanToc.Text.Trim();
            dtNV.Ngaysinh = dtpNgaySinh.Text.Trim();
            dtNV.Gioitinh = txtGioiTinh.Text.Trim();
            dtNV.Machucvu = cmbChucVu.SelectedValue.ToString();
            dtNV.Maphongban = cmbPhongBan.SelectedValue.ToString();
            dtNV.Matrinhdohocvan = cmbTrinhDoHocVan.SelectedValue.ToString();
            dtNV.Bacluong = cmbBacLuong.SelectedValue.ToString();

        }
        //cài đặt ẳn hiện của các btn ,textbox
        void ANTT(bool e)
        {
            txtSoDienThoai.Enabled = e;
            txtQueQuan.Enabled = e;
            txtMaNhanVien.Enabled = e;
            txtTenNhanVien.Enabled = e;
            txtGioiTinh.Enabled = e;
            txtDanToc.Enabled = e;
            dtpNgaySinh.Enabled = e;
            cmbBacLuong.Enabled = e;
            cmbChucVu.Enabled = e;
            cmbPhongBan.Enabled = e;
            cmbTrinhDoHocVan.Enabled = e;

            btnCapNhat.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;


        }
        //chuyền dl vào txtGioitinh
        private void radNam_CheckedChanged(object sender, EventArgs e)
        {
            if (radNam.Checked)
                txtGioiTinh.Clear();
            txtGioiTinh.Text = false.ToString();

        }

        private void radNu_CheckedChanged(object sender, EventArgs e)
        {
            if (radNu.Checked)
                txtGioiTinh.Clear();
            txtGioiTinh.Text = true.ToString();
        }

        int chon;
        private void btnThem_Click(object sender, EventArgs e)
        {
            chon = 0;
            ANTT(true);
            Cleardata();
            loadBacLuong();
            loadChucVu();
            loadPhongBan();
            loadTrinhDoHocVan();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            chon = 1;
            ANTT(true);
            loadBacLuong();
            loadChucVu();
            loadPhongBan();
            loadTrinhDoHocVan();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("bạn chắc chắn muốn xóa", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dl == DialogResult.OK)
            {
                //thì xóa
                if (nv.DeleteData(txtMaNhanVien.Text.Trim()))
                    MessageBox.Show("Xóa thành công ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
                return;

            frmNhanVien_Load(sender, e);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            ANTT(false);
            ganDL(dtNV);
            if (chon == 0)
            {


                //them moi
                if (nv.AddData(dtNV))
                    MessageBox.Show("thêm thành công ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("thêm thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                //sua
                if (nv.UpdateData(dtNV))
                    MessageBox.Show("Sửa thành công ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            frmNhanVien_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ANTT(false);
            frmNhanVien_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

          
            string str;
            switch(chon)
            {
                case 2:
                   {
                        str = string.Format("tennhanvien like '%{0}%'", txtTimKiem.Text);
                        dt.DefaultView.RowFilter = str;
                        break;
                   }
                case 3:
                   {
                        str = string.Format("quequan like '%{0}%'", txtTimKiem.Text);
                        dt.DefaultView.RowFilter = str;
                        break;
                    }
                case 4:
                   {
                        str = string.Format("tenchucvu like '%{0}%'", txtTimKiem.Text);
                        dt.DefaultView.RowFilter = str;
                        break;
                    }
                case 5:
                    {
                       str = string.Format("tenphongban like '%{0}%'", txtTimKiem.Text);
                       dt.DefaultView.RowFilter = str;
                        break;
                    }
                case 6:
                    {
                        str = string.Format("tentrinhdohocvan like '%{0}%'", txtTimKiem.Text);
                        dt.DefaultView.RowFilter = str;
                        break;
                    }
               
              }
        }

        private void mnTenNhanVien_Click(object sender, EventArgs e)
        {
            chon = 2;
            txtTimKiem.Text = "Nhập tên nhân viên";
            txtTimKiem.Enabled = true;
            btnTimKiem.Enabled = true;
        }

        private void mnQueQuan_Click(object sender, EventArgs e)
        {
            chon = 3;
            txtTimKiem.Text = "Nhập quê quán";
            txtTimKiem.Enabled = true;
            btnTimKiem.Enabled = true;
        }

        private void mnChucVu_Click(object sender, EventArgs e)
        {
            chon = 4;
            txtTimKiem.Text = "Nhập tên chức vụ";
            txtTimKiem.Enabled = true;
            btnTimKiem.Enabled = true;
        }

        private void mnPhongBan_Click(object sender, EventArgs e)
        {
            chon = 5;
            txtTimKiem.Text = "Nhập tên phòng ban";
            txtTimKiem.Enabled = true;
            btnTimKiem.Enabled = true;
        }

        private void mnTrinhDoHocVan_Click(object sender, EventArgs e)
        {
            chon = 6;
            txtTimKiem.Text = "Nhập tên trình độ học vấn";
            txtTimKiem.Enabled = true;
            btnTimKiem.Enabled = true;
        }

        
    }
}
