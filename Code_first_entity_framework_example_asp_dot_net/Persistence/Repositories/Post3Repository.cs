using Code_first_entity_framework_example_asp_dot_net.Core.Domain;
using Code_first_entity_framework_example_asp_dot_net.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_first_entity_framework_example_asp_dot_net.Persistence.Repositories
{
    public class Post3Repository : Repository<Post3>, IPost3Repository
    {
        public Post3Repository(BlogginContext context) : base(context)
        {
        }

        public IEnumerable<Post3> GetMostViewedPosts(int count)
        {
            return BlogginContext.Posts3.OrderByDescending(c => c.Post3Id).Take(count).ToList();

        }

        public IEnumerable<Post3> GetPostsWithBlogName(int pageIndex, int pageSize)
        {
            return BlogginContext.Posts3
                 .OrderBy(c => c.Post3Id)
                 .Skip((pageIndex - 1) * pageSize)
                 .Take(pageSize)
                 .ToList();
        }


        public BlogginContext BlogginContext
        {
            get { return Context as BlogginContext; }
        }
    }
}
