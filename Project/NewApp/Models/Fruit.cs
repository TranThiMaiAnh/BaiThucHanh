namespace NewApp.Models
 {
 public class Fruit{
        public string NameFruit  {get; set;}
        public int Weight  {get; set;}
        public double Cost  {get; set;}

        public void EnterData()
        {
            System.Console.Write("Name Fruit = ");
            NameFruit = Console.ReadLine();
            System.Console.Write("Weight = ");
           Weight = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Cost = ");
            Cost = Convert.ToDouble(Console.ReadLine());

        }

        public void Display()
        {
            System.Console.WriteLine("{0} + {1} + {2}" , NameFruit,Weight, Cost);
        }
 }
 }
