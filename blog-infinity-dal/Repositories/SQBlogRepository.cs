using blog_infinity_dal.Domain;
using blog_infinity_dal.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace blog_infinity_dal.Repositories
{
    public class SQBlogRepository : IBlogRepository
    {
        private readonly BlogDbContext _context;
        public SQBlogRepository(BlogDbContext context)
        {
            _context = context;
        }
        public async Task<int> Add(BlogDto blog, CancellationToken cancellationToken = default)
        {
            var newBlog = new Blog()
            {
                Title = blog.Title,
                TimeCreated = DateTime.UtcNow,
                TimeModified = DateTime.UtcNow,
                Content = blog.Content,
                CreatedBy = "second",
                UserId = 2,
                Summary = blog.Summary,
            };
            _context.Add(newBlog);
            await _context.SaveChangesAsync(cancellationToken);
            return newBlog.Id;
        }

    }
}
