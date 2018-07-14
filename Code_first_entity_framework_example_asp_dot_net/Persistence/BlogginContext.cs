using Code_first_entity_framework_example_asp_dot_net.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_first_entity_framework_example_asp_dot_net.Persistence
{

    public class BlogginContext : DbContext
    {/// <summary>
     /// 
     /// </summary>
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Post2s { get; set; }
        public DbSet<Post2> Posts2 { get; set; }
        public DbSet<Post3> Posts3 { get; set; }
    }
}
