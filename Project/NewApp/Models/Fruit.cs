namespace NewApp.Models
 {
 public class Fruit {
        public string FruitName {get;set;}
        public int weight {get; set;}
       

        // phuong thuc co gia tri tra ve-Fruit
       public void EnterData()
       {
        System.Console.Write("Fruit name = ");
        FruitName = Console.ReadLine();
        System.Console.Write("weight = ");
       
        // tran thi mai anh-2021050093
        // try...catch -Fruit
        try{
            weight = Convert.ToInt16(Console.ReadLine());
        } catch(Exception e)
        {
            weight = 0;
        }

    }
    public void Display()
    {
        System.Console.WriteLine("{0} + {1} " , FruitName, weight);
    }
}
 }

    
        