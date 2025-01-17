using Microsoft.AspNetCore.Mvc;
using StncCms.Frontend.ApiServices.Interfaces;
using StncCms.Frontend.Models;
using System.Threading.Tasks;

namespace StncCms.Frontend.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlogApiService _blogApiService;

        public HomeController(IBlogApiService blogApiService)
        {
            _blogApiService = blogApiService;
        }

        public async Task<IActionResult> Index(int? categoryId, string s)
        {
            if (categoryId.HasValue)
            {
                ViewBag.ActiveCategory = categoryId;
                return View(await _blogApiService.GetAllByCategoryIdAsync((int)categoryId));
            }
            if (!string.IsNullOrWhiteSpace(s))
            {
                ViewBag.SearchString = s;
                return View(await _blogApiService.SearchAsync(s));
            }
            return View(await _blogApiService.GetAllAsync());
        }

        public async Task<IActionResult> BlogDetail(int id)
        {
            ViewBag.Comments = await _blogApiService.GetCommentsAsync(id, null);
            return View(await _blogApiService.GetByIdAsync(id));
        }

        public async Task<IActionResult> AddToComment(CommentAddModel model)
        {
            await _blogApiService.AddToComment(model);
            return RedirectToAction("BlogDetail", new { id = model.BlogId });
        }
    }
}