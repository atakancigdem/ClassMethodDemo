using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();

            customer1.Name = "Atakan";
            customer1.Surname = "Çiğdem";
            customer1.Age = 19;
            customer1.Id = 1111;
            customer1.Mail = "atakan@outlook.com";

            Customer customer2 = new Customer();

            customer2.Name = "Furkan";
            customer2.Surname = "Çiğdem";
            customer2.Age = 29;
            customer2.Id = 2222;
            customer2.Mail = "furkan@outlook.com";

            Customer customer3 = new Customer();

            customer3.Name = "Melek";
            customer3.Surname = "Gül";
            customer3.Age = 46;
            customer3.Id = 3333;
            customer3.Mail = "melek@outlook.com";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

           

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            Console.WriteLine("------------");

            CustomerManager customerManager3 = new CustomerManager();
            customerManager.List(customer1);
            customerManager.List(customer2);
            customerManager.List(customer3);

            Console.WriteLine("------------");

            CustomerManager customerManager4 = new CustomerManager();
            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
            customerManager.Delete(customer3);
        }

    //    output ==>

    //    Müşteri Kayıt
    //    Ad Soyad : Atakan Çiğdem
    //    Müşterinin Yaşı : 19
    //    Müşteri E-posta : atakan @outlook.com
    //    Harika, müşteri kayıt oldu.Id : 1111

    //    Müşteri Kayıt
    //    Ad Soyad : Furkan Çiğdem
    //    Müşterinin Yaşı : 29
    //    Müşteri E-posta : furkan @outlook.com
    //    Harika, müşteri kayıt oldu.Id : 2222

    //    Müşteri Kayıt
    //    Ad Soyad : Melek Gül
    //    Müşterinin Yaşı : 46
    //    Müşteri E-posta : melek @outlook.com
    //    Harika, müşteri kayıt oldu.Id : 3333

    //    ------------
    //    Müşteri Ad Soyad : Atakan Çiğdem
    //    Müşteri Id : 1111

    //    Ad Soyad : Furkan Çiğdem
    //    Müşteri Id : 2222

    //    Müşteri Ad Soyad : Melek Gül
    //    Müşteri Id : 3333

    //    ------------
    //    kayıtlardan silini : Atakan Çiğdem
    //    Müşteri kayıtlardan silini : Furkan Çiğdem
    //    kayıtlardan silini : Melek Gül
    //
    }
}
