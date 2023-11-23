using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
// tran thi mai anh - 2021050093
{ 
    public class DaiLy : HeThongPhanPhoi
    {
       
        public string MaDaiLy{ get; set; }
       
        public string TenDaiLy{ get; set; }
         public string DiaChi{ get; set; }
         public string NguoiDaiDien{ get; set; }
         public string DienThoai{ get; set; }

         public string MaHTPPID { get; set; }
        [ForeignKey("MaHTPPID")]
        public HeThongPhanPhoi? HeThongPhanPhoi { get; set; }
        
    }
}