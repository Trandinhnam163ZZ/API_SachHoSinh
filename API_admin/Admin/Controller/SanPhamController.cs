using BusinessLogicLayer;
using DataModel;
using Microsoft.AspNetCore.Mvc;

namespace AdMin_APISachHocSinh.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanPhamController : ControllerBase
    {
        private ISanPhamBusiness _sanphamBusiness;
        public SanPhamController(ISanPhamBusiness sanPhamBusiness)
        {
            _sanphamBusiness = sanPhamBusiness;
        }
        [Route("get-by-id/{id}")]

        [HttpGet]
        public SanPhamMoDel GetDatabyID(string id)
        {
            return _sanphamBusiness.GetDatabyID(id);
        }
        [Route("getname/{name}")]
        [HttpGet]
        public SanPhamMoDel GetName(string name)
        {
            return _sanphamBusiness.GetName(name);
        }

        [Route("create-sanpham")]
        [HttpPost]
        public SanPhamMoDel CreateItem([FromBody]SanPhamMoDel model)
        {
              _sanphamBusiness.Create(model);
            return model;
        }

        [Route("update-sanpham")]
        [HttpPut]
        public SanPhamMoDel Update([FromBody] SanPhamMoDel model)
        {
            _sanphamBusiness.Update(model);
            return model;
        }

        [Route("delete-sanpham")]
        [HttpDelete]
        public SanPhamMoDel Delete([FromBody] SanPhamMoDel model)
        {
            _sanphamBusiness.Delete(model);
            
            return model;
        }




    }
}
  
