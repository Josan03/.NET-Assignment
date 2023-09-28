using Domain.DTOs;
using Domain.Models;

namespace Application.LogicInterfaces;

public interface IUserLogic
{
    Task<User> RegisterAsync(UserRegistrationDto dto);
    Task<IEnumerable<User>> GetAsync(SearchUserParametersDto searchParameters);
}