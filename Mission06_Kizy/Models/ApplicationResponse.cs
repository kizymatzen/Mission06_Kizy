﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_Kizy.Models
{
    public class ApplicationResponse
    {   
        [Key]
        [Required]
        public int ApplicationId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public int Year { get; set; }
        public string LentTo { get; set; }
        [Required]

        [MaxLength(25)]
        public string Notes { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }


        //Build Foreign Key Relationship

        //Category
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
