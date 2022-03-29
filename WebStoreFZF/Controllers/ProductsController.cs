using PagedList;
using System;
using System.Collections.Generic;
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

        public ActionResult AllProducts()
        {
            var all_products = data.SANPHAMs.Where(s => s.HangSX.IdLOAISP == 1).ToList();
            return View(all_products);
        }

        public ActionResult Laptop(int? page)
        {
            //var all_laptop = data.SANPHAMs.Where(s => s.IdKIEUSP == 2).ToList();
            //return View(all_laptop);
            if (page == null) page = 1;
            var all_Laptop = data.SANPHAMs.Where(s => s.HangSX.IdLOAISP == 1).ToList();
            int pageSize = 12;
            int pageNum = page ?? 1;
            return View(all_Laptop.ToPagedList(pageNum, pageSize));
        }


        public ActionResult Phone(int? page)
        {
            //var all_phone = data.SANPHAMs.Where(s => s.IdKIEUSP == 1).ToList();
            //return View(all_phone);
            if (page == null) page = 1;
            var all_phone = data.SANPHAMs.Where(s => s.HangSX.IdLOAISP == 1).ToList();
            int pageSize = 12;
            int pageNum = page ?? 1;
            return View(all_phone.ToPagedList(pageNum, pageSize));
        }

        public ActionResult Accessory(int? page)
        {
            //var all_accessory = data.SANPHAMs.Where(s => s.IdKIEUSP == 3).ToList();
            //return View(all_accessory);
            if (page == null) page = 1;
            var all_phone = data.SANPHAMs.Where(s => s.HangSX.IdLOAISP == 3).ToList();
            int pageSize = 12;
            int pageNum = page ?? 1;
            return View(all_phone.ToPagedList(pageNum, pageSize));
        }

        public ActionResult Phone_IPhone(int? page)
        {
            //var all_accessory = data.SANPHAMs.Where(s => s.IdKIEUSP == 3).ToList();
            //return View(all_accessory);
            if (page == null) page = 1;
            var all_phone = data.SANPHAMs.Where(s => s.IdHangSX == 1).ToList();
            int pageSize = 12;
            int pageNum = page ?? 1;
            return View(all_phone.ToPagedList(pageNum, pageSize));
        }

        public ActionResult Phone_SamSung(int? page)
        {
            //var all_accessory = data.SANPHAMs.Where(s => s.IdKIEUSP == 3).ToList();
            //return View(all_accessory);
            if (page == null) page = 1;
            var all_phone = data.SANPHAMs.Where(s => s.IdHangSX == 1).ToList();
            int pageSize = 12;
            int pageNum = page ?? 1;
            return View(all_phone.ToPagedList(pageNum, pageSize));
        }

        public ActionResult Phone_Oppo(int? page)
        {
            //var all_accessory = data.SANPHAMs.Where(s => s.IdKIEUSP == 3).ToList();
            //return View(all_accessory);
            if (page == null) page = 1;
            var all_phone = data.SANPHAMs.Where(s => s.IdHangSX == 1).ToList();
            int pageSize = 12;
            int pageNum = page ?? 1;
            return View(all_phone.ToPagedList(pageNum, pageSize));
        }

        public ActionResult Phone_ViVo(int? page)
        {
            //var all_accessory = data.SANPHAMs.Where(s => s.IdKIEUSP == 3).ToList();
            //return View(all_accessory);
            if (page == null) page = 1;
            var all_phone = data.SANPHAMs.Where(s => s.IdHangSX == 1).ToList();
            int pageSize = 12;
            int pageNum = page ?? 1;
            return View(all_phone.ToPagedList(pageNum, pageSize));
        }

        public ActionResult Phone_Xiaomi(int? page)
        {
            //var all_accessory = data.SANPHAMs.Where(s => s.IdKIEUSP == 3).ToList();
            //return View(all_accessory);
            if (page == null) page = 1;
            var all_phone = data.SANPHAMs.Where(s => s.IdHangSX == 1).ToList();
            int pageSize = 12;
            int pageNum = page ?? 1;
            return View(all_phone.ToPagedList(pageNum, pageSize));
        }

        public ActionResult Phone_Realme(int? page)
        {
            //var all_accessory = data.SANPHAMs.Where(s => s.IdKIEUSP == 3).ToList();
            //return View(all_accessory);
            if (page == null) page = 1;
            var all_phone = data.SANPHAMs.Where(s => s.IdHangSX == 1).ToList();
            int pageSize = 12;
            int pageNum = page ?? 1;
            return View(all_phone.ToPagedList(pageNum, pageSize));
        }

        public ActionResult Phone_Nokia(int? page)
        {
            //var all_accessory = data.SANPHAMs.Where(s => s.IdKIEUSP == 3).ToList();
            //return View(all_accessory);
            if (page == null) page = 1;
            var all_phone = data.SANPHAMs.Where(s => s.IdHangSX == 1).ToList();
            int pageSize = 12;
            int pageNum = page ?? 1;
            return View(all_phone.ToPagedList(pageNum, pageSize));
        }

        public ActionResult Phone_Mobell(int? page)
        {
            //var all_accessory = data.SANPHAMs.Where(s => s.IdKIEUSP == 3).ToList();
            //return View(all_accessory);
            if (page == null) page = 1;
            var all_phone = data.SANPHAMs.Where(s => s.IdHangSX == 1).ToList();
            int pageSize = 12;
            int pageNum = page ?? 1;
            return View(all_phone.ToPagedList(pageNum, pageSize));
        }
        public ActionResult Phone_Massel(int? page)
        {
            //var all_accessory = data.SANPHAMs.Where(s => s.IdKIEUSP == 3).ToList();
            //return View(all_accessory);
            if (page == null) page = 1;
            var all_phone = data.SANPHAMs.Where(s => s.IdHangSX == 1).ToList();
            int pageSize = 12;
            int pageNum = page ?? 1;
            return View(all_phone.ToPagedList(pageNum, pageSize));
        }

        public ActionResult Laptop_Macbook(int? page)
        {
            //var all_laptop = data.SANPHAMs.Where(s => s.IdKIEUSP == 2).ToList();
            //return View(all_laptop);
            if (page == null) page = 1;
            var all_Laptop = data.SANPHAMs.Where(s => s.IdHangSX == 1).ToList();
            int pageSize = 12;
            int pageNum = page ?? 1;
            return View(all_Laptop.ToPagedList(pageNum, pageSize));
        }

        public ActionResult Laptop_Asus(int? page)
        {
            //var all_laptop = data.SANPHAMs.Where(s => s.IdKIEUSP == 2).ToList();
            //return View(all_laptop);
            if (page == null) page = 1;
            var all_Laptop = data.SANPHAMs.Where(s => s.IdHangSX == 1).ToList();
            int pageSize = 12;
            int pageNum = page ?? 1;
            return View(all_Laptop.ToPagedList(pageNum, pageSize));
        }

        public ActionResult Laptop_hp(int? page)
        {
            //var all_laptop = data.SANPHAMs.Where(s => s.IdKIEUSP == 2).ToList();
            //return View(all_laptop);
            if (page == null) page = 1;
            var all_Laptop = data.SANPHAMs.Where(s => s.IdHangSX == 1).ToList();
            int pageSize = 12;
            int pageNum = page ?? 1;
            return View(all_Laptop.ToPagedList(pageNum, pageSize));
        }

        public ActionResult Laptop_Lenovo(int? page)
        {
            //var all_laptop = data.SANPHAMs.Where(s => s.IdKIEUSP == 2).ToList();
            //return View(all_laptop);
            if (page == null) page = 1;
            var all_Laptop = data.SANPHAMs.Where(s => s.IdHangSX == 1).ToList();
            int pageSize = 12;
            int pageNum = page ?? 1;
            return View(all_Laptop.ToPagedList(pageNum, pageSize));
        }

        public ActionResult Laptop_Acer(int? page)
        {
            //var all_laptop = data.SANPHAMs.Where(s => s.IdKIEUSP == 2).ToList();
            //return View(all_laptop);
            if (page == null) page = 1;
            var all_Laptop = data.SANPHAMs.Where(s => s.IdHangSX == 1).ToList();
            int pageSize = 12;
            int pageNum = page ?? 1;
            return View(all_Laptop.ToPagedList(pageNum, pageSize));
        }

        public ActionResult Laptop_Dell(int? page)
        {
            //var all_laptop = data.SANPHAMs.Where(s => s.IdKIEUSP == 2).ToList();
            //return View(all_laptop);
            if (page == null) page = 1;
            var all_Laptop = data.SANPHAMs.Where(s => s.IdHangSX == 1).ToList();
            int pageSize = 12;
            int pageNum = page ?? 1;
            return View(all_Laptop.ToPagedList(pageNum, pageSize));
        }

        public ActionResult Laptop_Msi(int? page)
        {
            //var all_laptop = data.SANPHAMs.Where(s => s.IdKIEUSP == 2).ToList();
            //return View(all_laptop);
            if (page == null) page = 1;
            var all_Laptop = data.SANPHAMs.Where(s => s.IdHangSX == 1).ToList();
            int pageSize = 12;
            int pageNum = page ?? 1;
            return View(all_Laptop.ToPagedList(pageNum, pageSize));
        }

        public ActionResult Laptop_Lg(int? page)
        {
            //var all_laptop = data.SANPHAMs.Where(s => s.IdKIEUSP == 2).ToList();
            //return View(all_laptop);
            if (page == null) page = 1;
            var all_Laptop = data.SANPHAMs.Where(s => s.IdHangSX == 1).ToList();
            int pageSize = 12;
            int pageNum = page ?? 1;
            return View(all_Laptop.ToPagedList(pageNum, pageSize));
        }

        public ActionResult Laptop_intel(int? page)
        {
            //var all_laptop = data.SANPHAMs.Where(s => s.IdKIEUSP == 2).ToList();
            //return View(all_laptop);
            if (page == null) page = 1;
            var all_Laptop = data.SANPHAMs.Where(s => s.IdHangSX == 1).ToList();
            int pageSize = 12;
            int pageNum = page ?? 1;
            return View(all_Laptop.ToPagedList(pageNum, pageSize));
        }

        public ActionResult Accessory_Apple(int? page)
        {
            //var all_accessory = data.SANPHAMs.Where(s => s.IdKIEUSP == 3).ToList();
            //return View(all_accessory);
            if (page == null) page = 1;
            var all_phone = data.SANPHAMs.Where(s => s.HangSX.IdLOAISP == 3).ToList();
            int pageSize = 12;
            int pageNum = page ?? 1;
            return View(all_phone.ToPagedList(pageNum, pageSize));
        }

        public ActionResult Accessory_Xiaomi(int? page)
        {
            //var all_accessory = data.SANPHAMs.Where(s => s.IdKIEUSP == 3).ToList();
            //return View(all_accessory);
            if (page == null) page = 1;
            var all_phone = data.SANPHAMs.Where(s => s.HangSX.IdLOAISP == 3).ToList();
            int pageSize = 12;
            int pageNum = page ?? 1;
            return View(all_phone.ToPagedList(pageNum, pageSize));
        }

        public ActionResult Accessory_SamSung(int? page)
        {
            //var all_accessory = data.SANPHAMs.Where(s => s.IdKIEUSP == 3).ToList();
            //return View(all_accessory);
            if (page == null) page = 1;
            var all_phone = data.SANPHAMs.Where(s => s.HangSX.IdLOAISP == 3).ToList();
            int pageSize = 12;
            int pageNum = page ?? 1;
            return View(all_phone.ToPagedList(pageNum, pageSize));
        }

        public ActionResult Accessory_Lg(int? page)
        {
            //var all_accessory = data.SANPHAMs.Where(s => s.IdKIEUSP == 3).ToList();
            //return View(all_accessory);
            if (page == null) page = 1;
            var all_phone = data.SANPHAMs.Where(s => s.HangSX.IdLOAISP == 3).ToList();
            int pageSize = 12;
            int pageNum = page ?? 1;
            return View(all_phone.ToPagedList(pageNum, pageSize));
        }

        public ActionResult Accessory_Asus(int? page)
        {
            //var all_accessory = data.SANPHAMs.Where(s => s.IdKIEUSP == 3).ToList();
            //return View(all_accessory);
            if (page == null) page = 1;
            var all_phone = data.SANPHAMs.Where(s => s.HangSX.IdLOAISP == 3).ToList();
            int pageSize = 12;
            int pageNum = page ?? 1;
            return View(all_phone.ToPagedList(pageNum, pageSize));
        }



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

        public ActionResult ThongTin_DatMua(int id)
        {
            var D_SanPham = data.SANPHAMs.Where(m => m.IdSANPHAM == id).First();
            return View(D_SanPham);
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
    }
}