using BMModel.Categories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMModel
{
    public class Goods
    {
        public Goods()
        {
            Count = 1;
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public int Count { get; set; }
        [Required]
        [Range(0,150,ErrorMessage ="Weght should not exceed 150kg!")]
        [Display(Name ="Weight(Kg ,Ex: 1,5,10,...)")]
        public double Weight { get; set; }
        [Range(0,200,ErrorMessage ="Width should not exceed 150cm!")]
        [Display(Name ="Width(Cm ,Ex: 10,20,30,...)")]
        public double Width { get; set; }
        [Range(0, 200, ErrorMessage = "Length should not exceed 150cm!")]
        [Display(Name = "Length(Cm ,Ex: 10,20,30,...)")]
        public double Length { get; set; }
        [Range(0, 200, ErrorMessage = "Heigh should not exceed 150cm!")]
        [Display(Name = "Width(Cm , Ex: 10,20,30,...)")]
        public double Height { get; set; }
        [Required]
        public int KindId { get; set; }
        [ForeignKey("KindId")]
        public Kind Kind { get; set; }
        [Required]
        public int MaterialId { get; set; }
        [ForeignKey("MaterialId")]
        public Material Material { get; set; }
    }
}
