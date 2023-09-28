namespace Domain.DTOs;

public class UserRegistrationDto
{
    public string Username { get; }
    public string Password { get; }
    public string Email { get; }

    public UserRegistrationDto(string username, string password, string email)
    {
        Username = username;
        Password = password;
        Email = email;
    }
}