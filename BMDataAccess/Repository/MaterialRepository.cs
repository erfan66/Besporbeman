using BMDataAccess.Data;
using BMDataAccess.Repository.IRepository;
using BMModel;
using BMModel.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMDataAccess.Repository
{
    public class MaterialRepository : Repository<Material>, IMaterialRepository
    {
        private readonly ApplicationDbContext _db;
        public MaterialRepository(ApplicationDbContext db):base (db)
        {
            _db = db;
        }

        public void Update(Material material)
        {
            _db.Material.Update(material);
        }
    }
}
