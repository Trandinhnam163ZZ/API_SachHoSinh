using BusinessLogicLayer;
using DataModel;
using Microsoft.AspNetCore.Mvc;

namespace AdMin_APISachHocSinh.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhaXBController : ControllerBase
    {

        private INhaXBBusiness _nhaxbBusiness;
        public NhaXBController(INhaXBBusiness nhaxbBusiness)
        {
            _nhaxbBusiness = nhaxbBusiness;
        }
        [Route("get-by-id/{id}")]

        [HttpGet]
        public NhaXBMoDel GetDatabyID(string id)
        {
            return _nhaxbBusiness.GetDatabyID(id);
        }


        [Route("get-name /{name}")]

        [HttpGet]
        public NhaXBMoDel GetName(string name)
        {
            return _nhaxbBusiness.GetName(name);
        }

        [Route("create-nhaxb")]
        [HttpPost]
        public NhaXBMoDel CreateItem([FromBody] NhaXBMoDel model)
        {
            _nhaxbBusiness.Create(model);
            return model;

        }


        [Route("update-nhaxb")]
        [HttpPut]
        public NhaXBMoDel Update([FromBody] NhaXBMoDel model)
        {
            _nhaxbBusiness.Update(model);
            return model;

        }

        [Route("delete-nhaxb")]
        [HttpDelete]
        public NhaXBMoDel Delete([FromBody] NhaXBMoDel model)
        {
            _nhaxbBusiness.Delete(model);
            return model;

        }


    }
}
