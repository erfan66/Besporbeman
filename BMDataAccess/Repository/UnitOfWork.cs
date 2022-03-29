using BMDataAccess.Data;
using BMDataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMDataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Goods = new GoodsRepository(_db);
            Kind = new KindRepository(_db);
            Material = new MaterialRepository(_db);
        }
        public IGoodsRepository Goods { get; private set; }
        public IKindRepository Kind { get; private set; }
        public IMaterialRepository Material { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
