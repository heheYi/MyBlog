namespace Blog
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Blog.Models;

    public class BlogContext : DbContext
    {
        public BlogContext() : base("name=BlogContext")
        {
            //继承上下文基类
        }


        public DbSet<Study> Studies { get; set; }

        public DbSet<StudyType> StudyTypes { get; set; }

        public DbSet<StudyTypeSub> StudyTypeSubs { get; set; }
    }
}

