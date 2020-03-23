using System.Collections.Generic;

namespace IntermediateLevel
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        // this is our constructor, it is names as the class. constructor can have overloading. Which constructor is used depends on the parameters provided
        public Customer()
        {
            Orders = new List<Order>();
        }

        // calling this like below will call the previous constructor, which will avoid the need to initialize Orders in this constructor also
        public Customer(int id)
            : this()
        {
            this.Id = id;
        }

        // calling this like below will call the constructor with id, which will set the id
        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
    }
}
