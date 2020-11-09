using System;
using System.Collections.Generic;
using System.Text;

namespace blog_infinity_dal.Domain
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public List<Blog> BlogsCreated { get; set; }
    }
}
