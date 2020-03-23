using System;

namespace IntermediateLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1, "Tony");
            Console.WriteLine(customer.Id);

            Order order = new Order();
            customer.Orders.Add(order);
            Console.WriteLine(customer.Orders[0]);
        }
    }
}
