using System;
using System.Collections.Generic;

namespace InterfaceExampleShippingItem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IProductModel> cart = AddSampleData();
            CustomerModel customerDragos = GetCustomerModel();
            foreach(IProductModel prod in cart)
            {
                prod.ShipItem(customerDragos);
                if(prod is IDigitalProductModel digital)
                {
                    Console.WriteLine("for the "+digital.Title+" you have "+digital.TotalDownloadsLeft+" downloads left");
                }
            }
            Console.ReadLine();
        }

        private static CustomerModel GetCustomerModel()
        {
            return new CustomerModel
            {
                FirstName = "Dragos",
                LastName = "Ille",
                City = "Oradea",
                EmailAddress = "dragos@yahoo.com",
                PhoneNumber = "0777777777"  
            };
        }

        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();
            output.Add(new PhysicalProductModel { Title = "Laptop" });
            output.Add(new PhysicalProductModel { Title = "T-shit" });
            output.Add(new PhysicalProductModel { Title = "Book" });
            output.Add(new DigitalProductModel { Title = "Windows License" });
            output.Add(new CourseProductModel { Title = "C# complete " });

            return output;
        }
    }
}
