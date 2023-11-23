using System.ComponentModel.DataAnnotations;
namespace DemoMVC.Models
// tran thi mai anh - 2021050093
{
    public class HeThongPhanPhoi
    {
       [Key]
        public string MaHTPP{ get; set; }
       
        public string TenHTPP{ get; set; }
    
    }
}