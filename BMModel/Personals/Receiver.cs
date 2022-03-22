using BMModel.Areas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMModel.Personals
{
    public class Receiver
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Family { get; set; }
        public string Alias { get; set; }
        public int Age { get; set; }
        [Required]
        public string Sex { get; set; }
        [Required]
        public string PhoneNumberIran { get; set; }
        public string PhoneNumberTurkey { get; set; }
        [Required]
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }
        [Required]
        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public Country Country { get; set; }
    }
}
