using BusinessLogicLayer;
using DataModel;
using DataAcessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace API_SachHoSinh.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhaXBController:ControllerBase
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

        [Route("create-nhaxb")]
        [HttpPost]
        public NhaXBMoDel CreateItem([FromBody] NhaXBMoDel model)
        {
            _nhaxbBusiness.Create(model);
            return model;

        }


        [Route("update-nhaxb")]
        [HttpPost]
        public NhaXBMoDel Update([FromBody] NhaXBMoDel model)
        {
            _nhaxbBusiness.Update(model);
            return model;

        }

        [Route("delete-nhaxb")]
        [HttpPost]
        public NhaXBMoDel Delete([FromBody] NhaXBMoDel model)
        {
            _nhaxbBusiness.Delete(model);
            return model;

        }


    }
}
