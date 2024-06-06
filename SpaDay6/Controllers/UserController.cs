using Microsoft.AspNetCore.Mvc;
using SpaDay6.Models;
namespace SpaDay6.Controllers;

public class UserController : Controller
{
    [HttpGet]
    [Route("/user/add")]
    public IActionResult Add()
    {
        return View();
    }
    public IActionResult SubmitAddUserForm(User newUser, string verify)
    {
        ViewBag.Username = newUser.Username;
        ViewBag.Email = newUser.Email;
        if (newUser.Password == verify)
        {
            ViewBag.Date = newUser.Date;
            return View("Index");
        }
        else
        {
            ViewBag.error = "Passwords do not match. Please try again.";
            
            return View("Add");
        }
    }
}