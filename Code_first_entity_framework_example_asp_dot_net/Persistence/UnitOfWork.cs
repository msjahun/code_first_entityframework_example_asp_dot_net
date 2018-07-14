using Code_first_entity_framework_example_asp_dot_net.Core;
using Code_first_entity_framework_example_asp_dot_net.Core.Repositories;
using Code_first_entity_framework_example_asp_dot_net.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_first_entity_framework_example_asp_dot_net.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogginContext _context;

        public UnitOfWork( BlogginContext context)
        {
            _context = context;
            Blogs = new BlogRepository(_context);
            Posts = new PostRepository(_context);
            Post2s = new Post2Repository(_context);
            Post3s = new Post3Repository(_context);
        }

        public IBlogRepository Blogs { get; private set; }

        public IPostRepository Posts { get; private set; }

        public IPost2Repository Post2s { get; private set; }

        public IPost3Repository Post3s { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
          _context.Dispose();
        }
    }
}
