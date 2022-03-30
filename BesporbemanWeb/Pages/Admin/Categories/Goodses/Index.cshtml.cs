using BMDataAccess.Repository.IRepository;
using BMModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BesporbemanWeb.Pages.Admin.Categories.Goodses
{
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public IEnumerable<Goods> AllGoods { get; set; }
        public IndexModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void OnGet()
        {
            AllGoods = _unitOfWork.Goods.GetAll(includeProperties: "Kind,Material");
        }
    }
}
