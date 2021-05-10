﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Template_NewsSite.PL.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord{ get; set; }

        [Display(Name = "News title")]
        public override string Title { get; set; } = "Information page";

        [Display(Name = "Full description")]
        public override string Text { get; set; } = "Administrator created full description";
    }
}
