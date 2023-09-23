namespace ProjectPosts.EN;
public class PostCommentsDTO
{
    public int? CommentId { get; set; }
    public int? UserId { get; set; }
    public string? Username { get; set; }
    public string? CommentContent { get; set; }
    public DateTime? CreatedAt { get; set; }
    
}
