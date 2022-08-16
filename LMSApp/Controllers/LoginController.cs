
using Microsoft.AspNetCore.Mvc;
using LMSApp.Models;
using Microsoft.AspNetCore.Http;

namespace LibraryManagementSystem.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAccountRepo _accountRepo;

        public LoginController(IAccountRepo accountRepo) { _accountRepo = accountRepo; }

        public IActionResult Index(string userName, string userPassword)
        {

            if (userName != null || userPassword != null) { var user = _accountRepo.getUserByName(userName); if (user == null) { ViewBag.Message = "Invalid Credentials!! Please Try Again"; }
                else if (userName.Equals("admin") && userPassword.Equals("admin"))
                {
                   
                        HttpContext.Session.SetString("username", userName);


                    //ViewBag.Message = "Login Successful!! Welcome Admin";
                    return RedirectToAction("AdminPage", "LendRequests");

                }
                else if (userName.Equals(user.UserName) && userPassword.Equals(user.Password))
                {
                    
                            HttpContext.Session.SetString("username", userName);


                    return RedirectToAction("BookView", "Books", new {name=userName});
                        }
                else
                { ViewBag.Message = "Invalid Credentials!! Please Try Again"; } }
            return View();
        }
    }
}

