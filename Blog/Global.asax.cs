using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;

namespace Blog
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            SetDB();
        }


        public void SetDB()
        {
            //数据库初始化
            using (var dbBlog = new BlogContext())
            {

                //1、如果不存在就创建（下面两种等价）  默认方式
                //dbBlog.Database.CreateIfNotExists();
                //下面这个等价
                //Database.SetInitializer(new CreateDatabaseIfNotExists<BlogContext>());
                //dbBlog.Database.Initialize(true);


                //2、不管是否存在都重建（先配置后初始化）
                //Database.SetInitializer(new DropCreateDatabaseAlways<BlogContext>());
                //dbBlog.Database.Initialize(true);


                ////3、模型（实体类）改变了才重新创建
                //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BlogContext>());
                //dbBlog.Database.Initialize(true);


                ////4、关闭数据库策略，在已有表的情况下，自己手动创建数据库表和实体
                //Database.SetInitializer<BlogContext>(null);


                //5、Migration数据迁移
            }

        }


        //数据表之增删查改：CRUD（用在具体的Controller中，下面只是例子）
        //public void SetDT()
        //{
        //    BlogContext dbBlog = new BlogContext();

        //    Blog.Models.StudyType st = new Models.StudyType() { TypeName = "测试", IsDeleted = false };

        //    //插入
        //    dbBlog.StudyTypes.Add(st);
        //    dbBlog.SaveChanges();

        //    //查找
        //    var model = dbBlog.StudyTypes.Where(a => a.IsDeleted == false);
        //    //var model = cm.StudyTypes.Where(a => a.IsDeleted == false).SingleOrDefault();//如果找不到就返回Null

        //    //更新
        //    dbBlog.Entry<Blog.Models.StudyType>(st).State = EntityState.Modified;
        //    dbBlog.SaveChanges();

        //    //删除
        //    dbBlog.Entry<Blog.Models.StudyType>(st).State = EntityState.Deleted;
        //    dbBlog.SaveChanges();
        //}

        
    }
}
