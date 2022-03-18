using BMModel.Categories.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BMModel.Categories
{
    public class Kind
    {
        public int Id { get; set; }
        public int DocId { get; set; }
        public Doc Doc { get; set; }
        public int ElectronicId { get; set; }
        public Electronic Electronic { get; set; }
        public int NonElectronicId { get; set; }
        public NonElectronic NonElectronic { get; set; }

    }
}
