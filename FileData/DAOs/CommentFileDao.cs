using Application.DaoInterfaces;
using Domain.Models;

namespace FileData.DAOs;

public class CommentFileDao : ICommentDao
{
    private readonly FileContext context;
    
    public CommentFileDao(FileContext context)
    {
        this.context = context;
    }
    
    public Task<Comment> CreateCommentAsync(Comment comment)
    {
        int commentId = 1;
        if (context.Comments.Any())
        {
            commentId = context.Comments.Max(u => u.Id);
            commentId++;
        }
        
        comment.Id = commentId;
        context.Comments.Add(comment);
        context.SaveChanges();
        
        return Task.FromResult(comment);
    }
}