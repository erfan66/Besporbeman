using BMDataAccess.Repository.IRepository;
using BMModel;
using BMModel.Categories;
using BMUtility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BesporbemanWeb.Pages.Customer.Home
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public IEnumerable<SelectListItem> OriginCitieslist { get; set; }
        public IEnumerable<SelectListItem> DestinationCitiesList { get; set; }
        public Advertise Advertise { get; set; }
        [BindProperty(SupportsGet =true)]
        public string Keyword { get; set; }
        public IEnumerable<Advertise> AdvertiseList { get; set; }
        public IEnumerable<Kind> KindList { get; set; }
        public IndexModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void OnGet()
        {
            AdvertiseList = _unitOfWork.Advertise.GetAll(includeProperties: "Kind,Material,Origin,Destination," +
                "Origin.City,Origin.Country,Destination.City,Destination.Country",
                orderby: x => x.OrderByDescending(z => z.DateOfAdvertise));
            KindList = _unitOfWork.Kind.GetAll();


            //for searchbox
            OriginCitieslist = _unitOfWork.City.GetAll().Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
            DestinationCitiesList = _unitOfWork.City.GetAll().Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });

            if (Keyword != null)
            {
                AdvertiseList = AdvertiseList.Where(x => x.Title.Contains(Keyword.ToUpper()[0]) ||
                  x.Kind.Type.Contains(Keyword.ToUpper()[0]) ||
                  x.Material.Title.Contains(Keyword.ToUpper()[0]));
            }
        }

    }
}
