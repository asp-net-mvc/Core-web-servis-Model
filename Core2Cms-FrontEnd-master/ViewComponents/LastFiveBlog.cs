using Microsoft.AspNetCore.Mvc;
using StncCms.Frontend.ApiServices.Interfaces;

namespace StncCms.Frontend.ViewComponents{
    public class LastFiveBlog : ViewComponent{
        private readonly IBlogApiService _blogApiService;
        public LastFiveBlog(IBlogApiService blogApiService)
        {
            _blogApiService = blogApiService;    
        }
        public IViewComponentResult Invoke(){

            return View(_blogApiService.GetLastFiveAsync().Result);
        }
    }
}