using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
// tran thi mai anh - 2021050093
{
    [Table("Student")]
    public class Student
    {
        [Key]
       
        public string StudentID { get; set;}
        public  string FullName { get; set;}
        public  string Address { get; set;}
        
    
    }
}