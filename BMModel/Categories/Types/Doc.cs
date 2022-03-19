using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMModel.Categories.Types
{
    public class Doc
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public double Weight { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }
    }
}
