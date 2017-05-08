using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Website_BanSach.Models.Entities;

namespace Website_BanSach.Controllers
{
    public class SACHController : Controller
    {
        // GET: SACH
        quanlybansach db = new quanlybansach(); 
        public PartialViewResult SachPartial()
        {

            return PartialView(db.SACHes.ToList());
        }
        public ViewResult xemchitiet(int masach)
        {
            SACH sach = db.SACHes.SingleOrDefault(n => n.masach == masach);
            //kiểm tra chủ đề đã tồn tại hay không
         
            if (sach== null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(sach);
        }
     
    }
}