using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebStoreFZF.Models
{
    public class SanPham
    {
        public int IdSANPHAM;
        public string TENSANPHAM;
        public string MOTA;

        [DisplayFormat(DataFormatString = ("{0:0,00}"), ApplyFormatInEditMode = false)]
        public double DONGIA;

        public int? ROM;
        public int? RAM;
        public string ANHBIA;
        public int? IdHangSX;
        public int? IdLOAISP;
    }
}