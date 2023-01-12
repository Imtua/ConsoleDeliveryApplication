using System;

namespace ConsoleDeliveryApplication
{
    class MyProducts
    {
        public Product[] Products;
        public MyProducts(params Product[] products)
        {
            Products = products;
        }
        public decimal GetTotalPrice()
        {
            decimal total = 0;
            foreach (var item in Products)
            {
                total += item.Price;
            }
            return total;
        }
        public override string ToString()
        {
            string temp = "Спиок товаров\n";
            
           
            
            for (int i = 0; i < Products.Length; i++)
            {
                temp += $"{i + 1} - "+ Products[i].ToString() + "\n";

            }
            temp += $"Итого: {GetTotalPrice()} р.";
            return temp;
        }
        public Product this[int index] 
        {
            get {
                if (index < 0 && index >= Products.Length)
                    {
                        return null;
                    }
                return Products[index]; 
                }
            set {
                if (index < 0 && index >= Products.Length)
                {
                   throw new ArgumentOutOfRangeException("такого значения нет");
                }
                Products[index] = value;
            }
        }
    }
    internal class Product
    {
        public string Name { get; set; } 
        public decimal Price { get; set; }
        public string Description { get; set; }
        private int _quantity = 1;
        public Product(string name, decimal price, string description)
        {
            Name = name;
            Price = price;
            Description = description;
        }
        public static Product operator ++(Product a)
        {
            a.Price += a.Price;
            a._quantity++;
            return a;
        }
        public static Product operator --(Product a)
        {
            if (a._quantity<=1)
            {
                return null;
            }
            a.Price -= a.Price;
            a._quantity--;
            return a;
        }
        public override string ToString()
        {
            return $"Название: {Name} Цена: {Price} р. Описание: {Description} Количество: {_quantity} " ;
        }
    }
}
