namespace NewApp.Models
 {
 public class Fruit {
        public string FruitName {get;set;}
        public string Information {get; set;}
       

        // phuong thuc co gia tri tra ve-Fruit
        public int ThanhTien ( int CanNang)
        {
            int TTien = CanNang *2;
            return TTien;
        }
 }
 } 
        