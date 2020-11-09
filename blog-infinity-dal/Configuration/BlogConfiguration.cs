using blog_infinity_dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace blog_infinity_dal.Configuration
{
    public class BlogConfiguration : BaseEntityConfiguration<Blog>
    {
        public override void Configure(EntityTypeBuilder<Blog> builder)
        {
            base.Configure(builder);
            builder.HasOne(b => b.User).WithMany(b => b.BlogsCreated).HasForeignKey(b => b.UserId);

            builder.Property(p => p.Title).IsRequired().HasMaxLength(64);
            builder.Property(p => p.Summary).IsRequired().HasMaxLength(350);
            builder.Property(p => p.Content).IsRequired().HasMaxLength(3500);
            builder.Property(p => p.TimeCreated).IsRequired();




        }

    }
}
