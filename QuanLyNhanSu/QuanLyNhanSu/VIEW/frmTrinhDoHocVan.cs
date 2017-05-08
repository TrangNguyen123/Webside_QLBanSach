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
    public partial class frmTrinhDoHocVan : Form
    {

        TrinhDoHocVanCTRL tv = new TrinhDoHocVanCTRL();
        TrinhDoHocVanDT dtTV = new TrinhDoHocVanDT();
        DataTable dt = new DataTable();
        public frmTrinhDoHocVan()
        {
            InitializeComponent();
        }

        private void frmTrinhDoHocVan_Load(object sender, EventArgs e)
        {
            dt = tv.GetData();
            dgvTrinhDoHocVan.DataSource = dt;
            KL();
        }
        void KL()
        {
            txtChuyenNganh.DataBindings.Clear();
            txtChuyenNganh.DataBindings.Add("Text", dgvTrinhDoHocVan.DataSource, "chuyennganh");
            txtMaTrinhDoHocVan.DataBindings.Clear();
            txtMaTrinhDoHocVan.DataBindings.Add("Text", dgvTrinhDoHocVan.DataSource, "matrinhdohocvan");
            txtTenTrinhDoHocVan.DataBindings.Clear();
            txtTenTrinhDoHocVan.DataBindings.Add("Text", dgvTrinhDoHocVan.DataSource, "tentrinhdohocvan");
           
        }
        private void Cleardata()
        {
            txtTenTrinhDoHocVan.Text = "";
            txtMaTrinhDoHocVan.Text = "";
            txtChuyenNganh.Text = "";
           

        }
        //ham lay du lieu tu cotroller
        void ganDL(TrinhDoHocVanDT dtTV)
        {
            dtTV.Matrinhdohocvan = txtMaTrinhDoHocVan.Text.Trim();
            dtTV.Tentrinhdohocvan = txtTenTrinhDoHocVan.Text.Trim();
            dtTV.Chuyennganh = txtChuyenNganh.Text.Trim();
            
        }
        //cài đặt ẳn hiện của các btn ,textbox
        void ANTT(bool e)
        {
            txtChuyenNganh.Enabled = e;
            txtMaTrinhDoHocVan.Enabled = e;
            txtTenTrinhDoHocVan.Enabled = e;
          

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
          
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("bạn chắc chắn muốn xóa", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dl == DialogResult.OK)
            {
                //thì xóa
                if (tv.DeleteData(txtMaTrinhDoHocVan.Text.Trim()))
                    MessageBox.Show("Xóa thành công ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
                return;

            frmTrinhDoHocVan_Load(sender, e);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            ANTT(false);
            ganDL(dtTV);
            if (chon == 0)
            {


                //them moi
                if (tv.AddData(dtTV))
                    MessageBox.Show("thêm thành công ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("thêm thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                //sua
                if (tv.UpdateData(dtTV))
                    MessageBox.Show("Sửa thành công ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            frmTrinhDoHocVan_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ANTT(false);
            frmTrinhDoHocVan_Load(sender, e);
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
            string str = string.Format("tentrinhdohocvan like '%{0}%'", txtTimKiem.Text);
            //defaultview hien những tên chức vụ
            dt.DefaultView.RowFilter = str;


        }
    }
}
