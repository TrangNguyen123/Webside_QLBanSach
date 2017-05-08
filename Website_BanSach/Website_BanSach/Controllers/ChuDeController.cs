using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website_BanSach.Models.Entities;

namespace Website_BanSach.Controllers
{
    public class ChuDeController : Controller
    {
        // GET: ChuDe
        quanlybansach db = new quanlybansach();
        public PartialViewResult ChuDePartial()
        {
            var cd = db.DANHMUCSACHes.ToList();
            return PartialView(cd);
        }
        //sách theo chủ đề
        public ViewResult SachTheoChuDe(int machude)
        {
            //kiểm tra chủ đề đã tồn tại hay không
            DANHMUCSACH cd = db.DANHMUCSACHes.SingleOrDefault(n => n.maDMS == machude);
            if(cd ==null)
            {
                Response.StatusCode = 404;
                return null;
            }
            //truy xuất những cuốn sách theo chủ đề
            List<SACH> lstsach = db.SACHes.Where(n =>n.maDMS == machude).ToList();
            if(lstsach.Count==0)
            {
                ViewBag.Sach = "Không có sách nào thuộc chủ đề này";
            }
            return View(lstsach);
        }
    }
}