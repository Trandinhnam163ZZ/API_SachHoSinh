using DataAccessLayer;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public class NhaXBReposity:INhaXBReposity
    {
        private IDatabaseHelper _dbHelper;

        public NhaXBReposity(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }
        public NhaXBMoDel GetDatabyID(string id)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_nhaxb_get_by_id",
                     "@MaNXB", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<NhaXBMoDel>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public NhaXBMoDel GetName(string name)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_nhaxb_getname",
                     "@TenNXB", name);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<NhaXBMoDel>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool Create(NhaXBMoDel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_nhaxb_create",
                "@MaNXB", model.MaNXB,
                "@TenNXB", model.TenNXB,
                "@DiaChi", model.DiaChi,
                "SoDienThoai", model.SoDienThoai);

                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(NhaXBMoDel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_nhaxb_update",
                "@MaNXB", model.MaNXB,
                "@TenNXB", model.TenNXB,
                "@DiaChi", model.DiaChi,
                "SoDienThoai", model.SoDienThoai);

                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(NhaXBMoDel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_delete_nhaxb",
                "@MaNXB", model.MaNXB);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
