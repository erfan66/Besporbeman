using BMDataAccess.Repository.IRepository;
using BMModel.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BesporbemanWeb.Pages.Admin.Categories.Kinds
{
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public IEnumerable<Kind> AllKind { get; set; }
        public IndexModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void OnGet()
        {
            AllKind = _unitOfWork.Kind.GetAll();
        }
    }
}
