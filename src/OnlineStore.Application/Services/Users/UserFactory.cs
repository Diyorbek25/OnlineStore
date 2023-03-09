using OnlineStore.Application.DataTransferObjects.Users;
using OnlineStore.Domain.Entities;

namespace OnlineStore.Application.Services.Users;

public class UserFactory : IUserFactory
{
    public User MapToUser(UserForCreationDto userForCreationDto)
    {
        return new User()
        {
            Name = userForCreationDto.name,
            Email = userForCreationDto.email,
            Phone = userForCreationDto.phone,
            Address = userForCreationDto.address
        };
    }

    public void MapToUser(
        UserForModificationDto userForModificationDto,
        User user)
    {
        user = new User();

        user.Name = userForModificationDto.name ?? user.Name;
        user.Email = userForModificationDto.email ?? user.Email;
        user.Phone = userForModificationDto.phone ?? user.Phone;
        user.Address = userForModificationDto.address ?? user.Address;
    }

    public UserDto MapToUserDto(User user)
    {
        return new UserDto(
            id: user.Id,
            name: user.Name,
            email: user.Email,
            phone: user.Phone,
            address: user.Address);
    }
}
