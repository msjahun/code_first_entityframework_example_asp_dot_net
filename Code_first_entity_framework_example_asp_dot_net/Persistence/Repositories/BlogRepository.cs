using Code_first_entity_framework_example_asp_dot_net.Core.Domain;
using Code_first_entity_framework_example_asp_dot_net.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_first_entity_framework_example_asp_dot_net.Persistence.Repositories
{
    public class BlogRepository : Repository<Blog>, IBlogRepository
    {
        public BlogRepository(BlogginContext context) : base(context)
        {
        }

        public Blog GetBlogWithBlogId(int id)
        {
            return BlogginContext.Blogs.SingleOrDefault(b => b.BlogId == id);
        }

        public BlogginContext BlogginContext
        {
            get { return Context as BlogginContext; }
        }
    }
}
