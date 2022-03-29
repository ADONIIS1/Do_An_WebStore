using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStoreFZF.Models;

namespace WebStoreFZF.Controllers
{
    public class GioHangController : Controller
    {
        MyDataContextDataContext data = new MyDataContextDataContext();
        public List<GioHang> Laygiohang()
        {

            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if (lstGioHang == null)
            {
                lstGioHang = new List<GioHang>();
                Session["GioHang"] = lstGioHang;
            }
            return lstGioHang;
        }

        public ActionResult ThemGioHang(int id, string strURL)
        {
            List<GioHang> lstGiohang = Laygiohang();
            GioHang sanpham = lstGiohang.Find(n => n.IdSanPham == id);
            if (sanpham == null)
            {
                sanpham = new GioHang(id);
                lstGiohang.Add(sanpham);
                return Redirect(strURL);
            }
            else
            {
                sanpham.iSoluong++;
                return Redirect(strURL);
            }
        }

        public int TongSoLuong()
        {
            int tsl = 0;
            List<GioHang> lstGiohang = Session["GioHang"] as List<GioHang>;
            if (lstGiohang != null)
            {
                tsl = lstGiohang.Sum(n => n.iSoluong);
            }
            return tsl;
        }

        private int TongSoLuongSanPham()
        {
            int tsl = 0;
            List<GioHang> lstGiohang = Session["Giohang"] as List<GioHang>;
            if (lstGiohang != null)
            {
                tsl = lstGiohang.Count;
            }
            return tsl;
        }

        private double TongTien()
        {
            double tt = 0;
            List<GioHang> lstGiohang = Session["Giohang"] as List<GioHang>;
            if (lstGiohang != null)
            {
                tt = lstGiohang.Sum(n => n.dThanhtien);
            }
            return tt;
        }

        public ActionResult GioHang()
        {
            List<GioHang> lstGiohang = Laygiohang();
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = TongTien();
            ViewBag.Tongsoluongsanpham = TongSoLuongSanPham();
            return View(lstGiohang);
        }

        public ActionResult GioHangPartial()
        {
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = TongTien();
            ViewBag.Tongsoluongsanpham = TongSoLuongSanPham();
            return PartialView();
        }

        public ActionResult XoaGioHang(int id)
        {
            List<GioHang> lstGiohang = Laygiohang();
            GioHang sanpham = lstGiohang.SingleOrDefault(n => n.IdSanPham == id);
            if (sanpham != null)
            {
                lstGiohang.RemoveAll(n => n.IdSanPham == id);
                return RedirectToAction("Giohang");
            }
            return RedirectToAction("Giohang");
        }

        public ActionResult CapnhatGiohang(int id, FormCollection collection)
        {
            List<GioHang> lstGiohang = Laygiohang();
            GioHang sanpham = lstGiohang.SingleOrDefault(n => n.IdSanPham == id);
            if (sanpham != null)
            {
                sanpham.iSoluong = int.Parse(collection["txtSoLg"].ToString());
            }
            return RedirectToAction("GioHang");
        }

        public ActionResult XoaTatCaGioHang()
        {
            List<GioHang> lstGiohang = Laygiohang();
            lstGiohang.Clear();
            return RedirectToAction("GioHang");
        }

        [HttpGet]
        public ActionResult DatHang()
        {
            if (Session["TaiKhoan"] == null || Session["TaiKhoan"].ToString() == "")
            {
                return RedirectToAction("DangNhap", "NguoiDung");
            }
            if (Session["GioHang"] == null)
            {
                return RedirectToAction("Index", "Sach");
            }
            List<GioHang> lstGiohang = Laygiohang();
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = TongTien();
            ViewBag.Tongsoluongsanpham = TongSoLuongSanPham();
            return View(lstGiohang);
        }

        public ActionResult DatHang(FormCollection collection)
        {
            DONHANG dh = new DONHANG();
            TaiKhoan tk = (TaiKhoan)Session["TaiKhoan"];
            SANPHAM s = new SANPHAM();


            List<GioHang> gh = Laygiohang();
            var ngaygiao = String.Format("{0:dd/MM/yyyy}", collection["NgayGiao"]);

            dh.ID = tk.ID;
            dh.NGAYDAT = DateTime.Now;
            dh.TINHTRANG = 0;

            data.DONHANGs.InsertOnSubmit(dh);
            data.SubmitChanges();

            foreach (var item in gh)
            {
                CTDONHANG ctdh = new CTDONHANG();
                ctdh.IdDONHANG = dh.IdDONHANG;
                ctdh.SOLUONG = item.iSoluong;
                ctdh.IdSANPHAM = item.IdSanPham;
                ctdh.DONGIA = (double)item.DONGIA;
                s = data.SANPHAMs.Single(n => n.IdSANPHAM == item.IdSanPham);
                data.SubmitChanges();
                data.CTDONHANGs.InsertOnSubmit(ctdh);
            }

            data.SubmitChanges();
            Session["Giohang"] = null;
            return RedirectToAction("XacnhanDonhang", "GioHang");
        }
    }
}