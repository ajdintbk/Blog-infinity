using blog_infinity_dal.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace blog_infinity_dal.Repositories
{
    public interface IUserRepository
    {
        Task<UserViewModel> GetUsers(CancellationToken cancellationToken = default);
        Task<int> SaveUser(UserDto user, CancellationToken cancellationToken = default);
        Task EditUser(int userId, UserDto car, CancellationToken cancellationToken = default);
        Task RemoveUser(int userId, CancellationToken cancellationToken = default);
        Task<List<UserDto>> Search(string searchString);
        Task<List<UserDto>> Details(int userId);

    }

}
