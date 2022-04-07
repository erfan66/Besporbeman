using BMDataAccess.Repository.IRepository;
using BMModel;
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
            
        }
        public async Task<IActionResult> OnPost()
        {
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
