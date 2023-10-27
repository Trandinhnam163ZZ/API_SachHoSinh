using BusinessLogicLayer;
using DataModel;
using Microsoft.AspNetCore.Mvc;

namespace AdMin_APISachHocSinh.Controller
{

        [Route("api/[controller]")]
        [ApiController]
        public class HoaDonConTroller : ControllerBase
        {

            private IHoaDonBusiness _hoadonBusiness;
            public HoaDonConTroller(IHoaDonBusiness hoadonBusiness)
            {
                _hoadonBusiness = hoadonBusiness;
            }
            [Route("get-by-id/{id}")]

            [HttpGet]
            public HoaDonMoDel GetDatabyID(string id)
            {
                return _hoadonBusiness.GetDatabyID(id);
            }

            [Route("create-hoadon")]
            [HttpPost]
            public HoaDonMoDel CreateItem([FromBody] HoaDonMoDel model)
            {
                _hoadonBusiness.Create(model);
                return model;
            }

            [Route("update-hoadon")]
            [HttpPost]
            public HoaDonMoDel Update([FromBody] HoaDonMoDel model)
            {
                _hoadonBusiness.Create(model);
                return model;
            }

            [Route("delete-hoadon")]
            [HttpDelete]
            public HoaDonMoDel Delete(HoaDonMoDel model)
            {
                _hoadonBusiness.Delete(model);
                return model;
            }
        }
 }

