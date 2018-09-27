using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    
    public class StudyView
    {
        //a.Title, a.ReleaseTime, a.BodyText, b.TypeName

        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string BodyText { get; set; }
        public string TypeName { get; set; }


        public string ReleaseTime { get; set; }

    }
}