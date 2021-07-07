using Domain.Entities.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Service;
using System.Threading.Tasks;


namespace TicketSalesSystem.Controllers
{
    public class AccountController : Controller
    {
        private readonly CreateUserUnitOfWork _createUser;
        private readonly SignInUnitOfWork _signIn;
        private readonly SignOutUnitOfWork _signOut;

        public AccountController(CreateUserUnitOfWork createUser, SignInUnitOfWork signIn, SignOutUnitOfWork signOut)
        {
            _createUser = createUser;
            _signIn = signIn;
            _signOut = signOut;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _createUser.CreateUser(model);

                if (result.Succeeded)
                {
                    await _signIn.SignInUser(model);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signIn.PasswordSignInUser(model);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Incorrect username and (or) password ");
                }
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signOut.SignOutUser();

            return RedirectToAction("Index", "Home");
        }
    }
}
