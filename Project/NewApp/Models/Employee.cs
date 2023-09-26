namespace NewApp.Models
 {
 public class Employee {
        public string FullName {get;set;}
        public string Address {get; set;}
        public string EmployeeID {get; set;}

        // phuong thuc chua tham so-Employee
        public Employee()
        {
            FullName = "ho ten ";
            Address ="dia chi";
            EmployeeID ="ma nhan vien";
        }
        public int TinhLuong(int LuongCB)
            {
                
                int Luong = LuongCB + 120000;
                return Luong;
            }
         
 }
 } 
        