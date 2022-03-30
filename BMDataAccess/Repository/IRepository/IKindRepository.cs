using BMModel.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMDataAccess.Repository.IRepository
{
    public interface IKindRepository:IRepository<Kind>
    {
        void Update(Kind kind);
    }
}
