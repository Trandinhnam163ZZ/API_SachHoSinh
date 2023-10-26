using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public partial interface IHoaDonBusiness
    {
        HoaDonMoDel GetDatabyID(string id);

        bool Create(HoaDonMoDel model);
        bool Update(HoaDonMoDel model);
        bool Delete(HoaDonMoDel model);
    }

}
