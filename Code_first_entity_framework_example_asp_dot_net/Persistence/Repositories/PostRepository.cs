using Code_first_entity_framework_example_asp_dot_net.Core.Domain;
using Code_first_entity_framework_example_asp_dot_net.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_first_entity_framework_example_asp_dot_net.Persistence.Repositories
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(BlogginContext context) : base(context)
        {
        }

        public IEnumerable<Post> GetMostViewedPosts(int count)
        {
            return BlogginContext.Post2s.OrderByDescending(c => c.PostId).Take(count).ToList();

        }

        public IEnumerable<Post> GetPostsWithBlogName(int pageIndex, int pageSize)
        {
            return BlogginContext.Post2s
                .OrderBy(c => c.PostId)
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
