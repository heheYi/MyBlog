using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Study
    {
        [Key]
        public int ID { get; set; }
        public int Type { get; set; }

        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string BodyText { get; set; }

        [Required(AllowEmptyStrings = true)]
        public DateTime ReleaseTime { get; set; }
        
    }
}