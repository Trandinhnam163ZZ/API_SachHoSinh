using DataAcessLayer;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
   public class SanPhamBusiness:ISanPhamBusiness
    {
        private ISanPhamReposity _res;
        public SanPhamBusiness(ISanPhamReposity res)
        {
            _res = res;
        }
        public SanPhamMoDel GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public SanPhamMoDel GetName(string name)
        {
            return GetName(name);
        }
        public bool Create(SanPhamMoDel model)
        {
            return _res.Create(model);
        }
        public bool Update(SanPhamMoDel model)
        {
            return _res.Update(model);
        }
        public bool Delete(SanPhamMoDel model)
        { return _res.Delete(model);}

    }
}
