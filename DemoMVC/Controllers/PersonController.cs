using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;
using System.Net;

// 2021050093-tran thi mai anh
namespace DemoMVC.Controllers
{
    public class PersonController:Controller
{
    public IActionResult Index()
    {
        return View();

    }

    [HttpPost]
    public IActionResult Index(Person ps)
    {
        string str = "hello " +  ps.PersonID + " " + ps.FullName;
        ViewBag.ThongBao = str;
        return View();
    }

}
}

