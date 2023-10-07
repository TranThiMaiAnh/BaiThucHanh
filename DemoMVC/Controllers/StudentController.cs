using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;
// 2021050093-tran thi mai anh
namespace DemoMVC.Controllers
{
    public class StudentController:Controller
{
    public IActionResult Index()
    {
        return View();

    }

    [HttpPost]
    public IActionResult Index(Student std)
    {
        string str = "hello " +  std.StudentID + " " + std.FullName;
        ViewBag.ThongBao = str;
        return View();
    }

}
}

