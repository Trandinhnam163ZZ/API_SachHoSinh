using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public partial interface INhaXBBusiness
    {
        NhaXBMoDel GetDatabyID(string id);
        bool Create(NhaXBMoDel model);
        bool Update(NhaXBMoDel model);
        bool Delete(NhaXBMoDel model);
    }
}
