namespace NewApp.Models
 {
 public class Fruit {
        public string FruitName {get;set;}
        public string Information {get; set;}
       

        // phuong thuc chua tham so-Fruit
        public int ThanhTien ( int CanNang)
        {
            int TTien = CanNang *2;
            return TTien;
        }
 }
 } 
        