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
        // GET: Laptop

        public ActionResult AllProducts()
        {
            var all_products = from p in data.SANPHAMs select p;
            return View(all_products);
        }

        public ActionResult Laptop()
        {
            var all_laptop = data.SANPHAMs.Where(s => s.KIEUSANPHAM.IdLOAISP == 2).ToList();
            return View(all_laptop);
        }

        public ActionResult Phone()
        {
            var all_phone = data.SANPHAMs.Where(s => s.KIEUSANPHAM.IdLOAISP == 1).ToList();
            return View(all_phone);
        }

        public ActionResult Accessory()
        {
            var all_accessory = data.SANPHAMs.Where(s => s.KIEUSANPHAM.IdLOAISP == 3).ToList();
            return View(all_accessory);
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
                s.SOLUONGTON = SoLuongTon;
                s.ROM = Rom;
                s.RAM = Ram;
                s.ANHBIA = Anh;
                s.IdKIEUSP = IDKieuSP;
                data.SANPHAMs.InsertOnSubmit(s);
                data.SubmitChanges();
                return RedirectToAction("AllProducts");
            }
            return this.Create();
        }

        public ActionResult Edit(int id)
        {
            var sanPham = data.SANPHAMs.First(m => m.IdSANPHAN == id);
            return View(sanPham);
        }
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var sanPham = data.SANPHAMs.First(m => m.IdSANPHAN == id);
            var TenSanPham = collection["TENSANPHAM"];
            var Mota = collection["MOTA"];
            var DonGia = Convert.ToDouble(collection["DONGIA"]);
            var SoLuongTon = Convert.ToInt32(collection["SOLUONGTON"]);
            var Rom = Convert.ToInt32(collection["ROM"]);
            var Ram = Convert.ToInt32(collection["RAM"]);
            var Anh = collection["ANHBIA"];
            var IDKieuSP = Convert.ToInt32(collection["IdKIEUSP"]);
            sanPham.IdSANPHAN = id;
            if (sanPham == null)
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                TenSanPham = sanPham.TENSANPHAM;
                Mota = sanPham.MOTA;
                DonGia = (double)sanPham.DONGIA;
                SoLuongTon = (int)sanPham.SOLUONGTON;
                Rom = (int)sanPham.ROM;
                Ram = (int)sanPham.RAM;
                Anh = sanPham.ANHBIA;
                IDKieuSP = (int)sanPham.IdKIEUSP;
                UpdateModel(sanPham);
                data.SubmitChanges();
                return RedirectToAction("AllProducts");
            }
            return this.Edit(id);
        }


        public ActionResult Delete(int id)
        {
            var sanPham = data.SANPHAMs.First(m => m.IdSANPHAN == id);
            return View(sanPham);
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var D_sach = data.SANPHAMs.Where(m => m.IdSANPHAN == id).First();
            data.SANPHAMs.DeleteOnSubmit(D_sach);
            data.SubmitChanges();
            return RedirectToAction("AllProducts");
        }
    }
}