﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Code_first_entity_framework_example_asp_dot_net
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

   public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }

        public virtual List<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }

    public class BlogginContext : DbContext
    {
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
