using Microsoft.EntityFrameworkCore;
using ProjectPosts.DAL.DataContext;
using ProjectPosts.DAL.Repositories;
using ProjectPosts.EN;
using ProjectPosts.EN.DTO;

namespace ProjectPosts.BLL.Service;

public class CommentService : ICommentService
{
    private readonly ICommentRepository _context;

    public CommentService(ICommentRepository context)
    {
        _context = context;
    }

    public async Task<bool> DELETE(int ID)
    {
        return await _context.DELETE(ID);
    }

    public async Task<Comment> GET(int ID)
    {
        return await _context.GET(ID);
    }

    public IEnumerable<CommentLikesDTO> GetLikes(int ID)
    {
        return _context.GetLikes(ID);
    }


    public IEnumerable<CommentReplyDTO> GetReplies(int ID)
    {
        return _context.GetReplies(ID);
    }

    public async Task<IQueryable<Comment>> GET_ALL()
    {
        return await _context.GET_ALL();
    }

    public async Task<bool> INSERT(Comment modelo)
    {
        return await _context.INSERT(modelo);
    }

    public async Task<bool> UPDATE(Comment modelo)
    {
        return await _context.UPDATE(modelo);
    }
}
