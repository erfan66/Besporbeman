using BMModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMDataAccess.Repository.IRepository
{
    public interface IAdvertiseRepository:IRepository<Advertise>
    {
        void Update(Advertise advertise);
        void UpdateStatus(int id, string status);
    }
}
