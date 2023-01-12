using System;

namespace ConsoleDeliveryApplication
{
   abstract internal class Person
    {
        protected string _firstName;
        protected string _secondName;
        protected string _thirdName;
        protected string _phoneNumber;
        public Person(string firstName, string secondName, string thirdName, string phoneNumber)
        {
            _firstName = firstName;
            _secondName = secondName;
            _thirdName = thirdName;
            _phoneNumber = phoneNumber;
        }
        public override string ToString()
        {
            return $"ФИО: {_secondName} {_firstName} {_thirdName}, номер телефона: {_phoneNumber}";
        }
        public string GetPhoneNumber() => _phoneNumber;
    }
    class Client : Person
    {
        public string Adress;
        public Client(string firstName, string secondName, string thirdName,
            string phoneNumber, string adress) : base(firstName, secondName, thirdName, phoneNumber) 
        {
            Adress = adress;
        }
        public override string ToString()
        {
            return $"Информация о клиенте:\n" + base.ToString() + $"\nАдрес: {Adress}";
        }
    }
    class Courier : Person
    {
        public Courier(string firstName, string secondName, string thirdName, string phoneNumber)
            : base(firstName, secondName, thirdName, phoneNumber) { }
        public override string ToString()
        {
            return $"Информация о курьере:\n" + base.ToString();
        }
    }
}
