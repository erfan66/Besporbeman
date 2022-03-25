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
    public class Advertise
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        [Required]
        public DateTime DateOfAdvertise { get; set; } = DateTime.Now;
        [Required]
        public DateTime ValidityDate { get; set; }
        [Required]
        public int KindId { get; set; }
        [ForeignKey("KindId")]
        public Kind Kind { get; set; }
        [Required]
        public int MaterialId { get; set; }
        [ForeignKey("MaterialId")]
        public Material Material { get; set; }
        [Required]
        public int SenderId { get; set; }
        [ForeignKey("SenderId")]
        public Sender Sender { get; set; }
        [Required]
        public int TransferId { get; set; }
        [ForeignKey("TransferId")]
        public Transfer Transfer { get; set; }
    }
}
