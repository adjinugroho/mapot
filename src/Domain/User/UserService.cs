using AutoMapper;
using Core;
using Core.Helpers.DataTable;
using Core.Helpers.System;
using FluentResults;

namespace Domain.User
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<DtResponse>> GetPageData(DtRequest dtRequest)
        {
            throw new NotImplementedException();
        }

        public Result<UserDto> GetUserById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Result<UserDto> GetUserByUserId(string userId)
        {
            try
            {
                var repoResult = _unitOfWork.AppUserRepo.Fetch().FirstOrDefault(m => m.UserId == userId);

                if (repoResult == null)
                    return Result.Fail("User not found!");

                var result = _mapper.Map<UserDto>(repoResult);
                return Result.Ok(result);
            }
            catch (Exception ex)
            {
                return Result.Fail(ex.GetMessage());
            }
        }

        public Result<UserDto> AddUser(UserDto user)
        {
            throw new NotImplementedException();
        }

        public Result<UserDto> UpdateUser(UserDto user)
        {
            throw new NotImplementedException();
        }

        public Result<UserDto> DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public Result ChangePassword(UserDto user)
        {
            throw new NotImplementedException();
        }

        public Result<UserDto> Login(UserDto user)
        {
            if (!string.IsNullOrEmpty(user.UserId) && !string.IsNullOrEmpty(user.Password))
            {
                var repoResult = _unitOfWork.AppUserRepo.Fetch().FirstOrDefault(m => m.UserId == user.UserId);

                if (repoResult != null)
                {
                    if (!repoResult.IsActive)
                    {
                        return Result.Fail("User not active! Please contact the administrator.");
                    }

                    if (BCrypt.Net.BCrypt.Verify(user.Password, repoResult.Password))
                    {
                        return Result.Ok(_mapper.Map<UserDto>(repoResult));
                    }
                }

                return Result.Fail("User ID and Password not match!");
            }

            return Result.Fail("User ID and Password is required!");
        }
    }
}
