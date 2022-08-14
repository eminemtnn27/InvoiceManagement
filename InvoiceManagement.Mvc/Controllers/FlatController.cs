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
    public class FlatController : Controller
    {
        private readonly AllDbContext _context;
        public FlatController(AllDbContext context)
        {
            _context = context;
        }
        [Authorize(Roles = "Admin,User")]
        public IActionResult Index()
        {
            var d = _context.users.ToList();
            return View( _context.flats.ToList());
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Create( )
        { 
            return View( );
        }
        [HttpPost]
        public IActionResult Create(Flat model, int FlatId)
        { 
            _context.flats.Add(model);
              _context.SaveChanges();
              return RedirectToAction("Index");
            
        } 
        public IActionResult Edit(int id)
        {
            var edit = _context.flats.Where(
              x => x.FlatId == id).SingleOrDefault();
            return View(edit);
        }
        [HttpPost]
        public IActionResult Edit(Flat model, int FlatId)
        {
            
                var data = _context.flats.FirstOrDefault(x => x.FlatId == FlatId);

                if (data != null)
                { 
                    data.FlatOwnerName = model.FlatOwnerName;
                    data.FlatNo = model.FlatNo;
                    data.FlatType = model.FlatType;
                    data.FlatLocation = model.FlatLocation;
                    data.BlockNo = model.BlockNo;
                    data.Status = model.Status; 
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                    return View(); 
        }
         

        [HttpPost]
        public ActionResult Delete(int FlatId )
        {
            var data = _context.flats.Find(FlatId);
            if (data!= null)
            {
               _context.flats.Remove(data);
              _context.SaveChanges();
            }
             return RedirectToAction("Index");
        }

    }
}
