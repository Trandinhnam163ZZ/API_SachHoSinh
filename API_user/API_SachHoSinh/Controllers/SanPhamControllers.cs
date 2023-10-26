using BusinessLogicLayer;
using DataModel;
using DataAcessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Api_SachHoSinh.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanPhamControllers : ControllerBase
    {
        private ISanPhamBusiness _sanphamBusiness;
        public SanPhamControllers(ISanPhamBusiness sanphamBusiness)
        {
            _sanphamBusiness = sanphamBusiness;
        }
        [Route("get-by-id/{id}")]

        [HttpGet]
        public SanPhamMoDel GetDatabyID(string id)
        {
            return _sanphamBusiness.GetDatabyID(id);
        }

        [Route("create-sanpham")]
        [HttpPost]
        public SanPhamMoDel CreateItem([FromBody] SanPhamMoDel model)
        {
            _sanphamBusiness.Create(model);
            return model;
        }
        [Route("update-sanpham")]
        [HttpPost]
        public SanPhamMoDel UpdateItem([FromBody] SanPhamMoDel model)
        {
            _sanphamBusiness.Update(model);
            return model;
        }
        
        [Route("delete-sanpham")]
        [HttpPost]
        public SanPhamMoDel Delete(SanPhamMoDel model)
        {
            _sanphamBusiness.Delete(model);
            return model;
        }

        [Route("search")]
        [HttpPost]
        public IActionResult Search([FromBody] Dictionary<string, object> formData)
        {
            try
            {
                var page = int.Parse(formData["page"].ToString());
                var pageSize = int.Parse(formData["pageSize"].ToString());
                string ten_sanpham = "";

                if (formData.Keys.Contains("ten_sanpham") && !string.IsNullOrEmpty(Convert.ToString(formData["ten_sanpham"]))) { ten_sanpham = Convert.ToString(formData["ten_sanpham"]); }
                string the_loai = "";
                if (formData.Keys.Contains("theloai") && !string.IsNullOrEmpty(Convert.ToString(formData["theloai"]))) { the_loai = Convert.ToString(formData["the_loai"]); }
                long total = 0;
                var data = _sanphamBusiness.Search(page, pageSize, out total, ten_sanpham, the_loai);
                return Ok(
                    new
                    {
                        TotalItems = total,
                        Data = data,
                        Page = page,
                        PageSize = pageSize
                    }
                    );
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
