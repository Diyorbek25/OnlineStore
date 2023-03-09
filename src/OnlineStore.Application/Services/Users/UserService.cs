using OnlineStore.Application.DataTransferObjects.Users;
using OnlineStore.Domain.Entities;
using OnlineStore.Infrastructure.Repositories.Users;

namespace OnlineStore.Application.Services.Users;

public class UserService : IUserService
{
    private readonly IUserRepository userRepository;
    private readonly IUserFactory userFactory;

    public UserService(IUserRepository userRepository, IUserFactory userFactory)
    {
        this.userRepository = userRepository;
        this.userFactory = userFactory;
    }

    public async Task<UserDto> CreateUserAsync(UserForCreationDto userForCreationDto)
    {
        var user = userFactory.MapToUser(userForCreationDto);

        var storageUser = await userRepository.InsertAsync(user);

        return userFactory.MapToUserDto(storageUser);
    }

    public async Task<UserDto> RetriveUserByIdAsync(int userId)
    {
        var storageUser = await userRepository.SelectByIdAsync(userId);

        return userFactory.MapToUserDto(storageUser);
    }

    public IQueryable<UserDto> RetriveUsers()
    {
        IQueryable<User> storageUsers = userRepository.SelectAll();

        return storageUsers.Select(user => userFactory.MapToUserDto(user));
    }


    public async Task<UserDto> ModifyUserAsync(UserForModificationDto userForModificationDto)
    {
        var storageUser = await userRepository
            .SelectByIdAsync(userForModificationDto.id);

        userFactory.MapToUser(userForModificationDto, storageUser);

        var modifiedUser = await userRepository.UpdateAsync(storageUser);

        return userFactory.MapToUserDto(modifiedUser);
    }

    public async Task<UserDto> DeleteUserAsync(int userId)
    {
        var storageUser = await userRepository.SelectByIdAsync(userId);

        var deletedUser = await userRepository.DeleteAsync(storageUser);

        return userFactory.MapToUserDto(deletedUser);
    }
}
