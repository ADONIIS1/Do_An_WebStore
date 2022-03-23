using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebStoreFZF.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult ThongKe()
        {
            return View();
        }

        public ActionResult LoaiThietBi()
        {
            return View();
        }
        public ActionResult HangSanXuat()
        {
            return View();
        }
        public ActionResult MatHang()
        {
            return View();
        }
        public ActionResult KhachHang()
        {
            return View();
        }
    }
}