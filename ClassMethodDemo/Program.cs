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

            Customer customer2 = new Customer();

            customer2.Name = "Furkan";
            customer2.Surname = "Çiğdem";
            customer2.Age = 29;
            customer2.Id = 2222;

            Customer customer3 = new Customer();

            customer3.Name = "Melek";
            customer3.Surname = "Gül";
            customer3.Age = 46;
            customer3.Id = 3333;

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

           

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            Console.WriteLine("Kayıtlı olan müşteriler");
            Console.WriteLine(" ");

            CustomerManager customerManager2 = new CustomerManager();
            customerManager.List(customer1);
            customerManager.List(customer2);
            customerManager.List(customer3);

            Console.WriteLine("------------");

            CustomerManager customerManger3 = new CustomerManager();
            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
            customerManager.Delete(customer3);
        }
    }
}
