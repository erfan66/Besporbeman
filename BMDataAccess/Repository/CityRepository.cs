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
    public class CityRepository : Repository<City>, ICityRepository
    {
        private readonly ApplicationDbContext _db;
        public CityRepository(ApplicationDbContext db):base (db)
        {
            _db = db;
        }
        public void Update(City city)
        {
            _db.City.Update(city);
        }
    }
}
