 namespace NewApp.Models
 {
 public class Students  {
        public string Name {get;set;}
        public string Address {get; set;}
        public string StudentID {get; set;}
        
        
    // tran thi mai anh -2021050093
    // phuong co gia tri tra ve-student
        public Students ()
        {
            Name = "ho ten mac dinh";
            Address ="Ha noi";
            
        }
        
        public void NhapThongTin()
        {
            System.Console.WriteLine("ho va ten");
            Name = Console.ReadLine();
            System.Console.WriteLine("dia chi");
            Address = Console.ReadLine();
            
        }

        public void HienThi()
         {
             System.Console.WriteLine("{0}-{1}", Name, Address);
         }
 }

 }    