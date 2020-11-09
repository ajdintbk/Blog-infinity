using blog_infinity_dal.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace blog_infinity_dal.Repositories
{
    interface IBlogRepository
    {
        Task<int> Add(BlogDto blog, CancellationToken cancellationToken = default);

    }
}
