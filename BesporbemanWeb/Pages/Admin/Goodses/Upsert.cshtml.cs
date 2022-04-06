using BMDataAccess.Repository.IRepository;
using BMModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BesporbemanWeb.Pages.Admin.Goodses
{
    public class UpsertModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public Goods Goods { get; set; }
        public IEnumerable<SelectListItem> KindList { get; set; }
        public IEnumerable<SelectListItem> MaterialList { get; set; }
        public UpsertModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            Goods = new();
        }
        public void OnGet(int? id)
        {
            if (Goods.Id!=0)
            {
                //edit
                Goods = _unitOfWork.Goods.GetFirstOrDefault(x => x.Id == id);
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
            if (Goods.Id==0)
            {
                _unitOfWork.Goods.Add(Goods);
                _unitOfWork.Save();
            }
            _unitOfWork.Goods.Update(Goods);
            _unitOfWork.Save();
            return RedirectToPage("./Index");
        }
        
    }
}
