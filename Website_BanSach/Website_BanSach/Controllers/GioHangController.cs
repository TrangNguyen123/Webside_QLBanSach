using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website_BanSach.Models.Entities;

namespace Website_BanSach.Controllers
{
    public class GioHangController : Controller
    {
        // GET: GioHang
        quanlybansach db = new quanlybansach();
        //lấy giỏ hàng
        public List<GioHang> LayGioHang()
        {
            //neu dung cách ép kiểu này nếu khách hàng chưa muốn đặt hàng thì nó sẽ báo lỗi vì session chưa tồn tại
            //List<GioHang> lstGioHang = (List<GioHang>) Session["GioHang"] as
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if (lstGioHang == null)
            {
                //nếu giỏ hàng chưa tồn tại tiến hành khởi tạo
                lstGioHang = new List<GioHang>();
                Session["GioHang"] = lstGioHang;//để nó lưu lại trên trang khi tắt trang web thì nó không con lưu


            }
            return lstGioHang;
        }
        //xây dựng thêm giỏ hàng
        public ActionResult ThemGioHang(int masach, string strUrl)
        {
            SACH sach = db.SACHes.SingleOrDefault(n => n.masach == masach);
            if (sach == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            //lấy ra session giỏ hàng
            List<GioHang> lstGioHang = LayGioHang();
            GioHang gh = lstGioHang.Find(n => n.iMaSach == masach);//kiểm tra xem mã sách xem nó đã tồn tại trong giỏ hàng hay chưa nếu chưa sẽ tạo
            if (gh == null)
            {
                gh = new GioHang(masach);
                //Thêm sách mới mua vào trong list
                lstGioHang.Add(gh);
                return Redirect(strUrl);
            }
            else
            {
                gh.iSoLuong++;
                return Redirect(strUrl);
            }
        }
        //sửa giỏ hàng
        public ActionResult CapNhatGioHang(int masach, FormCollection f) //FormCollection thêm chung chung
        {
            SACH sach = db.SACHes.SingleOrDefault(n => n.masach == masach);
            if (sach == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            List<GioHang> lstGioHang = LayGioHang();
            GioHang gh = lstGioHang.SingleOrDefault(n => n.iMaSach == masach);//SingleOrDefault xâu ra các sản phẩm có trong giỏ hàng
                                                                              //nếu tồn tại cho ta sửa số lượng
            if (gh != null)
            {
                gh.iSoLuong = int.Parse(f["txtSoLuong"].ToString());
            }
            return View("GioHang");
        }
        //Xóa Giỏ hàng
        public ActionResult XoaGioHang(int masach)
        {

            SACH sach = db.SACHes.SingleOrDefault(n => n.masach == masach);
            if (sach == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            List<GioHang> lstGioHang = LayGioHang();
            GioHang gh = lstGioHang.SingleOrDefault(n => n.iMaSach == masach);//SingleOrDefault xâu ra các sản phẩm có trong giỏ hàng
                                                                              //nếu tồn tại cho ta sửa số lượng
            if (gh != null)
            {
                lstGioHang.RemoveAll(n => n.iMaSach == masach);

            }
            if (lstGioHang.Count == 0)
            {
                return RedirectToAction("TrangChu", "Home");
            }
            return RedirectToAction("GioHang");

        }
        //Xây dựng trang giỏ hàng
        public ActionResult GioHang()
        {
            if (Session["GioHang"] == null)
            {
                return RedirectToAction("TrangChu", "Home");
            }
            List<GioHang> lstGioHang = LayGioHang();
            return View(lstGioHang);
        }
        //Xây Dựng tính tổng số lượng và tổng tiền
        //tính tổng số lượng
        private int TongSoLuong()
        {
            int iTong = 0;
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if (lstGioHang != null)
            {
                iTong = lstGioHang.Sum(n => n.iSoLuong);
            }
            return iTong;
        }
        //Tính Tổng tiền
        private int TongTien()
        {
            int iTong = 0;
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if (lstGioHang != null)
            {
                iTong = lstGioHang.Sum(n => n.iThanhTien);
            }
            return iTong;
        }
    }
}