using DataAcessLayer;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class KhachHangBusiness:IKhachHangBusiness
    {
        private IKhachHangReposity _res;
        public KhachHangBusiness(IKhachHangReposity res)
        {
            _res = res;
        }
        public KhachHangMoDel GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }

        public bool Create(KhachHangMoDel model)
        {
            return _res.Create(model);
        }

        public bool Update(KhachHangMoDel model) 
        { 
            return _res.Update(model);
        }
        public bool Delete(KhachHangMoDel model) {  return _res.Delete(model); }
    }
}
