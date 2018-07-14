using Code_first_entity_framework_example_asp_dot_net.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_first_entity_framework_example_asp_dot_net.Core.Repositories
{
    public interface IPostRepository :  IRepository<Post>
    {

        IEnumerable<Post> GetMostViewedPosts(int count);
        IEnumerable<Post> GetPostsWithBlogName(int pageIndex, int pageSize);
    }
}
