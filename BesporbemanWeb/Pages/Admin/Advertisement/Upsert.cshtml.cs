using BMDataAccess.Repository.IRepository;
using BMModel;
using BMUtility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BesporbemanWeb.Pages.Admin.Advertisement
{
    [BindProperties]
    public class UpsertModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public Advertise Advertise { get; set; }
        public IEnumerable<SelectListItem> KindList { get; set; }
        public IEnumerable<SelectListItem> MaterialList { get; set; }
        public IEnumerable<SelectListItem> OriginCitieslist { get; set; }
        public IEnumerable<SelectListItem> OriginCountriesList { get; set; }
        public IEnumerable<SelectListItem> DestinationCitieslist { get; set; }
        public IEnumerable<SelectListItem> DestinationCountriesList { get; set; }
        public UpsertModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            Advertise = new();
        }
        public void OnGet(int? id)
        {
            if (id != null)
            {
                //edit
                Advertise = _unitOfWork.Advertise.GetFirstOrDefault(x => x.Id == id);
            }
            KindList = _unitOfWork.Kind.GetAll().Select(c => new SelectListItem()
            {
                Text = c.Type,
                Value = c.Id.ToString()
            });
            MaterialList = _unitOfWork.Material.GetAll().Select(c => new SelectListItem()
            {
                Text = c.Title,
                Value = c.Id.ToString()
            });
            OriginCitieslist = _unitOfWork.City.GetAll().Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
            OriginCountriesList = _unitOfWork.Country.GetAll().Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
            DestinationCitieslist = _unitOfWork.City.GetAll().Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
            DestinationCountriesList = _unitOfWork.Country.GetAll().Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
        }
        public async Task<IActionResult> OnPost()
        {

            //Status
            if (Advertise.Id != 0)
            {
                if (Advertise.ValidityDate < DateTime.Now)
                {
                    Advertise.Status = SD.InValid;
                    _unitOfWork.Advertise.Update(Advertise);

                }
                else
                {
                    Advertise.Status = SD.Valid;
                    _unitOfWork.Advertise.Update(Advertise);
                }
                _unitOfWork.Save();
            }
            else if (Advertise.Id == 0)
            {
                if (Advertise.ValidityDate < DateTime.Now)
                {
                    Advertise.Status = SD.InValid;
                    _unitOfWork.Advertise.Add(Advertise);
                }
                else
                {
                    Advertise.Status = SD.Valid;
                    _unitOfWork.Advertise.Add(Advertise);
                }
                _unitOfWork.Save();
            }

            return RedirectToPage("./Index");
        }

    }
}
