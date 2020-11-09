using blog_infinity_dal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace blog_infinity_dal.Dto
{
    public class UserViewModel
    {
        private readonly BlogDbContext _context ;
        public UserViewModel(BlogDbContext context)
        {
            _context = context;
        }
        public UserViewModel(IReadOnlyCollection<User> users)
        {
            Collection = users.Select(u => new UserDto() { 
                Age = u.Age,
                Email = u.Email,
                Blogs = u.BlogsCreated,
                Name = u.Name,
                //NumberOfBlogs = _context.Blogs.Where(s => s.UserId == u.Id).Count(),
                Id = u.Id
        }).ToList();
        }
        public IReadOnlyCollection<UserDto> Collection { get; set; }

    }
}
