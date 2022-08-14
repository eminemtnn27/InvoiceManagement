using InvoiceManagement.Mvc.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManagement.Mvc.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public AuthController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = model.Email,
                    Email = model.Email

                };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    //add role here
                   // await _userManager.AddToRoleAsync(user, "Admin");
                    return RedirectToAction("ActionName", "ControllerName");
                }
            }
            ModelState.AddModelError("", "Geçersiz Kayıt.");
            return View(model);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: false, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    var user = await _userManager.FindByNameAsync(model.Email);
                    //user role list here
                    var roles = await _userManager.GetRolesAsync(user);
                    //get default role here
                    string role = roles.FirstOrDefault();
                    role = "User";
                    if (role.Equals("Admin"))
                    {
                        return Redirect("Home/Index");
                    }
                    else if (role.Equals("User"))
                    {
                        return Redirect("Home/Index");
                        //return RedirectToAction("UserActionName", "UserControllerName");
                    }
                    else
                    {
                        //do something here. put in your logic 
                    }
                }
            }
            ModelState.AddModelError("", "Geçersiz Kimlik veya Şifre");
            return View(model);
        }

    }
} 
