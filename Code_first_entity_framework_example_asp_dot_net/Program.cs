using System;
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
            using (var db = new BlogginContext())
            {
                // Creates and save a new Blog
                Console.Write("Enter a name for a new Blog: ");
                var name = Console.ReadLine();

                var blog = new Blog { Name = name };
                db.Blogs.Add(blog);
                db.SaveChanges();


                // Display all Blogs from the database
                var query = from b in db.Blogs
                            orderby b.Name
                            select b;

                Console.WriteLine("All blogs in the database:");
                foreach(var item in query){
                    Console.WriteLine(item.Name);

                }

                Console.WriteLine("Press any ket to exit...");
                Console.ReadKey();
            }
        }
    }

   public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }

        public virtual List<Post> Posts { get; set; }
        public virtual List<Post2> Posts2 { get; set; }

        public virtual List<Post3> Posts3 { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
    public class Post2
    {
        public int Post2Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }

    public class Post3
    {
        public int Post3Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }


    public class BlogginContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Post2> Posts2 { get; set; }
        public DbSet<Post3> Posts3 { get; set; }
    }
}
