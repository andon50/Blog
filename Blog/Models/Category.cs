using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Category
    {
        [Key]
        public string CategoryId { get; set; }

        [Required(ErrorMessage = "Please enter Category")]
        public string CategoryName { get; set; }


    }
}
