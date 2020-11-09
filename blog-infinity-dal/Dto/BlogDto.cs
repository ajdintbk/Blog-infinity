using blog_infinity_dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace blog_infinity_dal.Dto
{
    public class BlogDto
    {
        public BlogDto()
        {

        }
        public BlogDto(Blog blog)
        {
            Id = blog.Id;
            Title = blog.Title;
            Summary = blog.Summary;
            Content = blog.Content;
            PublishedDate = blog.TimeCreated;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public DateTime PublishedDate { get; set; }

    }

}
