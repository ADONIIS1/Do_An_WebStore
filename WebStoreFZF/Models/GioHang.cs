using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebStoreFZF.Models
{
    public class GioHang
    {
        MyDataContextDataContext data = new MyDataContextDataContext();
        public int IdSanPham { get; set; }

        [Display(Name = "Tên sản phẩm")]
        public string TENSANPHAM { get; set; }

        [Display(Name = "Mô tả")]
        public string MOTA { get; set; }

        [Display(Name = "Đơn giá")]
        public double DONGIA { get; set; }

        [Display(Name = "Rom")]
        public int ROM { get; set; }

        [Display(Name = "Ram")]
        public int RAM { get; set; }

        [Display(Name = "Ảnh bìa")]
        public string ANHBIA { get; set; }

        [Display(Name = "Id hãng sản xuất")]
        public int IdHangSX { get; set; }

        [Display(Name = "Ảnh bìa")]
        public int iSoluong { get; set; }

        [Display(Name = "Id hãng sản xuất")]
        public double dThanhtien
        {
            get { return iSoluong * DONGIA; }
        }

        public GioHang(int id)
        {
            IdSanPham = id;
            SANPHAM sp = data.SANPHAMs.Single(m => m.IdSANPHAM == IdSanPham);
            TENSANPHAM = sp.TENSANPHAM;
            MOTA = sp.MOTA;
            DONGIA = double.Parse(sp.DONGIA.ToString());
            ROM = int.Parse(sp.ROM.ToString());
            RAM = int.Parse(sp.RAM.ToString());
            ANHBIA = sp.ANHBIA;
            IdHangSX = int.Parse(sp.IdHangSX.ToString());
        }
    }
}