using NewApp.Models;
public class Program{   
     public static void Main(String[] args){
      Students std= new Students();
       string str ="tran thi mai anh";
       int a = 20;
       Console.WriteLine("{0} nam sinh la: {1}", str, std.GetYearOfBirth(a));
    }
}
// tran thi mai anh -202105093
