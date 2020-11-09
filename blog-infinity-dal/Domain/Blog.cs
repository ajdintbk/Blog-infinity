
namespace blog_infinity_dal.Domain
{
    public class Blog : BaseEntity
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}