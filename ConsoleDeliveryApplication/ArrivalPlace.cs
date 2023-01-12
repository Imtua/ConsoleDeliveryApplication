using System;

namespace ConsoleDeliveryApplication
{
    abstract class ArrivalPlace
    {
        public string Adress;
        public string Number;
        public ArrivalPlace(string adress, string number)
        {
            Adress = adress;
            Number = number;
        }
    }
    class PointOfIssue : ArrivalPlace
    {
        public PointOfIssue(string adress, string number) : base(adress, number)
        {
        }
        public override string ToString()
        {
            return $"Информация о пункте выдачи:\nАдрес: {Adress}\nКонтактный телефон телефона: {Number}";
        }
    }
    class ShopOfIssue : ArrivalPlace
    {
        public ShopOfIssue(string adress, string number) : base(adress, number)
        { 
        }
        public override string ToString()
        {
            return $"Информация о магазине:\nАдрес: {Adress}\nКонтактный телефон телефона: {Number}";
        }
    }
}
