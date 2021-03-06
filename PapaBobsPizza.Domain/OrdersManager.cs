﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PapaBobsPizza.Data;

namespace PapaBobsPizza.Domain
{
    public class OrdersManager
    {
        public static List<DTO.Order> GetOrders()
        {
            var orders = Data.OrdersRepository.GetOrders();
            return orders;
        }

        public static void AddOrder(DTO.Order newOrder)
        {
            Data.OrdersRepository.AddOrder(newOrder);
        }

        public static void CompleteOrder(int orderId)
        {
            Data.OrdersRepository.CompleteOrder(orderId);
        }
    }
}
