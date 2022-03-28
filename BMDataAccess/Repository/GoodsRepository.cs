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
    public class GoodsRepository : Repository<Goods>, IGoodsRepository
    {
        private readonly ApplicationDbContext _db;
        public GoodsRepository(ApplicationDbContext db):base (db)
        {
            _db = db;
        }
        public void Update(Goods goods)
        {
            var objFromDb = _db.Goods.Update(goods);
        }
    }
}
