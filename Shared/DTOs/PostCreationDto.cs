namespace Shared.DTOs;

public class PostCreationDto
{
    public int OwnerId { get; }
    public string OwnerUsername{ get; }
    public string Title { get; }
    public string Body { get; }

    public PostCreationDto(int ownerId, string ownerUsername, string title, string body)
    {
        OwnerId = ownerId;
        OwnerUsername = ownerUsername;
        Title = title;
        Body = body;
    }
    
    public PostCreationDto(string ownerUsername, string title, string body)
    {
        OwnerUsername = ownerUsername;
        Title = title;
        Body = body;
    }
    
    public PostCreationDto() {}
}