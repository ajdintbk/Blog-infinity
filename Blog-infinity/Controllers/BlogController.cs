using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_infinity_dal.Dto;
using blog_infinity_dal.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Blog_infinity.Controllers
{
    public class BlogController : Controller
    {
        private readonly SQBlogRepository _blogRepo;
        public BlogController(SQBlogRepository blogRepo)
        {
                _blogRepo = blogRepo;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Add([FromBody] BlogDto blog)
        {
            var _blog = await _blogRepo.Add(blog);
            return Ok(_blog);
        }
    }
}
