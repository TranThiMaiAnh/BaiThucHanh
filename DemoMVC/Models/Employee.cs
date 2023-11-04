using System.ComponentModel.DataAnnotations;
namespace DemoMVC.Models
// tran thi mai anh - 2021050093
{
    public class Employee:Person
    {
        
        public string EmployeeID{ get; set; }
         public int LuongCB{ get; set; }

        [Required]
        public int HsLuong{ get; set; }
        [Required]
        public int PhuCap{ get; set; }

        public string Age{ get; set; }

    
    }
}