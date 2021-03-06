﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Application.ViewModels.Input
{
    public class TagInput
    {
        [Required]
        [RegularExpression(@"^[\w\-]{2,15}$")]
        public string Name { get; set; }
    }
}
