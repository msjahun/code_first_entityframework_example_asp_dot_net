using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_first_entity_framework_example_asp_dot_net.Core.Domain
{
    public class Blog
    {
        /// <summary>
        ///
        /// </summary>
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        public virtual List<Post> Posts { get; set; }
        public virtual List<Post2> Posts2 { get; set; }

        public virtual List<Post3> Posts3 { get; set; }
    }
}
