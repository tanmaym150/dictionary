using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer()
            {
                ID = 101,
                Name = "mark",
                Salary = 5000

            };

            Customer c2 = new Customer()
            {
                ID = 102,
                Name = "john",
                Salary = 8000

            };

            Customer c3 = new Customer()
            {
                ID = 103,
                Name = "bob",
                Salary = 9000

            };

            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
            dictionaryCustomers.Add(c1.ID, c1);
            dictionaryCustomers.Add(c2.ID, c2);
            dictionaryCustomers.Add(c3.ID, c3);

            foreach(var v in dictionaryCustomers)
            {
                Console.WriteLine("The data in dictionary is of:{0},{1},{2}",v.Key,v.Value.Name,v.Value.Salary);
            }
            Console.WriteLine("dictionary contains:{0}", dictionaryCustomers.ContainsKey(101));
            Console.WriteLine("dictionary contains:{0}", dictionaryCustomers.ContainsValue(c3));


            Customer cust;
            if (dictionaryCustomers.TryGetValue(101, out cust))
            {
                Console.WriteLine("id={0},name={1},salary={2}", cust.ID, cust.Name, cust.Salary);
            }
            else
            {
                Console.WriteLine("key not found");
            }
            bool v1 = dictionaryCustomers.Remove(101);
            foreach (var v in dictionaryCustomers)
            {
                Console.WriteLine("The data in dictionary is of:{0},{1},{2}", v.Key, v.Value.Name, v.Value.Salary);
            }


        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

    }
    
}
