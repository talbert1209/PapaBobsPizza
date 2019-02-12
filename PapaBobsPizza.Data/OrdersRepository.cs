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
            var dbOrders = db.Orders.ToList();

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
    }
}
