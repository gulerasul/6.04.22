using Json.Models;
using System.Collections.Generic;
using System;
using System.IO;
using Newtonsoft.Json;

namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            Product book1 = new Product { Id = 1, Name = "Xez Paltolu Madonna, Sebaheddin Eli", Price = 5.50 };
            Product book2 = new Product { Id = 2, Name = "Haradasan, Mark Levi", Price = 7.99 };
            Product book3 = new Product { Id = 3, Name = "Qurur ve Qerez, Jane Austen", Price = 9.99 };
            Product book4 = new Product { Id = 4, Name = "Min mmohteshem gunesh, Xalid Hüseyni", Price = 7.99 };
            Product book5 = new Product { Id = 5, Name = "Kimyager, Paulo Coelho", Price = 9.4 };

            OrderItem item1 = new OrderItem { Id = 1, Product = book1, Count = 2 };
            item1.TotalPrice = book1.Price * item1.Count;
            OrderItem item2 = new OrderItem { Id = 2, Product = book2, Count = 4 };
            item2.TotalPrice = book2.Price * item2.Count;
            OrderItem item3 = new OrderItem { Id = 3, Product = book3, Count = 1 };
            item3.TotalPrice = book3.Price * item3.Count;
            OrderItem item4 = new OrderItem { Id = 4, Product = book4, Count = 5 };
            item4.TotalPrice = book4.Price * item4.Count;
            OrderItem item5 = new OrderItem { Id = 5, Product = book5, Count = 3 };
            item5.TotalPrice = book5.Price * item5.Count;

            List<OrderItem> orderitems1 = new List<OrderItem>();
            orderitems1.Add(item1);
            orderitems1.Add(item3);
            orderitems1.Add(item5);
            List<OrderItem> orderitems2 = new List<OrderItem>();
            orderitems2.Add(item2);
            orderitems2.Add(item4);
            Order order1 = new Order { Id = 1, OrderItems = orderitems1 };
            Order order2 = new Order { Id = 2, OrderItems = orderitems2 };

            #region Serialize
            var jsonObj = JsonConvert.SerializeObject(order1);
            Console.WriteLine(jsonObj);
            using (StreamWriter sw = new StreamWriter(@"C:\Users\tu699evkp\Desktop\homework\product\Json\Json\Files\guler.json"))
            {
                sw.WriteLine(jsonObj);
            }
            #endregion
            #region Deserialize
            string result;
            using (StreamReader sr = new StreamReader(@"C:\Users\tu699evkp\Desktop\homework\product\Json\Json\Files\sebine.json"))
            {
                result = sr.ReadToEnd();

            }
            Order order = JsonConvert.DeserializeObject<Order>(result);
            foreach (var item in order.OrderItems)
            {
                Console.WriteLine(item.Product.Name);
            }

            #endregion



















        }
    }
}



