using QuanLyNhanSu.DOITUONG;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.MOHINH
{
    class HopDongMH
    {

        KCSDL conn = new KCSDL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select hopdonglaodong.*, nhanvien.tennhanvien from hopdonglaodong, nhanvien where hopdonglaodong.manhanvien = nhanvien.manhanvien";
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
        public bool AddData(HopDongLaoDongDT dtHD)
        {
            cmd.CommandText = "INSERT INTO hopdonglaodong values ('" + dtHD.Mahopdong + "',N'" + dtHD.Loaihopdong + "',CONVERT(DATE,'" + dtHD.Tungay + "',103),CONVERT(DATE,'" + dtHD.Denngay + "',103) ,'" + dtHD.Manhanvien + "')";
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
        public bool UpdateData(HopDongLaoDongDT dtHD)
        {
            cmd.CommandText = "UPDATE hopdonglaodong SET loaihopdong = N'" + dtHD.Loaihopdong + "',tungay = CONVERT(DATE,'" + dtHD.Tungay + "',103),denngay = CONVERT(DATE,'" + dtHD.Denngay + "',103) ,manhanvien = '" + dtHD.Manhanvien + "' WHERE mahopdong ='" + dtHD.Mahopdong + "'";
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
            cmd.CommandText = "Delete hopdonglaodong  WHERE mahopdong ='" + Ma + "'";
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
