﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiTodo.application.Extensions
{
    public class TodoDto
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Title { get; set; } = default;
        [Required(ErrorMessage ="insert Description")]

    }
}
