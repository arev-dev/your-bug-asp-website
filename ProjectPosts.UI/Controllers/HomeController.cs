using Microsoft.AspNetCore.Mvc;
using ProjectPosts.BLL;
using ProjectPosts.BLL.Service;
using ProjectPosts.EN;
using ProjectPosts.EN.DTO;
using ProjectPosts.UI.Models;
using ProjectPosts.UI.Models.Views;
using System.Diagnostics;

namespace ProjectPosts.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly IPostService _postService;

        public HomeController(ICommentService commentService, IPostService postService)
        {
            _commentService = commentService;
            _postService = postService;
        }


        [HttpGet]

        // public IActionResult SPGetPosts(){

        //     IEnumerable<PostAllDTO> posts = _postService.GetAllPosts();
        //     List<PostAllDTO> items = posts.ToList();

        //     return Ok(items);
        // }

        // public async Task<IActionResult> GetAllPosts()
        // {
        //     IQueryable<Post> queryPost = await _postService.GET_ALL();
        //     List<VMPost> vmposts = queryPost
        //     .Select(p=> new VMPost(){
        //         Id = p.Id,
        //         Title = p.Title,
        //         Content = p.Content,
        //         CreatedAt = p.CreatedAt.Value.ToString("dd/MM/yyy"),
        //         IdUsuario = p.IdUsuario
        //     }).ToList();

        //     return StatusCode(StatusCodes.Status200OK, vmposts);
        // }
        // public async Task<IActionResult> GetAllComments()
        // {
        //     IQueryable<Comment> queryComment = await _commentService.GET_ALL();
        //     List<VMComment> vmcomentarios = queryComment
        //     .Select(c=> new VMComment(){
        //         Id = c.Id,
        //         Content = c.Content,
        //         CreatedAt = c.CreatedAt.Value.ToString("dd/MM/yyy"),
        //         IdUsuario = c.IdUsuario,
        //         IdPost = c.IdPost,
        //         IdParentComment = c.IdParentComment
        //     }).ToList();

        //     return StatusCode(StatusCodes.Status200OK, vmcomentarios);
        // }


        public async Task<ActionResult<Comment>> GetComment(int Id_comment) //SIRVE
        {
            try
            {
                // Obtén el comentario desde _commentService
                Comment queryComment = await _commentService.GET(Id_comment);

                if (queryComment == null)
                {
                    return NotFound(); // Devuelve 404 si el comentario no se encuentra
                }

                return Ok(queryComment); // Devuelve el comentario serializado a JSON
            }
            catch (Exception ex)
            {
                // Maneja excepciones aquí y devuelve un error 500 si es necesario
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }

        // public IActionResult GetCommentReplies(int Id_parent_comment)
        // {
        //     IEnumerable<CommentReplyDTO> replies = _commentService.GetReplies(Id_parent_comment);

        //     return StatusCode(StatusCodes.Status200OK, replies.ToList());

        // }

        // public IActionResult GetCommentLikes(int Id_comment)
        // {
        //     IEnumerable<CommentLikesDTO> likes = _commentService.GetLikes(Id_comment);

        //     return StatusCode(StatusCodes.Status200OK, likes.ToList());

        // }



        





















        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}