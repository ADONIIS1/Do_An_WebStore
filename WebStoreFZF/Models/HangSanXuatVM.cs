using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebStoreFZF.Models
{
    public class HangSanXuatVM
    {
        [Required(ErrorMessage = "Chọn Loại sản phẩm ")]
        public int? IdLOAISP { get; set; }
        public int IdKIEUSP { get; set; }

        public string TENKIEUSANPHAM { get; set; }
        public List<SectionList> SectionList { get; set; }
    }

    public class SectionList
    {
        public string TENKIEUSANPHAM { get; set; }
        public string TENLOAISANPHAM { get; set; }
        public int IdKIEUSP { get; set; }
        public int? IdLOAISP { get; set; }


    }
    
}