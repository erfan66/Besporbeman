using BMModel.Areas;
using BMModel.Categories;
using BMModel.Personals;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMModel
{
    public class Transfer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ReceiverId { get; set; }
        [ForeignKey("ReceiverId")]
        public Receiver Receiver { get; set; }
        [Required]
        public int AdvertiseId { get; set; }
        [ForeignKey("AdvertiseId")]
        public Advertise Advertise { get; set; }
        [Required]
        public int OriginCityId { get; set; }
        [ForeignKey("OriginCityId")]
        public City OriginCity { get; set; }
        [Required]
        public int OriginCountryId { get; set; }
        [ForeignKey("OriginCountryId")]
        public Country Country { get; set; }
        [Required]
        public int DestinationCityId { get; set; }
        [ForeignKey("DestinationCityId")]
        public City DestinationCity { get; set; }
        [Required]
        public int DestinationCountryId { get; set; }
        [ForeignKey("DestinationCountryId")]
        public Country DestinationCountry { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public DateTime PickUpTime { get; set; }
        [Required]
        public string Status { get; set; }
        public string? Comments { get; set; }



    }
}
