using System;
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

        [Required(ErrorMessage = "Please, Enter movie title.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please, Enter movie director.")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Please, Enter movie year.")]
        public int Year { get; set; }
        public string LentTo { get; set; }

        [Required(ErrorMessage = "Please, select movie rating.")]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }


        //Build Foreign Key Relationship

        //Category
        [Required(ErrorMessage = "Please, select movie category.")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
