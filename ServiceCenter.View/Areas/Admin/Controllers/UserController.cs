using Microsoft.AspNetCore.Mvc;
using ServiceCenter.Domain.Viewmodel;
using ServiceCenter.Service.Interfaces;

namespace ServiceCenter.View.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Users()
        {
            var response = _userService.GetUserView();
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View("users", response.Result);
            }
            return View("Error", $"{response.Description}");
        }

        [HttpGet]
        public IActionResult CreateUser() => View();

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserViewModel model)
        {
            var response = await _userService.Create(model);
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return RedirectToAction("Admin", "User");
            }
            return View("Error", $"{response.Description}");
        }
    }
}
