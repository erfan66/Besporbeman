using BMDataAccess.Repository.IRepository;
using BMModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BesporbemanWeb.Pages.Admin.Categories.Goodses
{
    public class UpsertModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public Goods Goods { get; set; }
        public UpsertModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void OnGet()
        {
            
        }
    }
}
