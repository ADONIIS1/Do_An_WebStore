using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using WebStoreFZF.Models;

namespace WebStoreFZF.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        MyDataContextDataContext data = new MyDataContextDataContext();
        public ActionResult ThongKe()
        {
            return View();
        }

        public ActionResult LoaiThietBi()
        {
            var loai = data.LOAISANPHAMs.ToList();
            return View(loai);
        }
        [HttpGet]
        public ActionResult ThemLoaithietbi()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ThemLoaithietbi(LOAISANPHAM loai, FormCollection collection)
        {
            var ten = collection["TENLOAISP"];
            if (String.IsNullOrEmpty(ten))
                ViewData["Loi1"] = "Tên loại sản phẩm không được để trống";
            else
            {
                loai.TENLOAISP = ten;
                data.LOAISANPHAMs.InsertOnSubmit(loai);
                data.SubmitChanges();
                return RedirectToAction("LoaiThietBi");
            }
            return this.ThemLoaithietbi();
        }
        public ActionResult SuaLoaithietbi(int id)
        {
            var sl = data.LOAISANPHAMs.First(n => n.IdLOAISP == id);
            if (sl == null)
            {
                Response.SubStatusCode = 404;
                return null;
            }
            return View(sl);
        }
        [HttpPost]
        public ActionResult SuaLoaithietbi(int id, FormCollection collection)
        {
            var loai = data.LOAISANPHAMs.First(n => n.IdLOAISP == id);
            var ten = collection["TENLOAISP"];
            var kt = data.LOAISANPHAMs.ToList();
            foreach (var item in kt)
            {
                if (String.Compare(item.TENLOAISP, ten, true) == 0 && item.IdLOAISP != id)
                {
                    ViewData["Loi0"] = "Mã loại sản phẩm này đã tồn tại";
                    return this.SuaLoaithietbi(id);
                }
            }
            if (String.IsNullOrEmpty(ten))
            {
                ViewData["Loi1"] = "Tên loại sản phẩm không được để trống";
            }
            else
            {
                loai.TENLOAISP = ten;
                UpdateModel(loai);
                data.SubmitChanges();
                return RedirectToAction("LoaiSP");
            }
            return this.SuaLoaithietbi(id);
        }
        public ActionResult XoaLoaiSP(int id)
        {
            LOAISANPHAM xoa = data.LOAISANPHAMs.SingleOrDefault(n => n.IdLOAISP == id);
            if (xoa == null)
            {
                Response.SubStatusCode = 404;
                return null;
            }
            data.LOAISANPHAMs.DeleteOnSubmit(xoa);
            data.SubmitChanges();
            return RedirectToAction("LoaiThietBi");
        }
        public ActionResult HangSanXuat()
        {
            var kieu = data.HangSXes.ToList();
            return View(kieu);
        }
        [HttpGet]
        public ActionResult ThemKieuSP()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ThemKieuSP(HangSX kieu, FormCollection collection)
        {
            var ten = collection["TENKIEULOAISP"];
            if (String.IsNullOrEmpty(ten))
                ViewData["Loi1"] = "Tên kiểu sản phẩm không được để trống";
            else
            {
                kieu.TenHangSX = ten;
                data.HangSXes.InsertOnSubmit(kieu);
                data.SubmitChanges();
                return RedirectToAction("KieuSP");
            }
            return View();
        }
        public ActionResult SuaKieuSP(int id)
        {
            var sk = data.HangSXes.First(n => n.IdHangSX == id);
            if (sk == null)
            {
                Response.SubStatusCode = 404;
                return null;
            }
            return View(sk);
        }
        [HttpPost]
        public ActionResult SuaKieuSP(int id, FormCollection collection)
        {
            var kieu = data.HangSXes.First(n => n.IdHangSX == id);
            var ten = collection["TENKIEULOAISP"];
            var kt = data.HangSXes.ToList();
            foreach (var item in kt)
            {
                if (String.Compare(item.TenHangSX, ten, true) == 0 && item.IdHangSX != id)
                {
                    ViewData["Loi0"] = "Mã kiểu sản phẩm này đã tồn tại";
                    return this.SuaKieuSP(id);
                }
            }
            if (String.IsNullOrEmpty(ten))
            {
                ViewData["Loi1"] = "Tên kiểu sản phẩm không được để trống";
            }
            else
            {
                kieu.TenHangSX = ten;
                UpdateModel(kieu);
                data.SubmitChanges();
                return RedirectToAction("KieuSP");
            }
            return this.SuaKieuSP(id);
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