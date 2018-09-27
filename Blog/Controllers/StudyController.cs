using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Models;

namespace Blog.Controllers
{
    public class StudyController : Controller
    {
        //private CodeModel db = new CodeModel();
        // GET: Study
        public ActionResult Index()
        {
            BlogContext dbBlog = new BlogContext();

            var ViewList = (from a in dbBlog.StudyTypes
                            join b in dbBlog.Studies
                            on a.ID equals b.Type 
                            //into c 
                            //from d in c.DefaultIfEmpty()
                        //select new StudyView() {b.ID, a.Title, a.ReleaseTime, a.BodyText, b.TypeName }
                        select new StudyView() { ID=a.ID,Title=b.Title,ReleaseTime= b.ReleaseTime.ToString(),BodyText= b.BodyText,TypeName=a.TypeName }
                        ).ToList();


            ViewBag.Model = (from a in dbBlog.StudyTypes
                                select a).ToList();



            return View(ViewList);

            
        }
    }
}