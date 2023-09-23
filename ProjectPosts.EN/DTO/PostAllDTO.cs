namespace ProjectPosts.EN;
public class PostAllDTO
{
    public int? PostId { get; set; }
    public int? UserId { get; set; }
    public int? StatusId { get; set; }
    public string? Username { get; set; }
    public string? Title { get; set; }
    public string? PostContent { get; set; }
    public DateTime? CreatedAt { get; set; }
    public int? CommentsCount { get; set; }
    public int? LikesCount { get; set; }
}
