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
            var advertiseList = _unitOfWork.Advertise.GetAll(includeProperties: "ApplicationUser,Kind,Material,Origin,Destination,Origin.City,Origin.Country,Destination.City,Destination.Country");
            return Json(new { data = advertiseList });
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Advertise.GetFirstOrDefault(x => x.Id == id);
            _unitOfWork.Advertise.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful." });
        }
    }
}
