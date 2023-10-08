using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;
// 2021050093-tran thi mai anh
// phuongtrinhB2-MVC
namespace DemoMVC.Controllers
{
    public class PhuongTrinhB2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index(double a, double b, double c)
        {
            
            double delta = (b*b - 4*a*c);

            if ( delta < 0)
            {
                ViewBag.ThongBao = "Phuong Trinh Vo Nghiem";
            }else if( delta == 0 )
            {
                double nghiemkep = -b / 2*a;
                ViewBag.ThongBao = $"Phuong Trinh co nghiem kep = {nghiemkep}";
            }else
            {
                double nghiem1 = (-b + Math.Sqrt(delta)) / 2*a;
                double nghiem2 = (-b - Math.Sqrt(delta)) / 2*a;

                ViewBag.ThongBao = $"Phuong trinh co 2 nghiem: Nghiem 1 = {nghiem1} | Nghiem 2 = {nghiem2}";
            }
            

            return View();
        }

            
    }
}

    