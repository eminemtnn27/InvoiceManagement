using DAL.Concrete;
using EntityLayer.Concrete;
using InvoiceManagement.Mvc.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq; 
namespace InvoiceManagement.Mvc.Controllers
{
    [Authorize()]
    public class InvoiceController : Controller
    {
        private readonly AllDbContext _context;
        public InvoiceController(AllDbContext context)
        {
            _context = context;
        }
        [Authorize(Roles = "Admin,User")]

        public IActionResult Index()
        {
            var d=_context.users.ToList();
            return View(_context.invoice.ToList());
        }

        [Authorize(Roles="Admin")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Invoice model, int InvoiceId)
        {
            _context.invoice.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Edit(int id)
        {
            var d= _context.users.Where(
              x => x.UserId == id).FirstOrDefault();
            var edit = _context.invoice.Where(
              x => x.InvoiceId == id).SingleOrDefault();
            return View(edit);
        }
        [HttpPost]
        public IActionResult Edit(Invoice model, int InvoiceId,int UserId)
        {

            var data = _context.invoice.FirstOrDefault(x => x.InvoiceId == InvoiceId);
            var user = _context.users.FirstOrDefault(x => x.UserId == UserId);

            if (data != null)
            {
                data.InvoiceNo = model.InvoiceNo;
                data.Amount = model.Amount;
                user.UserId = model.User.UserId;
                user.Name = model.User.Name;
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
        public ActionResult Delete(int InvoiceId)
        {
            var data = _context.invoice.Find(InvoiceId);
            if (data != null)
            {
                _context.invoice.Remove(data);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}
