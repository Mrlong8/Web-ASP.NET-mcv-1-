using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MyNewController : Controller
    {
        public IActionResult Index()
        {
            //ViewData["Name"] = "Bùi Xuân Long";
            //ViewBag.age = 20;
            ////TempData được thiết kế để truyền dữ liệu giữa các request.
            //TempData["Email"] = "long@utc.edu.vn";

            var listUser = new List<User>();

            var u = new User();
            u.Id = 1;
            u.Name = "Test";
            u.Email = "i@utc.com";
            u.Password = "123";
            //ViewBag.User = u;

            var u1 = new User();
            u1.Id = 2;
            u1.Name = "Test";
            u1.Email = "i@utc.com";
            u1.Password = "123";

            listUser.Add(u1);
            listUser.Add(u);

            // Strongly type model
            return View(listUser);
            //return RedirectToAction("Sample");
        }
        public IActionResult Sample()
        {
            //return View("Index");
            // điều hướng sang action khác
            TempData.Keep();
            return RedirectToAction("Index","Other");
        }
        public IActionResult GetUser(int Id,string Name,string Email,string Password)
        {
            var  u = new User();
            u.Id= Id;
            u.Name= Name;
            u.Email= Email;
            u.Password = Password;
            return View(u);
        }

        // hiển thị  PostUser
        public IActionResult PostUser()
        {
            return View();
        }

        // xử lý HTTP POST
        [HttpPost]
        public IActionResult PostUser([Bind("Id,Name,Email,Password")]User user)
        //Chỉ cho phép những property này được Model Binding lấy từ request.
        { 
            var u = new User();
            u.Id = user.Id;
            u.Name = user.Name;
            u.Email = user.Email;
            u.Password = user.Password;
            return View("GetUser",u);
        }
    }
}
