using BMDataAccess.Repository.IRepository;
using BMModel;
using BMModel.Areas;
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
        [BindProperty(SupportsGet = true)]
        public string OrgCity { get; set; }
        [BindProperty(SupportsGet = true)]
        public string DesCity { get; set; }
        public Advertise Advertise { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Keyword { get; set; }
        [BindProperty(SupportsGet = true)]
        public IEnumerable<Advertise> AdvertiseList { get; set; }
        public IndexModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task OnGet()
        {
            AdvertiseList = _unitOfWork.Advertise.GetAll(includeProperties: "Kind,Material,Origin,Destination," +
                "Origin.City,Destination.City,Origin.City.Country,Destination.City.Country",
                orderby: x => x.OrderByDescending(z => z.DateOfAdvertise));



            //for searchbox
            OriginCitieslist = _unitOfWork.City.GetAll().Select(x => new SelectListItem()
            {
                Text = x.Name
            });
            DestinationCitiesList = _unitOfWork.City.GetAll().Select(x => new SelectListItem()
            {
                Text = x.Name
            });

            if (Keyword==null && OrgCity== "- All Origin City -" && DesCity== "- All Destination City -")
            {
                AdvertiseList = _unitOfWork.Advertise.GetAll(includeProperties: "Kind,Material,Origin,Destination," +
                "Origin.City,Destination.City,Origin.City.Country,Destination.City.Country",
                orderby: x => x.OrderByDescending(z => z.DateOfAdvertise));
                TempData["warning"] = "The item was not found! Please try again";
            }
            else
            {
                if (Keyword!=null)
                {
                    AdvertiseList = AdvertiseList.Where((x => x.Title.Contains(Keyword.ToUpper()[0]) ||
                      x.Kind.Type.Contains(Keyword.ToUpper()[0]) ||
                      x.Material.Title.Contains(Keyword.ToUpper()[0])));
                }
                if (OrgCity!=null)
                {
                    AdvertiseList = AdvertiseList.Where(x => x.Origin.City.Name == OrgCity);
                }

                if (DesCity != null)
                {
                    AdvertiseList = AdvertiseList.Where(x => x.Destination.City.Name == DesCity);
                }
            }

        }

    }
}
