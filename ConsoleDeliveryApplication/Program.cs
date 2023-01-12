using ConsoleDeliveryApplication;

TestClient();

static void TestClient()
{
    Client client1 = new Client("Иван", "Иванов", "Иванович", "89998887766",
        "г.Санкт-Петербург, наб.Грибоедов д.6 кв.44");
    Courier courier1 = new Courier("Петров", "Петр", "Федорович", "89897772211");
    HomeDelivery hd = new(client1, courier1);
    string comment = "Как можно быстрее";
    MyProducts products = new MyProducts(new Product("Процессор Intel Core i5-10400F OEM", 9999,
        "Процессор Intel Core i5-10400F OEM способен проявить свою эффективность в составе игровых систем и мощных рабочих станций."),
        new Product("Видеокарта MSI GeForce RTX 3050 GAMING",28999, 
        "Видеокарта GeForce RTX 3050 создана на базе высокопроизводительной архитектуры NVIDIA Ampere. "));
    Order<HomeDelivery> order1 = new Order<HomeDelivery>(hd, comment, products);
    order1.ShowInfo();

    }