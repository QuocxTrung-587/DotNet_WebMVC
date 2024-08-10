using Microsoft.AspNetCore.Mvc;
using News_website.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using News_website.Controllers;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace News_website.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyDbContext _context;

        public HomeController(ILogger<HomeController> logger, MyDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        // Hiển thị trang chính
        public IActionResult Index()
        {
            var posts = _context.Posts.Include(b => b.Category).ToList();
            return View(posts);
        }

        public IActionResult Search(string keyword)
        {
            var posts = _context.Posts
                .Include(b => b.Category)
                .Where(p => p.Title.Contains(keyword) || p.Author.Contains(keyword))
                .ToList();

            return View("Index", posts);
        }

        // Hiển thị trang quyền riêng tư
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult PostDetail(int id)
        {
            var categories = _context.Categories.ToList();
            ViewBag.Categories = new SelectList(categories, "Id", "Name");
        
            var posts = _context.Posts.Include(b => b.Category).FirstOrDefault(b => b.Id == id);
            if (posts != null)
            {
                return View(posts);
            }
            return NotFound();
        }

        public IActionResult Profile()
        {
            var customerId = HttpContext.Session.GetInt32("UserId");
            var customer = _context.Users.FirstOrDefault(u => u.Id == customerId);
            if (customer != null)
            {
                return View(customer);
            }

            // Handle when the customer is not found
            return NotFound();
        }

        // GET: Hiển thị trang cập nhật thông tin cá nhân
        public IActionResult UpdateProfile()
        {
            var customerId = HttpContext.Session.GetInt32("UserId");
            var customer = _context.Users.FirstOrDefault(u => u.Id == customerId);

            if (customer != null)
            {
                return View(customer);
            }

            // Handle when the customer is not found
            return NotFound();
        }

        // POST: Xử lý cập nhật thông tin cá nhân
        [HttpPost]
        public IActionResult UpdateProfile(User updatedUser)
        {
            var existingUser = _context.Users.FirstOrDefault(u => u.Id == updatedUser.Id);

            if (existingUser != null)
            {
                // Cập nhật thông tin cá nhân từ dữ liệu được nhập
                existingUser.FullName = updatedUser.FullName;
                existingUser.Email = updatedUser.Email;
                existingUser.Phone = updatedUser.Phone;
                existingUser.Gender = updatedUser.Gender;

                // Lưu thay đổi vào cơ sở dữ liệu
                _context.SaveChanges();

                return RedirectToAction("Profile");
            }

            // Handle when the customer is not found
            return NotFound();
        }

        /*public IActionResult Help()
        {
            var helpTopics = new List<string>
            {
                "Cách đặt hàng",
                "Hướng dẫn thanh toán",
                "Sử dụng giỏ hàng",
                "Chính sách hoàn trả",
            };

            return View(helpTopics);
        }*/


        // Xử lý trang lỗi
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<ActionResult> Customers()
        {
            var customers = await Task.Run(() =>
                _context.UserRoles
                    .Where(ur => ur.Role.Name == "Customers")
                    .Select(ur => ur.User)
                    .ToList());

            return View(customers);
        }

        public IActionResult Details(int id)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);

            if (user != null)
            {
                var viewModel = new UserDetailsViewModel
                {
                    User = user,
                };

                return View(viewModel);
            }

            // Handle when the user is not found
            return NotFound();
        }
    }
}