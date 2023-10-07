using System.ComponentModel.DataAnnotations;
namespace DemoMVC.Models
// tran thi mai anh - 2021050093
{
    public class Employee
    {
        [Required]
        public string FullName{ get; set; }
        [Required]
        public int LuongCB{ get; set; }

        [Required]
        public int HsLuong{ get; set; }
        [Required]
        public int PhuCap{ get; set; }

    
    }
}