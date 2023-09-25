namespace NewApp.Models
 {
 public class Fruit {
        public string FruitName {get;set;}
        public string Information {get; set;}
       

        // phuong thuc khoi tao-Fruit
        public Fruit()
        {
            FruitName = "ten  ";
            Information ="thong tin";
           
        }
        public void Display()
            {
                
                System.Console.WriteLine("{0}-{1} ",FruitName,Information);
            }
 }
 } 
        