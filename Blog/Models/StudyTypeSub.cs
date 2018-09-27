using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class StudyTypeSub
    {
        [Key]
        public int ID { get; set; }

        public string SubTypeName { get; set; }

        public int ListOrder { get; set; }

        public bool IsDeleted { get; set; }
    }
}