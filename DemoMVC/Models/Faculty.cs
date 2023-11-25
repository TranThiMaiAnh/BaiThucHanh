using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
// tran thi mai anh - 2021050093
{
    
    public class Faculty
    {
       [Key]

        [Required(ErrorMessage = "Mã khoa không được để trống")]
    public string? FacultyID{get;set;}
    [Required(ErrorMessage = "Tên khoa không được để trống")]
    public string? FacultyName{ get; set; }
    
    }
}