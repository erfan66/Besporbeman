using BMDataAccess.Repository.IRepository;
using BMModel.Areas;
using BMModel.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BesporbemanWeb.Pages.Admin.Areas.Countries
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public Country Country { get; set; }
        public CreateModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
           
            if (ModelState.IsValid)
            {
                _unitOfWork.Country.Add(Country);
                _unitOfWork.Save();
                TempData["success"] = "Country Created Successfully!";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
