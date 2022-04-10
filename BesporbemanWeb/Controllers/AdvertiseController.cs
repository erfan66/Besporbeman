using BMDataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace BesporbemanWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertiseController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public AdvertiseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var advertiseList = _unitOfWork.Advertise.GetAll(includeProperties:"Kind,Material"); 
            return Json(new {data = advertiseList});
        }
    }
}
