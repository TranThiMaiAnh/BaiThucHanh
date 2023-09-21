 namespace NewApp.Models
 {
 public class Students{
        public string MaSinhVien {get; set;}
        public string TenSinhVien {get; set; }
        public string DiaChi {get; set;}
        
    // tran thi mai anh -2021050093
        public void EnterData()
        {
            System.Console.Write("Ma sinh vien = ");
            MaSinhVien = Console.ReadLine();
            System.Console.Write("Ten sinh vien = ");
            TenSinhVien = Console.ReadLine();
            System.Console.Write("Dia Chi = ");
            DiaChi = Console.ReadLine();   
        }
        public void Display()
            {
                System.Console.WriteLine("{0} - {1} - {2} ",MaSinhVien, TenSinhVien, DiaChi);
            }
 }
 }
