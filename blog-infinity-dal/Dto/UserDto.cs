using blog_infinity_dal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace blog_infinity_dal.Dto
{
    public class UserDto
    {
        public UserDto()
        {

        }
        public UserDto(User user)
        {
            Id = user.Id;
            Name = user.Name;
            Age = user.Age;
            Email = user.Email;
            NumberOfBlogs = 0;
            Blogs = null;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int NumberOfBlogs { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
