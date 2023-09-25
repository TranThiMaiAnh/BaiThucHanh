namespace NewApp.Models
 {
 public class Employee {
        public string FullName {get;set;}
        public string Address {get; set;}
        public string EmployeeID {get; set;}

        // phuong thuc khoi tao-Employee
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
 }
 } 
        