using BusinessLogicLayer;
using DataModel;
using Microsoft.AspNetCore.Mvc;

namespace AdMin_APISachHocSinh.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhachHangController:ControllerBase
    {
        private IKhachHangBusiness _khachhangBusiness;
        public KhachHangController(IKhachHangBusiness khachhangBusiness)
        {
            _khachhangBusiness = khachhangBusiness;
        }
        [Route("get-by-id/{id}")]

        [HttpGet]
        public KhachHangMoDel GetDatabyID(string id)
        {
            return _khachhangBusiness.GetDatabyID(id);
        }

        [Route("get-name/{name}")]

        [HttpGet]
        public KhachHangMoDel GetName(string name)
        {
            return _khachhangBusiness.GetName(name);
        }

        [Route("create-khachhang")]
        [HttpPost]
        public KhachHangMoDel CreateItem([FromBody] KhachHangMoDel model)
        {
            _khachhangBusiness.Create(model);
            return model;
        }

        [Route("update-khachhang")]
        [HttpPut]
        public KhachHangMoDel Update([FromBody] KhachHangMoDel model)
        {
            _khachhangBusiness.Update(model);
            return model;
        }

        [Route("delete-khachhang")]
        [HttpDelete]
        public KhachHangMoDel Delete([FromBody] KhachHangMoDel model)
        {
            _khachhangBusiness.Delete(model);
            return model;
        }
    }
}
