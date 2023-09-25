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
        public void Display()
            {
                
                System.Console.WriteLine("{0}-{1}-{2} ",FullName, Address, EmployeeID);
            }
         public void Display2(double luong, int tuoi)
            {
                
                System.Console.WriteLine("{0}-{1} ",luong,tuoi);
            }
        
 }
 } 
        