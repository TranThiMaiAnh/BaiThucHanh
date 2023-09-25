 namespace NewApp.Models
 {
 public class Students  {
        public string Name {get;set;}
        public string Address {get; set;}
        public string StudentID {get; set;}
        
        
    // tran thi mai anh -2021050093
    // phuong chua tham so-student
        public Students ()
        {
            Name = "ho ten mac dinh";
            Address ="Ha noi";
            StudentID ="2021050093";
        }
        public void Display()
            {
                
                System.Console.WriteLine("{0}-{1}-{2} ",Name, Address, StudentID);
            }
         public void Display2(string ten, int tuoi)
            {
                
                System.Console.WriteLine("{0}-{1} ",ten, tuoi);
            }
 }
 } 
