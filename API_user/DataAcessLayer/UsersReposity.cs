using DataAccessLayer;
using DataAcessLayer.interfaces;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public class UsersReposity:IUsersReposity
    {
        private IDatabaseHelper _dbHelper;
        public UsersReposity(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }
        public UsersMoDel Login(string taikhoan, string matkhau)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_login",
                     "@taikhoan", taikhoan,
                     "@matkhau", matkhau
                     );
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<UsersMoDel>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        }
}
