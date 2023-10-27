using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public partial interface INhaXBReposity
    {
        NhaXBMoDel GetDatabyID(string id);
        NhaXBMoDel GetName(string name);
        bool Create(NhaXBMoDel model);
        bool Update(NhaXBMoDel model);
        bool Delete(NhaXBMoDel model);
    }
}
