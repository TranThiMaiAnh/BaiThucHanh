namespace NewApp.Models
{
    public class Person
    {
        public string FullName  {get; set;}
        public string Address  {get; set;}
        public int Age  {get; set;}
    public Person()
    {
        FullName = "Ho ten mac dinh";
        Address = "Dia chi mac dinh";
        Age = 20;
    }

    public void Display()
    {
        System.Console.WriteLine("{0} + {1} + {2}" , FullName, Address, Age);
    }
    }
}