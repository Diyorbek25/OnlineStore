namespace OnlineStore.Application.DataTransferObjects.Users;

public record UserForModificationDto(
    int id,
    string? name,
    string? email,
    string? phone,
    string? address);
