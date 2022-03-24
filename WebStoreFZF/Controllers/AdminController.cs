using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
           
            HangSanXuatVM model = new HangSanXuatVM();
            ViewBag.IdLoaiSP = new System.Web.Mvc.SelectList((from p in data.LOAISANPHAMs
                                                              select p).ToList(), "IdLOAISP", "TENLOAISP", model.IdLOAISP);
            if(ViewBag.IdLoaiSP == null)
            {
                var sectionlist = (from p in data.HangSXes

                                   select new SectionList
                                   {
                                       IdKIEUSP = p.IdHangSX,
                                       TENKIEUSANPHAM = p.TenHangSX,
                                       TENLOAISANPHAM = p.LOAISANPHAM.TENLOAISP
                                   }).ToList();
                model.SectionList = sectionlist;
            }   
            else
            {
                var sectionlist = (from p in data.HangSXes
                                   where p.IdLOAISP == model.IdLOAISP
                                   select new SectionList
                                   {
                                       IdKIEUSP = p.IdHangSX,
                                       TENKIEUSANPHAM = p.TenHangSX,
                                       TENLOAISANPHAM = p.LOAISANPHAM.TENLOAISP
                                   }).ToList();
                model.SectionList = sectionlist;
            }              
           
            
            return View(model);
        }
        [HttpGet]
        public ActionResult ThemKieuSP()
        {
            HangSanXuatVM model = new HangSanXuatVM();
            ViewBag.IdLoaiSP = new System.Web.Mvc.SelectList((from p in data.LOAISANPHAMs
                                                              select p).ToList(), "IdLOAISP", "TENLOAISP");
            return View(model);
        }
        [HttpPost]
        public ActionResult ThemKieuSP(HangSanXuatVM model)
        {
            if (ModelState.IsValid)
            {
                HangSX kieu = new HangSX();
                kieu.TenHangSX = model.TENKIEUSANPHAM;
                kieu.IdLOAISP = model.IdLOAISP;
                data.HangSXes.InsertOnSubmit(kieu);
                data.SubmitChanges();
            }

            return RedirectToAction("HangSanXuat");
        }
        public ActionResult SuaKieuSP(int id)
        {
            HangSanXuatVM model = new HangSanXuatVM();
            var timkieu = data.HangSXes.First(n => n.IdHangSX == id);            
            model.IdKIEUSP = timkieu.IdHangSX;
            model.TENKIEUSANPHAM = timkieu.TenHangSX;
            model.IdLOAISP = timkieu.IdLOAISP;
            ViewBag.IdLoaiSP = new System.Web.Mvc.SelectList((from p in data.LOAISANPHAMs
                                                              select p).ToList(), "IdLOAISP", "TENLOAISP", model.IdLOAISP);
            return View(model);
        }
        [HttpPost]
        public ActionResult SuaKieuSP(HangSanXuatVM model)
        {
            if (ModelState.IsValid)
            {
                var kieu = data.HangSXes.First(n => n.IdHangSX == model.IdKIEUSP);            
                kieu.TenHangSX = model.TENKIEUSANPHAM;
                kieu.IdLOAISP = model.IdLOAISP;
                UpdateModel(kieu);
                data.SubmitChanges();
            }
            return RedirectToAction("HangSanXuat");
        }
        public ActionResult XoaKieuSP(int id)
        {
            HangSX xk = data.HangSXes.SingleOrDefault(n => n.IdHangSX == id);
            if (xk == null)
            {
                Response.SubStatusCode = 404;
                return null;
            }
            data.HangSXes.DeleteOnSubmit(xk);
            data.SubmitChanges();
            return RedirectToAction("HangSanXuat");
        }
        public ActionResult MatHang()
        {
            var sp = data.SANPHAMs.ToList();
            return View();
        }
        public ActionResult ThemSP()
        {
            SPVM model = new SPVM();
            ViewBag.IdKIEUSP = new System.Web.Mvc.SelectList((from p in data.HangSXes
                                                              select p).ToList(), "IdKIEUSP", "TENKIEUSANPHAM");
            return View(model);
        }
        [HttpPost]
        public ActionResult ThemSP(SPVM model)
        {
            if (ModelState.IsValid)
            {
                SANPHAM sp = new SANPHAM();
                sp.TENSANPHAM = model.TENSANPHAM;
                sp.MOTA = model.MOTA;
                sp.DONGIA = model.DONGIA;
                sp.ROM = model.ROM;
                sp.RAM = model.RAM;
                sp.ANHBIA = model.ANHBIA;
                sp.IdSANPHAM = model.IdSP;
                data.SANPHAMs.InsertOnSubmit(sp);
                data.SubmitChanges();
            }

            return RedirectToAction("MatHang");
        }
        public ActionResult SuaSP(int id)
        {
            SPVM model = new SPVM();
            var timsp = data.SANPHAMs.First(n => n.IdSANPHAM == id);
            model.IdSP = timsp.IdSANPHAM;
            model.TENSANPHAM = timsp.TENSANPHAM;
            model.IdKIEUSP = timsp.IdHangSX;
            ViewBag.IdLoaiSP = new System.Web.Mvc.SelectList((from p in data.HangSXes
                                                              select p).ToList(), "IdKIEUSP", "TENKIEUSANPHAM", model.IdKIEUSP);
            return View(model);
        }
        [HttpPost]
        public ActionResult SuaSP(SPVM model)
        {
            if (ModelState.IsValid)
            {
                var sp = data.SANPHAMs.First(n => n.IdSANPHAM == model.IdKIEUSP);
                sp.TENSANPHAM = model.TENSANPHAM;
                sp.IdHangSX = model.IdKIEUSP;
                UpdateModel(sp);
                data.SubmitChanges();
            }

            return RedirectToAction("MatHang");
        }
        public ActionResult XoaSP(int id)
        {
            SANPHAM xs = data.SANPHAMs.SingleOrDefault(n => n.IdSANPHAM == id);
            if (xs == null)
            {
                Response.SubStatusCode = 404;
                return null;
            }
            data.SANPHAMs.DeleteOnSubmit(xs);
            data.SubmitChanges();
            return RedirectToAction("MatHang");
        }
        public ActionResult KhachHang()
        {
            return View();
        }
    }
}