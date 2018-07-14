using Code_first_entity_framework_example_asp_dot_net.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_first_entity_framework_example_asp_dot_net.Core.Repositories
{
    public interface IPost3Repository : IRepository<Post3>
    {
        IEnumerable<Post3> GetMostViewedPosts(int count);
        IEnumerable<Post3> GetPostsWithBlogName(int pageIndex, int pageSize);
    }
}
