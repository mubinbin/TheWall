using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TheWall.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;


namespace TheWall.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        public HomeController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Index");
        }

        // Process Register
        [HttpPost("processregister")]
        public IActionResult ProcessReg(User NewUser)
        {
            if(ModelState.IsValid)
            {
                // check email's uniqueness 
                if(_context.Users.Any(u=>u.Email==NewUser.Email))
                {
                    ModelState.AddModelError("Email", "This email has already been registered!");
                    return View("Index");
                }

                // hash password
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                NewUser.Password = Hasher.HashPassword(NewUser, NewUser.Password);

                _context.Users.Add(NewUser);
                _context.SaveChanges();

                // auto log in after register
                HttpContext.Session.SetInt32("UserId", NewUser.UserId);

                return RedirectToAction("Wall");
            }else{
                return View("Index");
            }
        }


        // Process Login
        [HttpPost("processlogin")]
        public IActionResult ProcessLogin (Login CurUser)
        {
            if(ModelState.IsValid)
            {
                User UserInDb = _context.Users.FirstOrDefault(u=>u.Email == CurUser.LEmail);

                // check if the email exsit in DB
                if(UserInDb == null)
                {
                    ModelState.AddModelError("LPassword", "Invalid Email/Password");
                    return View("Index");
                }

                // varify password
                var hasher = new PasswordHasher<Login>();
                var result = hasher.VerifyHashedPassword(CurUser, UserInDb.Password, CurUser.LPassword);
                if(result == 0)
                {
                    ModelState.AddModelError("LPassword", "Invalid Email/Password");
                    return View("Index");
                }

                HttpContext.Session.SetInt32("UserId", UserInDb.UserId);
                return RedirectToAction("Wall");
            }
            return View("Index");
        }

        // Log out
        [HttpGet("logout")]
        public RedirectToActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        // Wall
        [HttpGet("wall")]
        public IActionResult Wall()
        {
            if(HttpContext.Session.GetInt32("UserId")!=null)
            {
                int userid = (int)HttpContext.Session.GetInt32("UserId");
                ViewBag.curuser = _context.Users
                .FirstOrDefault(u=>u.UserId == userid);

                return View("Wall", _context);
            }else{
                return RedirectToAction("Index");
            }
        }

        // public PartialViewResult ShowMessage()
        // {
        //     List<Message> allmessages = _context.Messages
        //     .Include(m=>m.CommentsForMessage)
        //     .ToList();

        //     return PartialView("_ShowMessage", allmessages);
        // }

        [HttpGet("newmessagepartial")]
        public ViewResult NewMessage()
        {

            int userid = (int)HttpContext.Session.GetInt32("UserId");

            ViewBag.curuser = _context.Users
            .FirstOrDefault(u=>u.UserId == userid);

            return View("_PostMessage");
        }

        

        [ValidateAntiForgeryToken]
        [HttpPost("processnewmessage")]
        public IActionResult ProcessNewMessage(Message NewMessage)
        {
            int userid = (int)HttpContext.Session.GetInt32("UserId");

            ViewBag.curuser = _context.Users
            .FirstOrDefault(u=>u.UserId == userid);
            if(ModelState.IsValid)
            {
                _context.Messages.Add(NewMessage);
                _context.SaveChanges();


                var html = Helper.RenderRazorViewToString(this, "_ShowMessage", _context.Messages
                .Include(m=>m.CommentsForMessage)
                .ToList());
                
                var returnedJson = new
                {
                    successful = true,
                    renderPage = html
                };

                return Json(returnedJson);

            }else{

                var html = Helper.RenderRazorViewToString(this, "_PostMessage", NewMessage);

                var returnedJson = new 
                {
                    successful = false,
                    renderPage = html
                };
                return Json(returnedJson);
            }
        }




































































































        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
