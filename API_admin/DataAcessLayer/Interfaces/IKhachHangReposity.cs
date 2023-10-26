using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public partial interface IKhachHangReposity
    {
        KhachHangMoDel GetDatabyID(string id);
        KhachHangMoDel GetName(string name);
        bool Create(KhachHangMoDel model);
        bool Update(KhachHangMoDel model);
        bool Delete(KhachHangMoDel model);       
        
    }
}
