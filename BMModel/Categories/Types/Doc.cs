using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMModel.Categories.Types
{
    public class Doc
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Count { get; set; }
        public double Weight { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }
    }
}
