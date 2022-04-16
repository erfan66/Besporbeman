using BMDataAccess.Data;
using BMDataAccess.Repository.IRepository;
using BMModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMDataAccess.Repository
{
    public class AdvertiseRepository : Repository<Advertise>, IAdvertiseRepository
    {
        private readonly ApplicationDbContext _db;
        public AdvertiseRepository(ApplicationDbContext db):base (db)
        {
            _db = db;
        }
        public void Update(Advertise advertise)
        {
            _db.Advertise.Update(advertise);
        }

        public void UpdateStatus(int id, string status)
        {
            var adFromDb = _db.Advertise.FirstOrDefault(x => x.Id == id);
            if (adFromDb!=null)
            {
                adFromDb.Status = status;
            }
        }
    }
}
