using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.interfaces
{
    public partial interface IUsersReposity
    {
        UsersMoDel Login(string taikhoan, string matkhau);
    }
}
