﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryApp.Models
{
    public enum OrderItemStatus
    {
        Queued,
        Preparing,
        Prepared,
        Cancelled
    }

    public class OrderItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double? Discount { get; set; }
        public OrderItemStatus Status { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int? MealId { get; set; }
        public virtual Meal Meal { get; set; }
        public int? RestaurantId { get; set; }
    }
}
