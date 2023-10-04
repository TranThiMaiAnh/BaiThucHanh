using System.Collections;
using NewApp.Models;
internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList employeeList = new ArrayList();
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
            Employee emp = new Employee();
            emp.EnterData();
            employeeList.Add(emp);
        }

        

        System.Console.WriteLine("----------------------------------");
        // Hien thi danh sach 
        foreach(Employee emp in employeeList)
        {
            // goi toi phuong thuc hien thi
            emp.HienThi();
        }


        System.Console.WriteLine("------------------------------------");

        // Sua thong tin 

        string fullname = null;
        System.Console.WriteLine($"Nhap ten nhan vien can sua: {fullname}");
        fullname = Console.ReadLine();

        for(int i = 0; i < employeeList.Count; i++)
        {   
            Employee emp = (Employee) employeeList[i];

            if ( emp.FullName == fullname){

                emp.EnterData();
                break;

            }else
            {
                System.Console.WriteLine("Khong co thong tin!");
                break;
            }

        }

        System.Console.WriteLine("---------------------------");

        foreach(Employee emp in employeeList)
        {
            // goi toi phuong thuc hien thi
            emp.HienThi();
        }

        System.Console.WriteLine("----------------------------");

        // Xoa 1 phan tu trong list

        System.Console.WriteLine("Nhap ten nhan vien can xoa: ");
        fullname = Console.ReadLine();
        
        for(int i=0; i < employeeList.Count; i++ )
        {
            Employee emp = (Employee) employeeList[i];
            if(emp.FullName == fullname)
            {
                employeeList.RemoveAt(i);
                System.Console.WriteLine($"da xoa nhan vien co ten la: {fullname}");
                break;
            }
        }


        System.Console.WriteLine("----------------------------");


         foreach(Employee emp in employeeList)
        {
            
            emp.HienThi();
        }

    }
}
//tranthimaianh-2021050093
//array-Employee