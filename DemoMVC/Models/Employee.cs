using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
// tran thi mai anh - 2021050093
{
    [Table("Person")]
    public class Employee
    {
        [Key]
       
        public string EmpID { get; set;}
        public  string FullName { get; set;}
        public  string Address { get; set;}
        
    
    }
}