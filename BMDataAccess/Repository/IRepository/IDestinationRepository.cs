﻿using BMModel;
using BMModel.Areas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMDataAccess.Repository.IRepository
{
    public interface IDestinationRepository : IRepository<Destination>
    {
        void Update(Destination destination);
    }
}
