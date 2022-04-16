using BMDataAccess.Repository.IRepository;
using BMModel;
using BMModel.Categories;
using BMUtility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BesporbemanWeb.Pages.Customer.Home
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public Advertise Advertise { get; set; }
        public IEnumerable<Advertise> AdvertiseList { get; set; }
        public IEnumerable<Kind> KindList { get; set; }
        public IndexModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void OnGet()
        {
            AdvertiseList = _unitOfWork.Advertise.GetAll(includeProperties: "Kind,Material,Country,City",
                orderby:x=>x.OrderByDescending(z=> z.DateOfAdvertise));
            KindList = _unitOfWork.Kind.GetAll();
        }
        
    }
}
