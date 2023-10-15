using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public partial interface  IHoaDonReposity
    {
        HoaDonMoDel GetDatabyID(string id);
        bool Create(HoaDonMoDel model);

        bool Update(HoaDonMoDel model);     
        bool Delete(HoaDonMoDel model);
    }
}
