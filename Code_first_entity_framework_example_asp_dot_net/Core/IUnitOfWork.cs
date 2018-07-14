using Code_first_entity_framework_example_asp_dot_net.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_first_entity_framework_example_asp_dot_net.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IBlogRepository Blogs { get; }
        IPostRepository Posts { get; }
        IPost2Repository Post2s { get; }
        IPost3Repository Post3s { get; }

        int Complete();
    }
}
