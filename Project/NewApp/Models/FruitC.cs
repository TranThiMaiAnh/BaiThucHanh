namespace NewApp.Models
{
    public class FruitC: Fruit
    {
        //TRAN THI MAI ANH -2021050093
        public string Color{get; set;}
        

        public void EnterData()
        {
           base.EnterData();
            System.Console.Write("Mau sac = ");
            Color = Console.ReadLine(); 
        }

        public void Display()
        {
            base.Display();
            System.Console.Write("+ Mau sac: {0}  ",Color);
            }
            
        }

        }
