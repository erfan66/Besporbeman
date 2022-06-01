using BMDataAccess.Repository.IRepository;
using BMModel;
using BMUtility;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BesporbemanWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertiseController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public IEnumerable<Advertise>? AdvertiseList { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public AdvertiseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var claimIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);

            if (User.IsInRole(SD.ManagerRole))
            {
                AdvertiseList = _unitOfWork.Advertise.GetAll(includeProperties: "Kind,Material,Origin,Destination,Origin.City,Destination.City");

            }
            else if (User.IsInRole(SD.CustomerRole))
            {
                AdvertiseList = _unitOfWork.Advertise.GetAll(x=> ApplicationUser.Id==claim.Value ,
                    includeProperties: "Kind,Material,Origin,Destination,Origin.City,Destination.City");
            }
            return Json(new { data = AdvertiseList });
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
