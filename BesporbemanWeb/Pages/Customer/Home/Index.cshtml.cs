using BMDataAccess.Repository.IRepository;
using BMModel;
using BMModel.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BesporbemanWeb.Pages.Customer.Home
{
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public IEnumerable<Advertise> AdvertiseList { get; set; }
        public IEnumerable<Kind> KindList { get; set; }
        public IndexModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void OnGet()
        {
            AdvertiseList = _unitOfWork.Advertise.GetAll(includeProperties: "Kind,Material,Country,City");
            KindList = _unitOfWork.Kind.GetAll();
        }
    }
}
