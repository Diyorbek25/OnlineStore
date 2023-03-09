namespace OnlineStore.Application.DataTransferObjects.Users;

public record UserDto(
    int id,
    string name,
    string email,
    string phone,
    string address);
