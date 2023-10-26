using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class SanPhamMoDel
    {
        public int MaSanPham {  get; set; }
        public string TenSanPham {  set; get; }
        public string TheLoai { get; set; }
        public float Gia {  get; set; }
        public float GiaGiam {  get; set; }
        public string TrangThai {  get; set; }
    }
}
