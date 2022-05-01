using BMDataAccess.Repository.IRepository;
using BMModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BesporbemanWeb.Pages.Customer.Home
{
    public class DetailsModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public DetailsModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Advertise Advertise { get; set; }
        public void OnGet(int id)
        {
            Advertise = _unitOfWork.Advertise.GetFirstOrDefault(x => x.Id == id, includeProperties:
                "Kind,Material,Origin,Destination,Origin.City,Origin.Country,Destination.City,Destination.Country");
        }
    }
}
