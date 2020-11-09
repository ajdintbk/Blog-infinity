using System;
using System.Collections.Generic;
using System.Text;

namespace blog_infinity_dal.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime TimeCreated { get; set; }
        public DateTime TimeModified { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }

        public BaseEntity()
        {
            TimeCreated = DateTime.UtcNow;
        }

    }
}
