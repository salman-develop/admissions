﻿using System.ComponentModel.DataAnnotations;

namespace API.Models.Courses
{
    public class CreateModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }
    }
}
