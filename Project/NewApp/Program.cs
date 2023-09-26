using NewApp.Models;
public class Program{   
     public static void Main(String[] args){
      Employee emp = new Employee();
       string FullName ="tran thi mai anh";
       int b = 2000000;
       Console.WriteLine("{0} co luong la {1}", FullName, emp.TinhLuong(b));
    }
}
// tran thi mai anh -202105093
