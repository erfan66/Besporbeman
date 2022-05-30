using BMDataAccess.Repository.IRepository;
using BMUtility;
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
            var advertiseList = _unitOfWork.Advertise.GetAll(includeProperties: "Kind,Material,Origin,Destination,Origin.City,Destination.City");
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
        //[HttpPost("{id}")]
        //public IActionResult UpdateStatus(int id)
        //{
        //    var objFromDb = _unitOfWork.Advertise.GetFirstOrDefault(x => x.Id == id);
        //    //Status
        //    if (objFromDb.Id != 0)
        //    {
        //        if (objFromDb.ValidityDate < DateTime.Now)
        //        {
        //            objFromDb.Status = SD.InValid;
        //            _unitOfWork.Advertise.Update(objFromDb);

        //        }
        //        _unitOfWork.Save();
        //    }
        //    else if (objFromDb.Id == 0)
        //    {
        //        if (objFromDb.ValidityDate < DateTime.Now)
        //        {
        //            objFromDb.Status = SD.InValid;
        //            _unitOfWork.Advertise.Add(objFromDb);
        //        }
        //        else
        //        {
        //            objFromDb.Status = SD.Valid;
        //            _unitOfWork.Advertise.Add(objFromDb);
        //        }
        //        _unitOfWork.Save();
        //    }
        //    return Json(new { success = true });
        //}
    }
}
