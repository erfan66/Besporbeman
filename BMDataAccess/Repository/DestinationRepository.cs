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
    public class DestinationRepository : Repository<Destination>, IDestinationRepository
    {
        private readonly ApplicationDbContext _db;
        public DestinationRepository(ApplicationDbContext db):base (db)
        {
            _db = db;
        }
        public void Update(Destination destination)
        {
            _db.Destination.Update(destination);
        }
    }
}
