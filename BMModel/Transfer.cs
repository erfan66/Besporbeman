using BMModel.Areas;
using BMModel.Categories;
using BMModel.Personals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMModel.Model
{
    public class Transfer
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public Sender Sender { get; set; }
        public int ReceiverId { get; set; }
        public Receiver Receiver { get; set; }
        public int KindId { get; set; }
        public Kind Kind { get; set; }
        public int MaterialId { get; set; }
        public Material Material { get; set; }
        public int OriginCityId { get; set; }
        public City OriginCity { get; set; }
        public int OriginCountryId { get; set; }
        public Country Country { get; set; }
        public int DestinationCityId { get; set; }
        public City DestinationCity { get; set; }
        public int DestinationCountryId { get; set; }
        public Country DestinationCountry { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime PickUpTime { get; set; }
        public string Status { get; set; }
        public string? Comments { get; set; }



    }
}
