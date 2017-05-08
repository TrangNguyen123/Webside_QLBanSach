using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSu.DOITUONG;

namespace QuanLyNhanSu.MOHINH
{
    class NhanVienMH
    {
        KCSDL conn = new KCSDL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select nhanvien.*, phongban.tenphongban, chucvu.tenchucvu, trinhdohocvan.tentrinhdohocvan from nhanvien,phongban,chucvu,trinhdohocvan where nhanvien.maphongban=phongban.maphongban and nhanvien.machucvu=chucvu.machucvu and trinhdohocvan.matrinhdohocvan = nhanvien.matrinhdohocvan";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;
            try
            {
                //mở kết nối
                conn.OpenConn();
                //thao tác với dữ liệu sử dụng dataAdapter,vận chuyển dl về
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                //đổ dl từ dataAdapter vao dataTable
                sda.Fill(dt);
                conn.CloseConn();

            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();//xóa bỏ phiên làm việc,loại bỏ ra khỏi hẳn bộ nhớ
                conn.CloseConn();
            }
            return dt;
        }
        //thêm mới dl
        public bool AddData(NhanVienDT dtNV)
        {
            cmd.CommandText = "INSERT INTO nhanvien values ('" + dtNV.Manhanvien + "',N'" + dtNV.Tennhanvien + "',CONVERT(DATE,'" + dtNV.Ngaysinh + "',103),'" + dtNV.Gioitinh + "',N'" + dtNV.Quequan + "','" + dtNV.Sodienthoai + "',N'" + dtNV.Dantoc + "','" + dtNV.Maphongban + "','" + dtNV.Machucvu + "','" + dtNV.Matrinhdohocvan + "','" + dtNV.Bacluong + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;
            try
            {
                conn.OpenConn();
                cmd.ExecuteNonQuery();
                conn.CloseConn();
                return true;

            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                conn.CloseConn();
            }
            return false;
        }
        //SỬA dl
        public bool UpdateData(NhanVienDT dtNV)
        {
            cmd.CommandText = "UPDATE nhanvien SET tennhanvien= N'" + dtNV.Tennhanvien + "',ngaysinh = CONVERT(DATE,'" + dtNV.Ngaysinh + "',103),gioitinh ='" + dtNV.Gioitinh + "',quequan = N'" + dtNV.Quequan + "',sodienthoai = '" + dtNV.Sodienthoai + "',dantoc = N'" + dtNV.Dantoc + "',maphongban = '" + dtNV.Maphongban + "', machucvu = '" + dtNV.Machucvu + "',matrinhdohocvan = '" + dtNV.Matrinhdohocvan + "',bacluong = '" + dtNV.Bacluong + "' WHERE manhanvien ='" + dtNV.Manhanvien + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;
            try
            {
                conn.OpenConn();
                cmd.ExecuteNonQuery();
                conn.CloseConn();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                conn.CloseConn();
            }
            return false;
        }
        //xóa
        public bool DeleteData(string Ma)
        {
            cmd.CommandText = "Delete nhanvien  WHERE manhanvien ='" + Ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;
            try
            {
                conn.OpenConn();
                cmd.ExecuteNonQuery();
                conn.CloseConn();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                conn.CloseConn();
            }
            return false;
        }
    }
}
