using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models;

namespace WebApplication8.Properties.Controllers
{
  public class HomeController : Controller
  {
    DbConnection db = new DbConnection();
    public IActionResult Index()
    {
      return View();
    }
    //home/contact?name=dd&phone=dsfd&Email=sdf%40gmail.com&message=sdfsdf
    public IActionResult Contact(Contact data)
    {
      db.Contacts.Add(data);
      db.SaveChanges();
      return RedirectToAction("Index");
    }
    public IActionResult about()
    {
      return View();
    }

    public IActionResult service()
    {
      return View();
    }
    //home/contact
    public IActionResult ContactPage()
    {
      return View();
    }
  }
}
