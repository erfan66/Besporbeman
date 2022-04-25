using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMModel.Areas
{
    public class Origin
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Origin City")]
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }
        [Required]
        [Display(Name ="Origin Country")]
        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public Country Country { get; set; }
    }
}
