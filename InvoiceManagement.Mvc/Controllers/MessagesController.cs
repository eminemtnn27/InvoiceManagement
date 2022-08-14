﻿using BusinessLayer.Concrete;
using BusinessLayer.Validator;
using DAL.Abstract;
using DAL.Concrete;
using DAL.EntityFramework; 
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace InvoiceManagement.Mvc.Controllers
{
    public class MessagesController : Controller
    {
        
        MessageManager mm = new MessageManager( new EfMessageDal());
        MessageValidator messagevalidator = new MessageValidator();
        private readonly AllDbContext _context;
        public MessagesController(AllDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.messages.ToList());
        }
        public ActionResult Inbox()
        {
            var adminMail = User.Identity.Name;
            var messagelist = mm.GetListInbox(adminMail);
            var count = mm.GetListInbox(adminMail).Where(x => x.MessageStatus == false).Count();
            TempData["count"] = count;

            return View(messagelist);
        }
        public ActionResult Sendbox()
        {
            var adminMail = User.Identity.Name;

            var messagelist = mm.GetListSendbox(adminMail);
            return View(messagelist);
        }
        [HttpGet]
        public ActionResult GetInboxMessageDetails(int id)
        {
            var values = mm.GetById(id);
            values.MessageStatus = true;
            mm.TUpdate(values);
            return View(values);
        }

        public ActionResult GetSendboxMessageDetails(int id)
        {
            var values = mm.GetById(id);
            return View(values);
        }
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message p)
        {
            var userMail = User.Identity.Name;
            p.User.Email= userMail;
            //ValidationResult result = messagevalidator.Validate(p);
            //if ()
            //{
            //    //foreach (var item in result.ErrorMessage)
            //    //{
            //    //    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    //}
            //}
            //else
            //{
            //    p.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            //    mm.TAdd(p);
            //    return RedirectToAction("Sendbox");
            //}
            return View();

        }

        public PartialViewResult asideBarUser()
        {
            return PartialView();
        }
    }
}