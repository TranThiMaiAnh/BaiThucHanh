namespace NewApp.Models

{
    public class Employee
    {
        //TRAN THI MAI ANH -2021050093
        public int MaNhanVien {get; set;}
        public string TenNhanVien {get; set; }
        public int Tuoi {get; set;}
        public double Luong {get; set;}

        public void EnterData()
        {
            System.Console.Write("Ma nhan vien = ");
            MaNhanVien = Convert.ToInt16(Console.ReadLine());
            System.Console.Write("Ten nhan vien = ");
            TenNhanVien = Console.ReadLine();
            System.Console.Write("Tuoi = ");
            Tuoi = Convert.ToInt16(Console.ReadLine());
            System.Console.Write("Luong = ");
            Luong = Convert.ToDouble(Console.ReadLine());
        }

        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2} tuoi - {3} VND",MaNhanVien, TenNhanVien, Tuoi, Luong);
        }

        }
}

