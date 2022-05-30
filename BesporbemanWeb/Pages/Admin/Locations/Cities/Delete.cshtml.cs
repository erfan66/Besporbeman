using BMDataAccess.Repository.IRepository;
using BMModel.Areas;
using BMModel.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BesporbemanWeb.Pages.Admin.Locations.Cities
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public City City { get; set; }
        public DeleteModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void OnGet(int id)
        {
            City = _unitOfWork.City.GetFirstOrDefault(x => x.Id == id);
        }
        public async Task<IActionResult> OnPost()
        {
            //if (ModelState.IsValid)
            //{
            //    _unitOfWork.City.Remove(City);
            //    _unitOfWork.Save();
            //    TempData["success"] = "City Deleted Successfully";
            //    return RedirectToPage("Index");
            //}
            //return Page();
            _unitOfWork.City.Remove(City);
            _unitOfWork.Save();
            TempData["success"] = "City Deleted Successfully";
            return RedirectToPage("Index");
        }
    }
}
