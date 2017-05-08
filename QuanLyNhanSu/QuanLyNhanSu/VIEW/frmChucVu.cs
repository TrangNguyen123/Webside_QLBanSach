using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.DOITUONG;
using QuanLyNhanSu.CONTROL;

namespace QuanLyNhanSu.VIEW
{
    public partial class frmChucVu : Form
    {
        ChucVuCTRL cv = new ChucVuCTRL();
        ChucVuDT dtCV = new ChucVuDT();
        DataTable dt = new DataTable();
        public frmChucVu()
        {
            InitializeComponent();
        }

        private void frmChucVu_Them_Load(object sender, EventArgs e)
        {
            dt = cv.GetData();
            dgvChucVu.DataSource = dt;
            KL();
        }
        void KL()
        {
            txtMaChucVu.DataBindings.Clear();
            txtMaChucVu.DataBindings.Add("Text", dgvChucVu.DataSource, "machucvu");
            txtTenChucVu.DataBindings.Clear();
            txtTenChucVu.DataBindings.Add("Text", dgvChucVu.DataSource, "tenchucvu");
        }
        private void Cleardata()
        {
            txtMaChucVu.Text = "";
            txtTenChucVu.Text = "";

        }
        //ham lay du lieu tu cotroller
         void ganDL(ChucVuDT dtCV)
        {
            dtCV.Machucvu = txtMaChucVu.Text.Trim();
            dtCV.Tenchucvu = txtTenChucVu.Text.Trim();
        }
        //cài đặt ẳn hiện của các btn ,textbox
        void ANTT(bool e)
        {
            txtMaChucVu.Enabled = e;
            txtTenChucVu.Enabled = e;


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
         //   Cleardata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("bạn chắc chắn muốn xóa", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dl == DialogResult.OK)
            {
                //thì xóa
                if (cv.DeleteData(txtMaChucVu.Text.Trim()))
                    MessageBox.Show("Xóa thành công ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
                return;

            frmChucVu_Them_Load(sender, e);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
           
            ANTT(false);
            ganDL(dtCV);
            if (chon == 0)
            {


                //them moi
                if (cv.AddData(dtCV))
                    MessageBox.Show("thêm thành công ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("thêm thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

               //sua
                if (cv.UpdateData(dtCV))
                    MessageBox.Show("Sửa thành công ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            frmChucVu_Them_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ANTT(false);
            frmChucVu_Them_Load(sender, e);
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
            string str = string.Format("tenchucvu like '%{0}%'", txtTimKiem.Text);
            //defaultview hien những tên chức vụ
            dt.DefaultView.RowFilter = str;


        }
    }
}
