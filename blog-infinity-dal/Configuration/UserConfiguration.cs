using blog_infinity_dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace blog_infinity_dal.Configuration
{
    public class UserConfiguration : BaseEntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Email).IsRequired();

            builder.HasMany(p => p.BlogsCreated).WithOne(p => p.User).HasForeignKey(p => p.Id);

            builder.HasData(new List<User>
            {
                new User()
                {
                    Id = 1,
                    Email = "firstuser@gmail.com",
                    Age = 22,
                    CreatedBy = "First",
                    Name = "First",
                },

                new User()
                {
                    Id = 2,
                    Email = "seconduser@gmail.com",
                    Age = 22,
                    CreatedBy = "First",
                    Name = "Second",
                },

                new User()
                {
                    Id = 3,
                    Email = "thirduser@gmail.com",
                    Age = 22,
                    CreatedBy = "First",
                    Name = "Third",
                },

                new User()
                {
                    Id = 4,
                    Email = "fourthuser@gmail.com",
                    Age = 22,
                    CreatedBy = "First",
                    Name = "Foruth",
                },
                new User()
                {
                    Id = 5,
                    Email = "fifthuser@gmail.com",
                    Age = 22,
                    CreatedBy = "First",
                    Name = "Fifth",
                },

            });


        }

    }
}
