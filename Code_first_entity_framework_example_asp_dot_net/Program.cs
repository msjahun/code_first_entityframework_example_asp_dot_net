using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Code_first_entity_framework_example_asp_dot_net.Persistence;
using Code_first_entity_framework_example_asp_dot_net.Core.Domain;


namespace Code_first_entity_framework_example_asp_dot_net
{
    class Program
    {/// <summary>
    /// //////////////////////////////
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)

           

        {
            using (var unitOfWork = new UnitOfWork(new BlogginContext()))
            {
                //example 1
                var Blog = unitOfWork.Blogs.Get(1);
                Console.WriteLine("Blog id = {0} and blog name  is {1}", Blog.BlogId, Blog.Name);


                Console.WriteLine("Press any ket to exit...");
                Console.ReadKey();


            }
            //using (var db = new BlogginContext())
            //{
            //    Creates and save a new Blog
            //    Console.Write("Enter a name for a new Blog: ");
            //    var name = Console.ReadLine();

            //    var blog = new Blog { Name = name };
            //    db.Blogs.Add(blog);
            //    db.SaveChanges();


            //    Display all Blogs from the database
            //    var query = from b in db.Blogs
            //                orderby b.Name
            //                select b;

            //    Console.WriteLine("All blogs in the database:");
            //    foreach (var item in query)
            //    {
            //        Console.WriteLine(item.Name);

            //    }

            //    Console.WriteLine("Press any ket to exit...");
            //    Console.ReadKey();
            //}
        }
    }

  


   

   


}
