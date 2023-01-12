using System;

namespace ConsoleDeliveryApplication
{
    internal class Order<TDelivery> where TDelivery : Delivery
    {
        public TDelivery TypeOfDelivery;
        protected int Number;
        public string Comment;
        private MyProducts products;
        public Order(TDelivery delivery, string сomment, MyProducts products)
        {
            Random temp = new Random();
            Number = temp.Next(10000, int.MaxValue);
            TypeOfDelivery = delivery;
            Comment = сomment;
            this.products = products;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Информация о заказе №{Number}");
            Console.WriteLine(TypeOfDelivery);
            Console.WriteLine(products);
            Console.WriteLine($"Коментарий к заказу: {Comment}");
        }
        // Номер заказа это 5-значный код, по которому его можно будет идентифицировать
        // Поле Discription переименовано в Comment, т. к. у каждого товара в заказе есть своё описание
        // Например, пользователь может оставить пожелание по доставке написав коментарий
    }


}
