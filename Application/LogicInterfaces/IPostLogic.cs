using Domain.DTOs;
using Domain.Models;

namespace Application.LogicInterfaces;

public interface IPostLogic
{
    Task<Post> CreatePostAsync(PostCreationDto dto);
    Task<IEnumerable<Post>> GetAsync(SearchPostParametersDto dto);
    Task UpdateAsync(PostUpdateDto post);
    Task DeleteAsync(int id);
    Task<PostBasicDto> GetByIdAsync(int id);
}