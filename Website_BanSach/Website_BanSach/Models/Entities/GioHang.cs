using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website_BanSach.Models.Entities
{
    public class GioHang
    {
        quanlybansach db = new quanlybansach();
        //Thông tin giỏ hàng
        public int iMaSach { get; set; }
        public string TenSach { get; set; }
        public string sHinhAnh { get; set; }
        public int iGia { get; set; }
        public int iSoLuong { get; set; }
        public int iThanhTien {
            get { return iSoLuong * iGia; }
        }
        //Hàm tạo cho giỏ hàng

        public GioHang(int masach)
        {
            iMaSach = masach;
            SACH sach = db.SACHes.Single(n => n.masach == iMaSach);
            TenSach = sach.tensach;
            sHinhAnh = sach.urlAnh;
            iGia = int.Parse(sach.giaban.ToString());
            iSoLuong = 1;

        }
    }
}