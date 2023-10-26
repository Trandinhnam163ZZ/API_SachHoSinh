using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public partial interface ISanPhamReposity
    {
        SanPhamMoDel GetDatabyID(string id);
        SanPhamMoDel GetName(string name);
        bool Create(SanPhamMoDel model);
        bool Update(SanPhamMoDel model);
        bool Delete(SanPhamMoDel model);

    }
}
