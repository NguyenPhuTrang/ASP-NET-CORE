using System;
using System.Collections.Generic;

#nullable disable

namespace Nguyen_Phu_Trang_DeSo2.Models
{
    public partial class BaiViet
    {
        public string MaBaiViet { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        public DateTime? NgayPost { get; set; }
    }
}
