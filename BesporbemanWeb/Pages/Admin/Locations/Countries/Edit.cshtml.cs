using BMDataAccess.Repository.IRepository;
using BMModel.Areas;
using BMModel.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BesporbemanWeb.Pages.Admin.Locations.Countries
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public Country Country { get; set; }
        public EditModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void OnGet(int id)
        {
            Country = _unitOfWork.Country.GetFirstOrDefault(x => x.Id == id);
        }
        public async Task<IActionResult> OnPost()
        {

            if (ModelState.IsValid)
            {
                _unitOfWork.Country.Update(Country);
                _unitOfWork.Save();
                TempData["success"] = "Country Updated Successfully!";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
