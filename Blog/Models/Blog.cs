using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }

        [Required(ErrorMessage = "Please enter message")]
        //[Range(1,100,ErrorMessage = "Maximum number (100) of letters exceeded")]
        public string BlogPost { get; set; }
        
        public string TimeStamp { get; set; }


        public string CategoryId { get; set; }
        public Category Category { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
