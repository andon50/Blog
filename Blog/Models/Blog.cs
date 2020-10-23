using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }

        [Required(ErrorMessage = "Please enter message")]
        public string BlogPost { get; set; }
        
        public string TimeStamp { get; set; }


        public string CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
