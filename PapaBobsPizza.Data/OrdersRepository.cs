using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaBobsPizza.Data
{
    public class OrdersRepository
    {
        public static List<DTO.Order> GetOrders()
        {
            PBPizzaDBEntities db = new PBPizzaDBEntities();
            var dbOrders = db.Orders.Where(p => p.Completed == true).ToList();

            var dtoOrders = new List<DTO.Order>();

            foreach (var dbOrder in dbOrders)
            {
                var dtoOrder = new DTO.Order
                {
                    OrderId = dbOrder.OrderId,
                    Size = dbOrder.Size,
                    Crust = dbOrder.Crust,
                    Sausage = dbOrder.Sausage,
                    Pepperoni = dbOrder.Pepperoni,
                    Onions = dbOrder.Onions,
                    GreenPeppers = dbOrder.GreenPeppers,
                    TotalCost = dbOrder.TotalCost,
                    Name = dbOrder.Name,
                    Address = dbOrder.Address,
                    ZipCode = dbOrder.ZipCode,
                    PhoneNumber = dbOrder.PhoneNumber,
                    PaymentType = dbOrder.PaymentType,
                    Completed = dbOrder.Completed
                };

                dtoOrders.Add(dtoOrder);
            }

            return dtoOrders;
        }

        public static void AddOrder(DTO.Order newOrder)
        {
            PBPizzaDBEntities db = new PBPizzaDBEntities();
            var orders = db.Orders;

            var order = new Order
            {
                Size = newOrder.Size,
                Crust = newOrder.Crust,
                Sausage = newOrder.Sausage,
                Pepperoni = newOrder.Pepperoni,
                Onions = newOrder.Onions,
                GreenPeppers = newOrder.GreenPeppers,
                TotalCost = newOrder.TotalCost,
                Name = newOrder.Name,
                Address = newOrder.Address,
                ZipCode = newOrder.ZipCode,
                PhoneNumber = newOrder.PhoneNumber,
                PaymentType = newOrder.PaymentType,
                Completed = newOrder.Completed
            };

            orders.Add(order);
            db.SaveChanges();
        }
    }
}
