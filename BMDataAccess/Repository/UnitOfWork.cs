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
            Advertise = new AdvertiseRepository(_db);
            Kind = new KindRepository(_db);
            Material = new MaterialRepository(_db);
            City = new CityRepository(_db);
            Country = new CountryRepository(_db);
            Origin = new OriginRepository(_db);
            Destination = new DestinationRepository(_db);
            ApplicationUser = new ApplicationUserRepository(_db);
        }
        public IAdvertiseRepository Advertise { get; private set; }
        public IKindRepository Kind { get; private set; }
        public IMaterialRepository Material { get; private set; }
        public ICityRepository City { get; private set; }
        public ICountryRepository Country { get;private set; }
        public IOriginRepository Origin { get; private set; }
        public IDestinationRepository Destination { get; private set; }
        public IApplicationUserRepository ApplicationUser { get; private set; }
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
