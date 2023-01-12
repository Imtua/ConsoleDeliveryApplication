using System;

namespace ConsoleDeliveryApplication
{
    abstract class Delivery
    {
        abstract public string Adress { get; }
        abstract public string ContactNumber { get; }
    }
    //Доставка на дом
    class HomeDelivery : Delivery
    {
        public Courier Courier;
        public Client Client;
        public HomeDelivery(Client client, Courier courier)
        {
            Courier = courier;
            Client = client;
        }
        public override string Adress 
        {
            get { return Client.Adress; }
        }
        public override string ContactNumber 
        {
            get { return Client.GetPhoneNumber(); }
        }
        public override string ToString()
        {
            return "Доставка на дом\n" + Client.ToString() + "\n" + Courier.ToString(); 
        }
    }
    // Доставка в пункт выдачи
    class PickPointDelivery : Delivery
    {
        private DateTime _receiptDate;
        private DateTime _expirationDate;
        private PointOfIssue _pickPoint;
        public override string Adress 
        { 
            get { return _pickPoint.Adress; } 
        }
        public override string ContactNumber
        {
            get { return _pickPoint.Number; }
        }
        public string ExporationDay
        {
            get { return _expirationDate.ToShortDateString(); }
        }
        public string ReceiptDay
        {
            get { return _receiptDate.ToShortDateString(); }
        }
        public PickPointDelivery(PointOfIssue point)
        {
            // дата прибытия в пункт выдачи должна высчитываться с учетом расстояния от склада до пункта выдачи
            // на данный момент мы не обладаем такой информацией, поэтому в качестве примера взята текущая дата
            // срок хранения заказа с момента прибытия 7 дней
            _pickPoint = point;
            _receiptDate = DateTime.Now;
            _expirationDate = _receiptDate.AddDays(7);
        }
        public void IncreaseExpirationDate(int days)
        {
            _expirationDate = _expirationDate.AddDays(days);
        }
        public override string ToString()
        {
            return "Доставка в пункт выдачи\n" + _pickPoint.ToString() + "\n" +
                $"Дата доставки: {_receiptDate}, можно забрать до: {_expirationDate}";
        }
    }
    // Доставка в магазин
    class ShopDelivery : Delivery
    {
        private ShopOfIssue _shop;
        public ShopDelivery(ShopOfIssue shop)
        {
            _shop = shop;
        }
        public override string Adress
        {
            get { return _shop.Adress; }
        }
        public override string ContactNumber
        {
            get { return _shop.Number; }
        }
        public override string ToString()
        {
            return "Доставка в пункт магазин\n" + _shop.ToString();
        }
    }

}
