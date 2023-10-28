using DemoMVC.Controllers;
using DemoMVC.Models.Person;
using Microsoft.AspNetCore.Mvc;

public class PersonController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(Person ps)
    {
        string strResult = ps.PersonID + "-" + ps.FullName;
        ViewBag.thongBao = strResult;    
        return View();
    }
}