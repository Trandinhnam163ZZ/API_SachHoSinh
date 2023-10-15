using DataAcessLayer;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class NhaXBBusiness:INhaXBBusiness
    {
        private INhaXBReposity _res;
        public NhaXBBusiness(INhaXBReposity res)
        {
            _res = res;
        }
        public NhaXBMoDel GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public bool  Create(NhaXBMoDel model)
        {
            return _res.Create(model);
        }
        public bool Update(NhaXBMoDel model) 
        {
          return _res.Update(model);
        }
        public bool Delete(NhaXBMoDel model)
        { return _res.Delete(model); }
    }
}
