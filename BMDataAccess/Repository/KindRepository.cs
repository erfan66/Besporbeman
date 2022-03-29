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
    public class KindRepository : Repository<Kind>, IKindRepository
    {
        private readonly ApplicationDbContext _db;
        public KindRepository(ApplicationDbContext db):base (db)
        {
            _db = db;
        }

        public void Update(Kind kind)
        {
            _db.Kind.Update(kind);
        }
    }
}
