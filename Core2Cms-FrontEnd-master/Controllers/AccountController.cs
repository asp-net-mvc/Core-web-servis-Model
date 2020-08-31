using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StncCms.Frontend.ApiServices.Interfaces;
using StncCms.Frontend.Filters;
using StncCms.Frontend.Models;

namespace StncCms.Frontend.Controllers{
     public class AccountController: Controller{

         private readonly IAuthApiService _authApiService;

         public AccountController(IAuthApiService authApiService)
         {
             _authApiService=authApiService;
         }
         public IActionResult SignIn(){
             return View();
         }

         [HttpPost]
         public async Task<IActionResult> SignIn(AppUserLoginModel model){
             if(await _authApiService.SignIn(model)){
                 return RedirectToAction("Index","Blog",new{@area="Admin"});
             }

             return View();
         }

     }
}