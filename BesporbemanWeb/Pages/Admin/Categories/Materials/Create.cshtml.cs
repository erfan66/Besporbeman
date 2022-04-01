using BMDataAccess.Repository.IRepository;
using BMModel.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BesporbemanWeb.Pages.Admin.Categories.Materials
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public Material Material { get; set; }
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
                _unitOfWork.Material.Add(Material);
                _unitOfWork.Save();
                TempData["success"] = "Material Created Successfully!";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
