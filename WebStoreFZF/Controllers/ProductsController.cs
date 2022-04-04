using PagedList;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStoreFZF.Models;

namespace WebStoreFZF.Controllers
{
    public class ProductsController : Controller
    {
        MyDataContextDataContext data = new MyDataContextDataContext();
        // GET: Products


        public ActionResult ThongTin_DatMua(int id)
        {
            var D_SanPham = data.SANPHAMs.Where(m => m.IdSANPHAM == id).First();
            return View(D_SanPham);
        }




        #region Trang chủ
        public ActionResult AllProducts()
        {
            var all_products = LoadData();
            return View(all_products);
        }

        public List<SanPham> LoadData()
        {
            List<SanPham> lstSanPham = new List<SanPham>();
            var dienThoai = data.SANPHAMs.Where(m => m.HangSX.IdLOAISP == 1).Take(10).ToList();
            var lapTop = data.SANPHAMs.Where(m => m.HangSX.IdLOAISP == 2).Take(10).ToList();
            var PhuKien = data.SANPHAMs.Where(m => m.HangSX.IdLOAISP == 3).Take(10).ToList();

            foreach (var item in dienThoai)
            {
                SanPham sp = new SanPham();
                sp.IdSANPHAM = item.IdSANPHAM;
                sp.TENSANPHAM = item.TENSANPHAM;
                sp.MOTA = item.MOTA;
                sp.DONGIA = item.DONGIA;
                sp.ROM = item.ROM;
                sp.RAM = item.RAM;
                sp.ANHBIA = item.ANHBIA;
                sp.IdHangSX = item.IdHangSX;
                sp.IdLOAISP = item.HangSX.IdLOAISP;
                lstSanPham.Add(sp);
            }

            foreach (var item in lapTop)
            {
                SanPham sp = new SanPham();
                sp.IdSANPHAM = item.IdSANPHAM;
                sp.TENSANPHAM = item.TENSANPHAM;
                sp.MOTA = item.MOTA;
                sp.DONGIA = item.DONGIA;
                sp.ROM = item.ROM;
                sp.RAM = item.RAM;
                sp.ANHBIA = item.ANHBIA;
                sp.IdHangSX = item.IdHangSX;
                sp.IdLOAISP = item.HangSX.IdLOAISP;


                lstSanPham.Add(sp);
            }

            foreach (var item in PhuKien)
            {
                SanPham sp = new SanPham();
                sp.IdSANPHAM = item.IdSANPHAM;
                sp.TENSANPHAM = item.TENSANPHAM;
                sp.MOTA = item.MOTA;
                sp.DONGIA = item.DONGIA;
                sp.ROM = item.ROM;
                sp.RAM = item.RAM;
                sp.ANHBIA = item.ANHBIA;
                sp.IdHangSX = item.IdHangSX;
                sp.IdLOAISP = item.HangSX.IdLOAISP;

                lstSanPham.Add(sp);
            }
            return lstSanPham;
        }

        #endregion

        public ActionResult TrangTimKiem(int? page, string tk)
        {
            if (page == null) page = 1;
            var all_Laptop = data.SANPHAMs.Where(s => s.TENSANPHAM.ToLower().Contains("Iphone")).ToList();
            int pageSize = 20;
            int pageNum = page ?? 1;
            return View(all_Laptop.ToPagedList(pageNum, pageSize));
        }


        public List<SanPhamHangSX> ThemDuLieu()
        {
            List<SanPhamHangSX> lst = new List<SanPhamHangSX>();
            var sanPham = data.SANPHAMs.ToList();
            var hangSX = data.HangSXes.ToList();


            foreach (var item in hangSX)
            {
                SanPhamHangSX sp = new SanPhamHangSX();
                sp.IdSANPHAM = -1;
                sp.IdHangSX = item.IdHangSX;
                sp.IdLOAISP = item.IdLOAISP;
                sp.TenHangSX = item.TenHangSX;
                sp.hinh = item.hinh;
                lst.Add(sp);
            }

            foreach (var item in sanPham)
            {
                SanPhamHangSX sp = new SanPhamHangSX();
                sp.IdSANPHAM = item.IdSANPHAM;
                sp.TENSANPHAM = item.TENSANPHAM;
                sp.MOTA = item.MOTA;
                sp.DONGIA = item.DONGIA;
                sp.ROM = item.ROM;
                sp.RAM = item.RAM;
                sp.ANHBIA = item.ANHBIA;
                sp.IdHangSX = item.IdHangSX;
                sp.IdLOAISP = item.HangSX.IdLOAISP;
                lst.Add(sp);
            }


            return lst;
        }

        #region Hiện hãng sx

        public ActionResult HangSX_DienThoai()
        {
            var all_Laptop = data.SANPHAMs.Include(n => n.HangSX).Where(s => s.HangSX.IdLOAISP == 1).ToList();
            return View(all_Laptop);
        }

        public ActionResult HangSX_Laptop()
        {
            var all_Laptop = ThemDuLieu().Where(s => s.IdLOAISP == 2).ToList();
            return View(all_Laptop);
        }

        public ActionResult HangSX_PhuKien()
        {
            var all_Laptop = ThemDuLieu().Where(s => s.IdLOAISP == 3).ToList();
            return View(all_Laptop);
        }

        #endregion

        #region Điện thoại

        public ActionResult Phone(int? page)
        {
            if (page == null) page = 1;
            var all_Laptop = ThemDuLieu().Where(s => s.IdLOAISP == 1).ToList();
            int pageSize = 19;
            int pageNum = page ?? 1;
            return View(all_Laptop.ToPagedList(pageNum, pageSize));
        }

        public ActionResult LoaiDienThoai(int? page, int id)
        {
            if (page == null) page = 1;
            var all_Laptop = ThemDuLieu().Where(s => s.IdHangSX == id).ToList();
            int pageSize = 10;
            int pageNum = page ?? 1;
            return View(all_Laptop.ToPagedList(pageNum, pageSize));
        }



        #endregion

        #region Laptop
        public ActionResult Laptop(int? page)
        {
            if (page == null) page = 1;
            var all_Laptop = ThemDuLieu().Where(s => s.IdLOAISP == 2).ToList();
            int pageSize = 22;
            int pageNum = page ?? 1;
            return View(all_Laptop.ToPagedList(pageNum, pageSize));
        }

        public ActionResult LoaiLaptop(int? page, int id)
        {
            if (page == null) page = 1;
            var all_Laptop = ThemDuLieu().Where(s => s.IdHangSX == id).ToList();
            int pageSize = 10;
            int pageNum = page ?? 1;
            return View(all_Laptop.ToPagedList(pageNum, pageSize));
        }
        #endregion


        #region Phụ kiện

        public ActionResult Accessory(int? page)
        {
            if (page == null) page = 1;
            var all_Laptop = ThemDuLieu().Where(s => s.IdLOAISP == 3).ToList();
            int pageSize = 17;
            int pageNum = page ?? 1;
            return View(all_Laptop.ToPagedList(pageNum, pageSize));
        }

        public ActionResult LoaiPhuKien(int? page, int id)
        {
            if (page == null) page = 1;
            var all_Laptop = ThemDuLieu().Where(s => s.IdHangSX == id).ToList();
            int pageSize = 10;
            int pageNum = page ?? 1;
            return View(all_Laptop.ToPagedList(pageNum, pageSize));
        }

        #endregion

        #region Thêm, xóa , sửa sản phẩm

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection collection, SANPHAM s)
        {
            var TenSanPham = collection["TENSANPHAM"];
            var Mota = collection["MOTA"];
            var DonGia = Convert.ToDouble(collection["DONGIA"]);
            var SoLuongTon = Convert.ToInt32(collection["SOLUONGTON"]);
            var Rom = Convert.ToInt32(collection["ROM"]);
            var Ram = Convert.ToInt32(collection["RAM"]);
            var Anh = collection["ANHBIA"];
            var IDKieuSP = Convert.ToInt32(collection["IdKIEUSP"]);
            if (string.IsNullOrEmpty(TenSanPham))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                s.TENSANPHAM = TenSanPham.ToString();
                s.MOTA = Mota.ToString();
                s.DONGIA = DonGia;

                s.ROM = Rom;
                s.RAM = Ram;
                s.ANHBIA = Anh;
                s.IdHangSX = IDKieuSP;
                data.SANPHAMs.InsertOnSubmit(s);
                data.SubmitChanges();
                return RedirectToAction("AllProducts");
            }
            return this.Create();
        }

        public ActionResult Edit(int id)
        {
            var sanPham = data.SANPHAMs.First(m => m.IdSANPHAM == id);
            return View(sanPham);
        }
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var sanPham = data.SANPHAMs.First(m => m.IdSANPHAM == id);
            var TenSanPham = collection["TENSANPHAM"];
            var Mota = collection["MOTA"];
            var DonGia = Convert.ToDouble(collection["DONGIA"]);
            var SoLuongTon = Convert.ToInt32(collection["SOLUONGTON"]);
            var Rom = Convert.ToInt32(collection["ROM"]);
            var Ram = Convert.ToInt32(collection["RAM"]);
            var Anh = collection["ANHBIA"];
            var IDKieuSP = Convert.ToInt32(collection["IdKIEUSP"]);
            sanPham.IdSANPHAM = id;
            if (sanPham == null)
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                TenSanPham = sanPham.TENSANPHAM;
                Mota = sanPham.MOTA;
                DonGia = (double)sanPham.DONGIA;

                Rom = (int)sanPham.ROM;
                Ram = (int)sanPham.RAM;
                Anh = sanPham.ANHBIA;
                IDKieuSP = (int)sanPham.IdHangSX;
                UpdateModel(sanPham);
                data.SubmitChanges();
                return RedirectToAction("AllProducts");
            }
            return this.Edit(id);
        }




        public ActionResult Delete(int id)
        {
            var sanPham = data.SANPHAMs.First(m => m.IdSANPHAM == id);
            return View(sanPham);
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var D_sach = data.SANPHAMs.Where(m => m.IdSANPHAM == id).First();
            data.SANPHAMs.DeleteOnSubmit(D_sach);
            data.SubmitChanges();
            return RedirectToAction("AllProducts");
        }

        #endregion
    }
}