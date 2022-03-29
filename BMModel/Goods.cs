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
        public double Weight { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
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
