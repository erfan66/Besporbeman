using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMDataAccess.Repository.IRepository
{
    public interface IUnitOfWork:IDisposable
    {
        IAdvertiseRepository Advertise { get; }
        IKindRepository Kind { get; }
        IMaterialRepository Material { get; }
        ICityRepository City { get; }
        ICountryRepository Country { get; }
        IOriginRepository Origin { get; }
        IDestinationRepository Destination { get; }
        void Save();

    }
}
