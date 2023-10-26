using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public partial interface ISanPhamBusiness
    {
        SanPhamMoDel GetDatabyID(string id);
        bool Create(SanPhamMoDel model);
        bool Update(SanPhamMoDel model);
        bool Delete(SanPhamMoDel model);
        public List<SanPhamMoDel> Search(int pageIndex, int pageSize, out long total, string ten_sanpham,string the_loai);
    }
}
