 namespace NewApp.Models
 {
 public class Students : Person {
        public string MaSinhVien {get; set;}
        
        
    // tran thi mai anh -2021050093
        public void EnterData()
        {
            base.EnterData();
            System.Console.Write("Ma sinh vien = ");
            MaSinhVien = Console.ReadLine(); 
        }
        public void Display()
            {
                base.Display();
                System.Console.WriteLine("- Ma sinh vien: {0}  ",MaSinhVien);
            }
 }
 } 
