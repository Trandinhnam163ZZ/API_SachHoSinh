using BusinessLogicLayer;
using DataAcessLayer;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class HoaDonBusiness: IHoaDonBusiness
    {
        private IHoaDonReposity _res;
        public HoaDonBusiness(IHoaDonReposity res)
        {
            _res = res;
        }
        public HoaDonMoDel GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }

        public bool Create(HoaDonMoDel model)
        {
            return _res.Create(model);
        }

        public bool Update(HoaDonMoDel model)
        {
            return _res.Update(model);
        }

        public bool Delete(HoaDonMoDel model)
        {
            return _res.Delete(model);
        }
    }
}
