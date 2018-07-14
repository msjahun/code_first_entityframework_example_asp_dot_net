using Code_first_entity_framework_example_asp_dot_net.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_first_entity_framework_example_asp_dot_net.Core.Repositories
{
    public interface IBlogRepository : IRepository<Blog>
    {
        Blog GetBlogWithBlogId(int id);
    }
}
