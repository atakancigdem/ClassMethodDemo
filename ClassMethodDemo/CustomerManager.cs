using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri Kayıt");
            Console.WriteLine("Ad Soyad : " + customer.Name + " " + customer.Surname);
            Console.WriteLine("Müşterinin Yaşı : " + customer.Age);
            Console.WriteLine("Müşteri E-posta : " + customer.Mail);
            Console.WriteLine("Harika, müşteri kayıt oldu. Id : " + customer.Id);
            Console.WriteLine(" ");
        }

        public void List(Customer customer)
        {
            Console.WriteLine("Müşteri Ad Soyad : " + customer.Name + " " + customer.Surname);
            Console.WriteLine("Müşteri Id : " + customer.Id);
            Console.WriteLine(" ");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri kayıtlardan silini : " + customer.Name + " " + customer.Surname);
        }

    }
}
