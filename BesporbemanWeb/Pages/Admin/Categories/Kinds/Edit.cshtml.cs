using BMDataAccess.Repository.IRepository;
using BMModel.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BesporbemanWeb.Pages.Admin.Categories.Kinds
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public Kind Kind { get; set; }
        public EditModel(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }
        public void OnGet(int id)
        {
            Kind = _unitOfWork.Kind.GetFirstOrDefault(x => x.Id == id);
        }
        public async Task<IActionResult> OnPost(int id)
        {

            string webRootPath = _webHostEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;

            Kind = _unitOfWork.Kind.GetFirstOrDefault(x => x.Id == id);
            if (files.Count > 0)
            {
                string newFileName = Guid.NewGuid().ToString();
                var uploads = Path.Combine(webRootPath, @"images\kinds");
                var extension = Path.GetExtension(files[0].FileName);

                //delete old gif or picture
                var oldPicPath = Path.Combine(webRootPath, Kind.Image.TrimStart('\\'));
                if (System.IO.File.Exists(oldPicPath))
                {
                    System.IO.File.Delete(oldPicPath);
                }
                //upload
                using (var fileStream = new FileStream(Path.Combine(uploads, newFileName + extension), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }
                Kind.Image = @"\images\kinds\" + newFileName + extension;
            }
            _unitOfWork.Kind.Update(Kind);
            _unitOfWork.Save();
            TempData["success"] = "Kind Updated Successfully!";
            return RedirectToPage("./Index");


        }
    }
}
