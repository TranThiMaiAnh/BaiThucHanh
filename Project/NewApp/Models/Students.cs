 namespace NewApp.Models
 {
 public class Students  {
        public string Name {get;set;}
        public string Address {get; set;}
        public int StudentID {get; set;}
        
        
    // tran thi mai anh -2021050093
    // phuong co gia tri tra ve-student
        
        public void NhapThongTin()
        {
            System.Console.WriteLine("ho va ten");
            Name = Console.ReadLine();
            System.Console.WriteLine("dia chi");
            Address = Console.ReadLine();
            System.Console.Write("ID = ");
            // tran thi mai anh -2021050093
            // try..catch Student
            try{
                StudentID = Convert.ToInt16(Console.ReadLine());
            } catch(Exception e)
            {
                StudentID =0;
            }
            
        }

        public void HienThi()
         {
             System.Console.WriteLine("{0}-{1}-{2}", Name, Address, StudentID);
         }
 }

 }    