using Code_first_entity_framework_example_asp_dot_net.Core.Domain;
using Code_first_entity_framework_example_asp_dot_net.Core.Repositories;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_first_entity_framework_example_asp_dot_net.Persistence.Repositories
{
    public class Post2Repository : Repository<Post2>, IPost2Repository
    {
        public Post2Repository(BlogginContext context) : base(context)
        {
        }

        public IEnumerable<Post2> GetMostViewedPosts(int count)
        {
            return BlogginContext.Posts2.OrderByDescending(c => c.Post2Id).Take(count).ToList();
        }

        public IEnumerable<Post2> GetPostsWithBlogName(int pageIndex, int pageSize)
        {
          return BlogginContext.Posts2
                .OrderBy(c => c.Post2Id)
                .Skip ((pageIndex -1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public BlogginContext BlogginContext
        {
            get { return Context as BlogginContext; }
        }
    }
}
