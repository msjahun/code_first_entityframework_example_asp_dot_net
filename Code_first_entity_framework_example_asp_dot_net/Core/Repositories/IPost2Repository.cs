using Code_first_entity_framework_example_asp_dot_net.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_first_entity_framework_example_asp_dot_net.Core.Repositories
{
    public interface IPost2Repository : IRepository<Post2>
    {
        IEnumerable<Post2> GetMostViewedPosts(int count);
        IEnumerable<Post2> GetPostsWithBlogName(int pageIndex, int pageSize);
    }
}
