// See https://aka.ms/new-console-template for more information
public class Program
{
    private static void Main(string[]args)
    {

       //câu lệnh IF-ELSE
   int c = 10;
   if(c<0)
  {
  System.Console.WriteLine("{0} là số nguyên âm", c);
   }else{
  if( c % 2 == 0) {
   System.Console.WriteLine("{0} là số nguyên dương chẵn", c);
   }else{
   System.Console.WriteLine("{0} là số nguyên dưong lẻ", c);
     }
   }
}
}