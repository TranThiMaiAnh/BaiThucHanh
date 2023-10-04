using System.Collections;
using NewApp.Models;
internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList studentList = new ArrayList();
        int n;
        do
        {
            try
            {
                System.Console.Write("n = ");
                n = Convert.ToInt32(Console.ReadLine());

            }
            catch
            {
                n = 0;
            }
        } while (n < 1);

        // Them n phan tu vao list

        for (int i = 0; i < n; i++)
        {
            System.Console.WriteLine($"[{i}]");
            Students std = new Students();
            std.EnterData();
            studentList.Add(std);
        }

        

        System.Console.WriteLine("----------------------------------");
        // Hien thi danh sach 
        foreach(Students std in studentList)
        {
            // goi toi phuong thuc hien thi
            std.Display();
        }


        System.Console.WriteLine("------------------------------------");

        // Sua thong tin 

        string fullname = null;
        System.Console.WriteLine($"Nhap ten hoc sinh can sua: {fullname}");
        fullname = Console.ReadLine();

        for(int i = 0; i < studentList.Count; i++)
        {   
            Students std = (Students) studentList[i];

            if ( std.FullName == fullname){

                std.EnterData();
                break;

            }else
            {
                System.Console.WriteLine("Khong co thong tin!");
                break;
            }

        }

        System.Console.WriteLine("---------------------------");

        foreach(Students std in studentList)
        {
            // goi toi phuong thuc hien thi
            std.Display();
        }

        System.Console.WriteLine("----------------------------");

        // Xoa 1 phan tu trong list

        System.Console.WriteLine("Nhap ten hoc sinh can xoa: ");
        fullname = Console.ReadLine();
        
        for(int i=0; i < studentList.Count; i++ )
        {
            Students std = (Students) studentList[i];
            if(std.FullName == fullname)
            {
                studentList.RemoveAt(i);
                System.Console.WriteLine($"da xoa hoc sinh co ten la: {fullname}");
                break;
            }
        }


        System.Console.WriteLine("----------------------------");


         foreach(Students std in studentList)
        {
            
            std.Display();
        }

    }
}
//tranthimaianh-2021050093
//array-Students