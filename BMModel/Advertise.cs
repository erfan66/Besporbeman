using BMModel.Areas;
using BMModel.Categories;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMModel
{
    public class Advertise
    {
        public Advertise()
        {
            DateOfAdvertise = DateTime.Now;
            ValidityDate = DateTime.Now;
            Count = 1;
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Title(Name of Goods)")]
        public string Title { get; set; }
        public int Count { get; set; }
        [Required]
        [Range(0, 150, ErrorMessage = "Weght should not exceed 150kg!")]
        [Display(Name = "Weight(Kg ,Ex: 1,5,10,...)")]
        public double Weight { get; set; }
        [Range(0, 200, ErrorMessage = "Width should not exceed 150cm!")]
        [Display(Name = "Width(Cm ,Ex: 10,20,30,...)")]
        public double Width { get; set; }
        [Range(0, 200, ErrorMessage = "Length should not exceed 150cm!")]
        [Display(Name = "Length(Cm ,Ex: 10,20,30,...)")]
        public double Length { get; set; }
        [Range(0, 200, ErrorMessage = "Heigh should not exceed 150cm!")]
        [Display(Name = "Height(Cm , Ex: 10,20,30,...)")]
        public double Height { get; set; }
        public string? Description { get; set; }
        [Required]
        [Display(Name = "Kind")]
        public int KindId { get; set; }
        [ForeignKey("KindId")]
        public Kind Kind { get; set; }
        [Required]
        [Display(Name = "Material")]
        public int MaterialId { get; set; }
        [ForeignKey("MaterialId")]
        public Material Material { get; set; }
        [Required]
        public int OriginId { get; set; }
        [ForeignKey("OriginId")]
        public Origin Origin { get; set; }
        [Required]
        public int DestinationId { get; set; }
        [ForeignKey("DestinationId")]
        public Destination Destination { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name ="Date of Advertise")]
        public DateTime DateOfAdvertise { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name ="Validity Date")]
        public DateTime ValidityDate { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string SenderName { get; set; }
        [Required]
        public string SenderPhoneNumber { get; set; }
        public string SenderAddress { get; set; }
        [EmailAddress]
        public string SenderEmail { get; set; }

    }
}
