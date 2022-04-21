using BMDataAccess.Data;
using BMDataAccess.Repository.IRepository;
using BMModel;
using BMModel.Areas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMDataAccess.Repository
{
    public class OriginRepository : Repository<Origin>, IOriginRepository
    {
        private readonly ApplicationDbContext _db;
        public OriginRepository(ApplicationDbContext db):base (db)
        {
            _db = db;
        }
        public void Update(Origin origin)
        {
            _db.Origin.Update(origin);
        }
    }
}
