using System.ComponentModel.DataAnnotations;
namespace DemoMVC.Models
// tran thi mai anh - 2021050093
{
    public class PtX
    {
        [Required]
        public double a { get; set; }
        [Required]
        public double b { get; set; }

        public double c { get; set; }
        

    
    }
}