using Domain.DTOs;
using Domain.Models;

namespace Application.DaoInterfaces;

public interface ICommentDao
{
    Task<Comment> CreateCommentAsync(Comment comment);
    Task<IEnumerable<Comment>> GetAsync(SearchCommentParametersDto searchParameters);
}