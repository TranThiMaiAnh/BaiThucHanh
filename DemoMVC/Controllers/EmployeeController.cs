using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;
// 2021050093-tran thi mai anh
namespace DemoMVC.Controllers
{
    public class EmployeeController:Controller
{
    public IActionResult Index()
    {
        return View();

    }

    [HttpPost]
    public IActionResult Index(Employee emp)
    {
        int TinhLuong = (emp.LuongCB) *  (emp.HsLuong) +emp.PhuCap;
        string str = "Luong: " + TinhLuong;
        ViewBag.TinhLuong = str;
        return View();
    }

}
}

