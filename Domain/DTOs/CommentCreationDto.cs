namespace Domain.DTOs;

public class CommentCreationDto
{
    public string Content { get; set; }
    public int OwnerId { get; set; }
    public int PostId { get; set; }
    
    public CommentCreationDto(string content, int ownerId, int postId)
    {
        Content = content;
        OwnerId = ownerId;
        PostId = postId;
    }
}