using DAL.Concrete;
using EntityLayer.Concrete;
using InvoiceManagement.Mvc.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace InvoiceManagement.Mvc.Controllers
{
    [Authorize()]
    public class DuesController : Controller
    {
        private readonly AllDbContext _context;
        public DuesController(AllDbContext context)
        {
            _context = context;
        }
        [Authorize(Roles = "Admin,User")]
        public IActionResult Index()
        {
            var d = _context.users.ToList();
            return View(_context.dues.ToList());
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Dues model, int DuestId)
        {
            _context.dues.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Edit(int id)
        {
            var edit = _context.dues.Where(
              x => x.DuesId == id).SingleOrDefault();
            return View(edit);
        }
        [HttpPost]
        public IActionResult Edit(Dues model, int DuesId)
        {

            var data = _context.dues.FirstOrDefault(x => x.DuesId == DuesId);

            if (data != null)
            {
                data.DuesId = model.DuesId;
                data.User.Name = model.User.Name;
                data.DueAmount = model.DueAmount;
                data.PaymentType = model.PaymentType;
                data.DueDate = model.DueDate;
                data.billingDate = model.billingDate;
                data.Status = model.Status;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                return View();
        }


        [HttpPost]
        public ActionResult Delete(int DuesId)
        {
            var data = _context.dues.Find(DuesId);
            if (data != null)
            {
                _context.dues.Remove(data);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
