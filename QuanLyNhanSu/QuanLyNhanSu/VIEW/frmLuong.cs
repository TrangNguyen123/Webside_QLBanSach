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
    public partial class frmLuong : Form
    {

        LuongCTRL l = new LuongCTRL();
        LuongDT dtL = new LuongDT();
        DataTable dt = new DataTable();
        public frmLuong()
        {
            InitializeComponent();
        }

        private void frmLuong_Load(object sender, EventArgs e)
        {
            dt = l.GetData();
            dgvLuong.DataSource = dt;
            KL();
        }
        void KL()
        {
            txtBacLuong.DataBindings.Clear();
            txtBacLuong.DataBindings.Add("Text", dgvLuong.DataSource, "bacluong");
            txtLuongCoBan.DataBindings.Clear();
            txtLuongCoBan.DataBindings.Add("Text", dgvLuong.DataSource, "luongcoban");
            txtHeSoLuong.DataBindings.Clear();
            txtHeSoLuong.DataBindings.Add("Text", dgvLuong.DataSource, "hesoluong");
            txtHeSoPhuCap.DataBindings.Clear();
            txtHeSoPhuCap.DataBindings.Add("Text", dgvLuong.DataSource, "hesophucap");
        }
        private void Cleardata()
        {
            txtHeSoPhuCap.Text = "";
            txtHeSoLuong.Text = "";
            txtBacLuong.Text = "";
            txtLuongCoBan.Text = "";

        }
        //ham lay du lieu tu cotroller
        void ganDL(LuongDT dtL)
        {
            dtL.Bacluong = txtBacLuong.Text.Trim();
            dtL.Luongcoban = txtLuongCoBan.Text.Trim();
            dtL.Hesoluong = txtHeSoLuong.Text.Trim();
            dtL.Hesophucap = txtHeSoPhuCap.Text.Trim();
        }
        //cài đặt ẳn hiện của các btn ,textbox
        void ANTT(bool e)
        {
            txtBacLuong.Enabled = e;
            txtLuongCoBan.Enabled = e;
            txtHeSoLuong.Enabled = e;
            txtHeSoPhuCap.Enabled = e;

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
                if (l.DeleteData(txtBacLuong.Text.Trim()))
                    MessageBox.Show("Xóa thành công ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
                return;

            frmLuong_Load(sender, e);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            ANTT(false);
            ganDL(dtL);
            if (chon == 0)
            {


                //them moi
                if (l.AddData(dtL))
                    MessageBox.Show("thêm thành công ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("thêm thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                //sua
                if (l.UpdateData(dtL))
                    MessageBox.Show("Sửa thành công ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            frmLuong_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ANTT(false);
            frmLuong_Load(sender, e);
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
            string str = string.Format("luongcoban like '%{0}%'", txtTimKiem.Text);
            //defaultview hien những tên chức vụ
            dt.DefaultView.RowFilter = str;


        }
    }
}
