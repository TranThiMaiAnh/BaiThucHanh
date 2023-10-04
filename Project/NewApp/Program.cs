using System.Collections;
using NewApp.Models;
internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList personList = new ArrayList();
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
            Person ps = new Person();
            ps.EnterData();
            personList.Add(ps);
        }

        

        System.Console.WriteLine("----------------------------------");
        // Hien thi danh sach 
        foreach(Person ps in personList)
        {
            // goi toi phuong thuc hien thi
            ps.Display();
        }


        System.Console.WriteLine("------------------------------------");

        // Sua thong tin 

        string fullname = null;
        System.Console.WriteLine($"Nhap ten nguoi  can sua: {fullname}");
        fullname = Console.ReadLine();

        for(int i = 0; i < personList.Count; i++)
        {   
            Person ps = (Person) personList[i];

            if ( ps.FullName == fullname){

                ps.EnterData();
                break;

            }else
            {
                System.Console.WriteLine("Khong co thong tin!");
                break;
            }

        }

        System.Console.WriteLine("---------------------------");

        foreach(Person ps in personList)
        {
            // goi toi phuong thuc hien thi
            ps.Display();
        }

        System.Console.WriteLine("----------------------------");

        // Xoa 1 phan tu trong list

        System.Console.WriteLine("Nhap ten nguoi can xoa: ");
        fullname = Console.ReadLine();
        
        for(int i=0; i < personList.Count; i++ )
        {
            Person ps = (Person) personList[i];
            if(ps.FullName == fullname)
            {
                personList.RemoveAt(i);
                System.Console.WriteLine($"da xoa nguoi co ten la: {fullname}");
                break;
            }
        }


        System.Console.WriteLine("----------------------------");


         foreach(Person ps in personList)
        {
            
            ps.Display();
        }

    }
}
//tranthimaianh-2021050093
//array-person