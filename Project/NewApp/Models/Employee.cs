namespace NewApp.Models
{
    public class Employee : Person
    {
        //TRAN THI MAI ANH -2021050093
        public string MaNhanVien {get; set;}
        

        public void EnterData()
        {
           base.EnterData();
            System.Console.Write("Ma nhan vien = ");
            MaNhanVien = Console.ReadLine(); 
        }

        public void Display()
        {
            base.Display();
            System.Console.WriteLine("+ Ma nhan vien: {0}  ",MaNhanVien);
            }
            
        }

        }


