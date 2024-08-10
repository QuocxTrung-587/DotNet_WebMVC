using News_website.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using EntityState = Microsoft.EntityFrameworkCore.EntityState;

namespace News_website.Controllers
{
    public class AdminController : Controller
    {

        private readonly MyDbContext _context;

        public AdminController(MyDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> Index()
        {
            var customers = await Task.Run(() =>
                _context.UserRoles
                    .Where(ur => ur.Role.Name == "Customers")
                    .Select(ur => ur.User)
                    .ToList());

            return View(customers);
        }


        public IActionResult ResetPassword(int id)
        {
            var customer = _context.Users.FirstOrDefault(u => u.Id == id);
            if (customer != null)
            {
                return View(customer);
            }

            // Xử lý khi không tìm thấy khách hàng
            return NotFound();
        }

        [HttpPost]
        public IActionResult ResetPassword(User customer)
        {
                // Tìm khách hàng theo Id
                var existingCustomer = _context.Users.FirstOrDefault(u => u.Id == customer.Id);
                if (existingCustomer != null)
                {
                    // Cập nhật mật khẩu mới cho khách hàng
                    existingCustomer.Password = customer.Password;

                    // Lưu thay đổi vào cơ sở dữ liệu
                    _context.SaveChanges();

                    // Chuyển hướng về trang danh sách khách hàng sau khi đặt lại mật khẩu
                    return RedirectToAction("Index");
                }
                else
                {
                    // Xử lý khi không tìm thấy khách hàng
                    return NotFound();
                }

        }

        public IActionResult Details(int id)
        {
            var customer = _context.Users.FirstOrDefault(u => u.Id == id);
            if (customer != null)
            {
                return View(customer);
            }

            // Handle when the customer is not found
            return NotFound();
        }

        [HttpPost]
        public IActionResult ToggleLock(int id)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                // Toggle the lock status
                user.IsLocked = !user.IsLocked;

                // Save changes to the database
                _context.SaveChanges();

                // Redirect back to the index page
                return RedirectToAction("Index");
            }

            // Handle when the user is not found
            return NotFound();
        }


        public IActionResult PostList()
        {
            // Hiển thị danh sách sách và cho phép thêm, cập nhật, tìm kiếm hoặc xóa tin
            var posts = _context.Posts.ToList();

            // Lấy danh sách danh mục từ cơ sở dữ liệu
            var categories = _context.Categories.ToList();

            // Truyền danh sách danh mục vào ViewBag
            ViewBag.Categories = new SelectList(categories, "Id", "Name");

            return View(posts);
        }

        [HttpGet]
        public IActionResult Create()
        {
            // Hiển thị form thêm sách
            // Lấy danh sách danh mục từ cơ sở dữ liệu
            var categories = _context.Categories.ToList();

            // Truyền danh sách danh mục vào ViewBag
            ViewBag.Categories = new SelectList(categories, "Id", "Name");

            return View();
        }

        [HttpPost]
        public IActionResult Create(Post posts)
        {
            // Thêm tin vào cơ sở dữ liệu
            _context.Posts.Add(posts);
            _context.SaveChanges();
            return RedirectToAction("PostList");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var posts = _context.Posts.Find(id);
            if (posts == null)
            {
                return NotFound();
            }
            // Lấy danh sách danh mục từ cơ sở dữ liệu
            var categories = _context.Categories.ToList();

            // Truyền danh sách danh mục vào ViewBag
            ViewBag.Categories = new SelectList(categories, "Id", "Name");

            return View(posts);
        }

        [HttpPost]
        public IActionResult Edit(int id, Post posts)
        {
            if (id != posts.Id)
            {
                return NotFound();
            }

            if (id == posts.Id)
            {
                _context.Entry(posts).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("PostList");
            }

            return View(posts);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var post = _context.Posts.Find(id);
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var post = _context.Posts.Find(id);
            _context.Posts.Remove(post);
            _context.SaveChanges();
            return RedirectToAction("PostList");
        }

    }

}
