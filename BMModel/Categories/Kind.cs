using BMModel.Categories.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BMModel.Categories
{
    public class Kind
    {
        [Key]
        public int Id { get; set; }
        public int DocId { get; set; }
        [ForeignKey("DocId")]
        public Doc Doc { get; set; }
        public int ElectronicId { get; set; }
        [ForeignKey("ElectronicId")]
        public Electronic Electronic { get; set; }
        public int NonElectronicId { get; set; }
        [ForeignKey("NonElectronicId")]
        public NonElectronic NonElectronic { get; set; }

    }
}
