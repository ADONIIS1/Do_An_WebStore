using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebStoreFZF.Models
{
    public class SPVM
    {
        [Required(ErrorMessage = "Chọn kiểu sản phẩm ")]
        public int? IdKIEUSP { get; set; }
        public int IdSANPHAM { get; set; }
        public string TENSANPHAM { get; set; }
        public string MOTA { get; set; }
        public double DONGIA { get; set; }
        public int? ROM { get; set; }
        public int? RAM { get; set; }
        public string ANHBIA { get; set; }
        public List<SectionList1> SectionList1 { get; set; }
    }
    public class SectionList1
    {
        public string TENKIEUSANPHAM { get; set; }
        public string TENSANPHAM { get; set; }
        public int? IdKIEUSP { get; set; }
        public int IdSANPHAM { get; set; }
        public string MOTA { get; set; }
        public double DONGIA { get; set; }
        public int? ROM { get; set; }
        public int? RAM { get; set; }
        public string ANHBIA { get; set; }


    }
}