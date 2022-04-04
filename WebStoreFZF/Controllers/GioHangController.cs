using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStoreFZF.Models;
using WebStoreFZF.MoMo;
using WebTraSua.MoMo;

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
            if (Session["Accouts"] == null || Session["Accouts"].ToString() == "")
            {
                return RedirectToAction("Login", "Accounts");
            }
            if (Session["GioHang"] == null)
            {
                return RedirectToAction("AllProducts", "Products");
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
            TaiKhoan tk = (TaiKhoan)Session["Accouts"];
            SANPHAM s = new SANPHAM();

            if (collection["type"] == "cod")
            {
                List<GioHang> gh = Laygiohang();


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
            }
            else
            {
                //request params need to request to MoMo system
                string endpoint = "https://test-payment.momo.vn/gw_payment/transactionProcessor";
                string partnerCode = "MOMOV7Z220220402";
                string accessKey = "8tnKdJLoTI72htiB";
                string serectkey = "whxqk45Vq6RJHimJuBy6sAFqMPQt6rug";
                string orderInfo = "Thanh Toán Store";
                string host = Request.Url.AbsoluteUri.Replace(Request.Url.PathAndQuery, "");
                string returnUrl = host + "/ReturnMoMo";
                string notifyurl = host + "/NotifyMoMo";
                string amount = TongTien().ToString();
                string orderid = Guid.NewGuid().ToString();
                string requestId = Guid.NewGuid().ToString();
                string extraData = "";


                //Before sign HMAC SHA256 signature
                string rawHash = "partnerCode=" +
                    partnerCode + "&accessKey=" +
                    accessKey + "&requestId=" +
                    requestId + "&amount=" +
                    amount + "&orderId=" +
                    orderid + "&orderInfo=" +
                    orderInfo + "&returnUrl=" +
                    returnUrl + "&notifyUrl=" +
                    notifyurl + "&extraData=" +
                    extraData;

                MoMoSecurity crypto = new MoMoSecurity();
                //sign signature SHA256
                string signature = crypto.signSHA256(rawHash, serectkey);

                //build body json request
                JObject message = new JObject
            {
                { "partnerCode", partnerCode },
                { "accessKey", accessKey },
                { "requestId", requestId },
                { "amount", amount },
                { "orderId", orderid },
                { "orderInfo", orderInfo },
                { "returnUrl", returnUrl },
                { "notifyUrl", notifyurl },
                { "extraData", extraData },
                { "requestType", "captureMoMoWallet" },
                { "signature", signature }

            };

                string responseFromMomo = PaymentRequest.sendPaymentRequest(endpoint, message.ToString());

                JObject jmessage = JObject.Parse(responseFromMomo);

                return Redirect(jmessage.GetValue("payUrl").ToString());
            }

            return RedirectToAction("NotifForm", "Accounts", new { title = "Thanh Toán Thành Công", msg = "Vui lòng check mail để xác nhận Mail!" });

        }
    }

}