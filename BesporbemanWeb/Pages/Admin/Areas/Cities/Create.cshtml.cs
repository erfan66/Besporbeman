using BMDataAccess.Repository.IRepository;
using BMModel.Areas;
using BMModel.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BesporbemanWeb.Pages.Admin.Areas.Cities
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public City City { get; set; }
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
                _unitOfWork.City.Add(City);
                _unitOfWork.Save();
                TempData["success"] = "City Created Successfully!";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
