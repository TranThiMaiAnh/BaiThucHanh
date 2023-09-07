// See https://aka.ms/new-console-template for more information
public class Program
{
    private static void Main(string[]args)
    {

       //câu lệnh switch...case
       int day = 8;
   switch(day){
   case 1: System.Console.WriteLine("Sunday"); break;
  case 2: System.Console.WriteLine("Monday"); break;
  case 3: System.Console.WriteLine("Tuesday"); break;
  case 5: System.Console.WriteLine("wednesday"); break;
  case 6: System.Console.WriteLine("Friday"); break;

  default:
    System.Console.WriteLine("Không phai ngay trong tuan");
    break;
   }
   
}
}
