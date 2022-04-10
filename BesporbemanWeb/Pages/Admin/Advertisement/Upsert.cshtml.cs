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
        public IEnumerable<SelectListItem> Citieslist { get; set; }
        public IEnumerable<SelectListItem> CountriesList { get; set; }
        public UpsertModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            Advertise = new();
        }
        public void OnGet(int? id)
        {
            if (Advertise.Id!=0)
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
                Text=c.Title,
                Value=c.Id.ToString()
            });
            Citieslist = _unitOfWork.City.GetAll().Select(x => new SelectListItem()
            {
                Text=x.Name,
                Value=x.Id.ToString()
            });
            CountriesList = _unitOfWork.Country.GetAll().Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });

        }
        public async Task<IActionResult> OnPost()
        {
            //Status
            if (Advertise.ValidityDate < DateTime.Now && Advertise.Status != SD.InValid)
            {
                Advertise.Status = SD.InValid;
                _unitOfWork.Advertise.Update(Advertise);

            }
            else
            {
                Advertise.Status = SD.Valid;
                _unitOfWork.Advertise.Update(Advertise);
            }

            if (Advertise.Id==0)
            {
                _unitOfWork.Advertise.Add(Advertise);
                _unitOfWork.Save();
            }
            _unitOfWork.Advertise.Update(Advertise);
            _unitOfWork.Save();

            
            return RedirectToPage("./Index");
        }
        
    }
}
