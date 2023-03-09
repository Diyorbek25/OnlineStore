namespace OnlineStore.Application.DataTransferObjects.Users;

public record UserForCreationDto(
    string name,
    string email,
    string phone,
    string address);
