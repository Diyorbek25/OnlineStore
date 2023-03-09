using OnlineStore.Application.DataTransferObjects.Users;
using OnlineStore.Domain.Entities;

namespace OnlineStore.Application.Services.Users;

public interface IUserFactory
{
    User MapToUser(UserForCreationDto userForCreationDto);

    void MapToUser(
        UserForModificationDto userForModificationDto,
        User user);

    UserDto MapToUserDto(User user);
}
