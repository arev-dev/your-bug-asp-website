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
    public class PostController : Controller
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet]

        public IActionResult List(){

            IEnumerable<PostAllDTO> posts = _postService.GetAllPosts();
            List<PostAllDTO> items = posts.ToList();

            return View(items);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}