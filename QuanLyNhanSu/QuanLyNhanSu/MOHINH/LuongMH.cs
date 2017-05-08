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
    class LuongMH
    {

        KCSDL conn = new KCSDL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select luong.* from luong";
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
        public bool AddData(LuongDT dtL)
        {
            cmd.CommandText = "INSERT INTO luong values ('" + dtL.Bacluong + "','" + dtL.Luongcoban + "','" + dtL.Hesoluong + "','" + dtL.Hesophucap + "')";
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
        public bool UpdateData(LuongDT dtL)
        {
            cmd.CommandText = "UPDATE luong SET luongcoban = '" + dtL.Luongcoban + "',hesoluong = '" + dtL.Hesoluong + "',hesophucap = '" + dtL.Hesophucap + "'WHERE bacluong ='" + dtL.Bacluong + "'";
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
        public bool DeleteData(string bacluong)
        {
            cmd.CommandText = "Delete luong  WHERE  bacluong ='" + bacluong + "'";
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
