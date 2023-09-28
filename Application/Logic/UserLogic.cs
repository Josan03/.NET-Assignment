using Application.DaoInterfaces;
using Application.LogicInterfaces;
using Domain.DTOs;
using Domain.Models;

namespace Application.Logic;

public class UserLogic : IUserLogic
{
    private readonly IUserDao userDao;

    public UserLogic(IUserDao userDao)
    {
        this.userDao = userDao;
    }
    
    public async Task<User> RegisterAsync(UserRegistrationDto dto)
    {
        User? existing = await userDao.GetByUsernameAsync(dto.Username);
        if (existing != null)
            throw new Exception("Username already taken!");

        ValidateUserData(dto);
        User toCreate = new User(dto.Username, dto.Password, dto.Email);
        User created = await userDao.RegisterAsync(toCreate);
        return created;
    }

    public Task<IEnumerable<User>> GetAsync(SearchUserParametersDto searchParameters)
    {
        return userDao.GetAsync(searchParameters);
    }

    private static void ValidateUserData(UserRegistrationDto dto)
    {
        string username = dto.Username;

        if (username.Length < 3)
            throw new Exception("Username must be at least 3 characters!");
    }
}