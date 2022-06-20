using BMDataAccess.Repository.IRepository;
using BMModel.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BesporbemanWeb.Pages.Admin.Categories.Kinds
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public Kind Kind { get; set; }
        public CreateModel(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
            Kind = new();
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {

            string webRootPath = _webHostEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;

            string newFileName = Guid.NewGuid().ToString();
            var uploads = Path.Combine(webRootPath, @"images\kinds");
            var extension = Path.GetExtension(files[0].FileName);

            using (var fileStream = new FileStream(Path.Combine(uploads, newFileName + extension), FileMode.Create))
            {
                files[0].CopyTo(fileStream);
            }
            Kind.Image = @"\images\kinds\" + newFileName + extension;
            _unitOfWork.Kind.Add(Kind);
            _unitOfWork.Save();
            TempData["success"] = "Kind Created Successfully!";
            return RedirectToPage("./Index");
        }
    }
}
