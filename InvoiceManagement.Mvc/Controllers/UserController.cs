using DAL.Concrete;
using EntityLayer.Concrete;
using InvoiceManagement.Mvc.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManagement.Mvc.Controllers
{
    [Authorize()]
    public class UserController : Controller
    {
        private readonly AllDbContext _context;
        public UserController(AllDbContext context)
        {
            _context = context;
        } 
        public IActionResult Index()
        { 
            return View( _context.users.ToList());
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Create(User model, int UserId)
        {
            _context.users.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int id)
        {
            var edit = _context.users.Where(
              x => x.UserId == id).SingleOrDefault();
            return View(edit);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Edit(User model, int UserId)
        {
            
                var data = _context.users.FirstOrDefault(x => x.UserId == UserId);

                if (data != null)
                { 
                    data.Name = model.Name;
                    data.Surname = model.Surname;
                    data.TcNo = model.TcNo;
                    data.Email = model.Email;
                    data.PhoneNo = model.PhoneNo;
                    data.NumberPlate = model.NumberPlate; 
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                    return View(); 
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Delete(int UserId )
        {
            var data = _context.users.Find(UserId);
            if (data!= null)
            {
               _context.users.Remove(data);
              _context.SaveChanges();
            }
             return RedirectToAction("Index");
        }

    }
}
