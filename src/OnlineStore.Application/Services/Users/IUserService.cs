using OnlineStore.Application.DataTransferObjects.Users;

namespace OnlineStore.Application.Services.Users;

public interface IUserService
{
    Task<UserDto> CreateUserAsync(UserForCreationDto userForCreationDto);
    IQueryable<UserDto> RetriveUsers();
    Task<UserDto> RetriveUserByIdAsync(int userId);
    Task<UserDto> ModifyUserAsync(UserForModificationDto userForModificationDto);
    Task<UserDto> DeleteUserAsync(int userId);
}
