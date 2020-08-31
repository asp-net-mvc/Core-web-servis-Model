using Microsoft.AspNetCore.Mvc;
using StncCms.Frontend.ApiServices.Interfaces;

namespace StncCms.Frontend.ViewComponents{
    public class CategoryList:ViewComponent{
        private readonly ICategoryApiService _categoryApiService;
        public CategoryList(ICategoryApiService categoryApiService)
        {
            _categoryApiService=categoryApiService;
        }
        public IViewComponentResult Invoke(){
            return View(_categoryApiService.GetAllWithBlogsCount().Result);
        }
    }
}