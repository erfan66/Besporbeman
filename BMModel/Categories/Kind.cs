﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BMModel.Categories
{
    public class Kind
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public string Image { get; set; }
    }
}
