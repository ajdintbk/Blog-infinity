using blog_infinity_dal.Domain;
using blog_infinity_dal.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace blog_infinity_dal.Repositories
{
    public class SQLUserRepository : IUserRepository
    {
        private readonly BlogDbContext _context;
        public SQLUserRepository(BlogDbContext context)
        {
            _context = context;
        }

        public async Task<List<UserDto>> Details(int userId)
        {
            List<UserDto> list = _context.Users.Where(t=>t.Id == userId).Select(s => new UserDto()
            {
                Age = s.Age,
                Email = s.Email,
                Name = s.Name,
                NumberOfBlogs = _context.Blogs.Where(g => g.UserId == userId).Count(),
                Blogs = _context.Blogs.Where(g => g.UserId == userId).ToList()
            }).ToList();
            return  list;
        }

        public async Task EditUser(int userId, UserDto user, CancellationToken cancellationToken = default)
        {
            var dbuser = await _context.Users.FindAsync(userId);
            dbuser.Name = user.Name;
            dbuser.Email = user.Email;
            dbuser.Age = user.Age;
            _context.Users.Update(dbuser);
            await _context.SaveChangesAsync(cancellationToken);

        }

        public async Task<UserViewModel> GetUsers(CancellationToken cancellationToken = default)
        {
            var collection = await _context.Users.ToListAsync(cancellationToken);
            return new UserViewModel(collection);

        }

        public async Task RemoveUser(int userId, CancellationToken cancellationToken = default)
        {
            var user = _context.Users.Find(userId);
            _context.Remove(user);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public Task<int> SaveUser(UserDto user, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserDto>> Search(string searchString)
        {
            List<User> s = _context.Users.Where(r => r.Name == searchString || r.Email == searchString).ToList();

            List<UserDto> udt = s.Select(o => new UserDto()
            {
                Age = o.Age,
                Email = o.Email,
                Blogs = o.BlogsCreated,
                Id = o.Id,
                Name = o.Name,
                NumberOfBlogs = _context.Blogs.Where(g => g.UserId == o.Id).Count()
            }).ToList();
                return udt;
            
        }
    }
}
