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
    public partial class frmPhongBan : Form
    {
        PhongBanCTRL pb = new PhongBanCTRL();
        PhongBanDT dtPB = new PhongBanDT();
        DataTable dt = new DataTable();
        public frmPhongBan()
        {
            InitializeComponent();
        }

        private void frmPhongBan_Load(object sender, EventArgs e)
        {

            dt = pb.GetData();
            dgvPhongBan.DataSource = dt;
            KL();
        }
        void KL()
        {
            txtMaPhongBan.DataBindings.Clear();
            txtMaPhongBan.DataBindings.Add("Text", dgvPhongBan.DataSource, "maphongban");
            txtSoDienThoai.DataBindings.Clear();
            txtSoDienThoai.DataBindings.Add("Text", dgvPhongBan.DataSource, "sodienthoai");
            txtTenPhongBan.DataBindings.Clear();
            txtTenPhongBan.DataBindings.Add("Text", dgvPhongBan.DataSource, "tenphongban");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvPhongBan.DataSource, "diachi");
        }
        private void Cleardata()
        {
            txtDiaChi.Text = "";
            txtMaPhongBan.Text = "";
            txtSoDienThoai.Text = "";
            txtTenPhongBan.Text = "";

        }
        //ham lay du lieu tu cotroller
        void ganDL(PhongBanDT dtPB)
        {
            dtPB.Maphongban = txtMaPhongBan.Text.Trim();
            dtPB.Tenphongban = txtTenPhongBan.Text.Trim();
            dtPB.Diachi = txtDiaChi.Text.Trim();
            dtPB.Sodienthoai = txtSoDienThoai.Text.Trim();
        }
        //cài đặt ẳn hiện của các btn ,textbox
        void ANTT(bool e)
        {
            txtSoDienThoai.Enabled = e;
            txtDiaChi.Enabled = e;
            txtMaPhongBan.Enabled = e;
            txtTenPhongBan.Enabled = e;

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
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            chon = 1;
            ANTT(true);
            //  Cleardata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("bạn chắc chắn muốn xóa", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dl == DialogResult.OK)
            {
                //thì xóa
                if (pb.DeleteData(txtMaPhongBan.Text.Trim()))
                    MessageBox.Show("Xóa thành công ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
                return;

            frmPhongBan_Load(sender, e);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            ANTT(false);
            ganDL(dtPB);
            if (chon == 0)
            {


                //them moi
                if (pb.AddData(dtPB))
                    MessageBox.Show("thêm thành công ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("thêm thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                //sua
                if (pb.UpdateData(dtPB))
                    MessageBox.Show("Sửa thành công ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            frmPhongBan_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ANTT(false);
            frmPhongBan_Load(sender, e);
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

            //tìm kiếm những chức vụ gần giống với like{0}
            string str = string.Format("tenphongban like '%{0}%'", txtTimKiem.Text);
            //defaultview hien những tên chức vụ
            dt.DefaultView.RowFilter = str;


        }
    }
}
