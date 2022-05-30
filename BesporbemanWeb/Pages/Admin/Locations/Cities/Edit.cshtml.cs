using BMDataAccess.Repository.IRepository;
using BMModel.Areas;
using BMModel.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BesporbemanWeb.Pages.Admin.Locations.Cities
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public City City { get; set; }
        public IEnumerable<SelectListItem> CountriesList { get; set; }
        public EditModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void OnGet(int id)
        {
            City = _unitOfWork.City.GetFirstOrDefault(x => x.Id == id);
            CountriesList = _unitOfWork.Country.GetAll().Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
        }
        public async Task<IActionResult> OnPost()
        {

            //if (ModelState.IsValid)
            //{
            //    _unitOfWork.City.Update(City);
            //    _unitOfWork.Save();
            //    TempData["success"] = "City Updated Successfully!";
            //    return RedirectToPage("Index");
            //}
            //return Page();
            _unitOfWork.City.Update(City);
            _unitOfWork.Save();
            TempData["success"] = "City Updated Successfully!";
            return RedirectToPage("Index");
        }
    }
}
