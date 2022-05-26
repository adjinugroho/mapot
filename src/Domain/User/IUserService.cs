using Core.Helpers.DataTable;
using FluentResults;

namespace Domain.User
{
    public interface IUserService
    {
        Task<Result<DtResponse>> GetPageData(DtRequest dtRequest);
        Result<UserDto> GetUserById(Guid id);
        Result<UserDto> GetUserByUserId(string userId);
        Result<UserDto> AddUser(UserDto user);
        Result<UserDto> UpdateUser(UserDto user);
        Result<UserDto> DeleteUser(Guid id);

        Result ChangePassword(UserDto user);
        Result<UserDto> Login(UserDto user);
    }
}
