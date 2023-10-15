using BusinessLogicLayer;
using DataModel;
using DataAcessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Api_SachHoSinh.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhachHangControllers : ControllerBase
    {
        private IKhachHangBusiness _khachhangBusiness;
        public KhachHangControllers(IKhachHangBusiness khachhangBusiness)
        {
            _khachhangBusiness = khachhangBusiness;
        }
        [Route("get-by-id/{id}")]

        [HttpGet]
        public KhachHangMoDel GetDatabyID(string id)
        {
            return _khachhangBusiness.GetDatabyID(id);
        }

        [Route("create-khachhang")]
        [HttpPost]
        public KhachHangMoDel CreateItem([FromBody] KhachHangMoDel model)
        {
            _khachhangBusiness.Create(model);
            return model;
        }

        [Route("update-khachhang")]
        [HttpPost]
        public KhachHangMoDel Update([FromBody] KhachHangMoDel model)
        {
            _khachhangBusiness.Update(model);
            return model;
        }

        [Route("delete-khachhang")]
        [HttpPost]
        public KhachHangMoDel Delete([FromBody] KhachHangMoDel model)
        {
            _khachhangBusiness.Delete(model);
            return model;
        }
    }
}