using System.ComponentModel.DataAnnotations;
namespace DemoMVC.Models
// tran thi mai anh - 2021050093
{
    public class Student
    {
        [Required]
        public string StudentID{ get; set; }
        [Required]
        public string FullName{ get; set; }
    
    }
}