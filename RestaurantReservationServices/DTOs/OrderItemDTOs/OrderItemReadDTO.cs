﻿namespace RestaurantReservationServices.DTOs.OrderItemDTOs
{
    public class OrderItemReadDTO
    {
        public int OrderItemId { get; set; }
        public int Quantity { get; set; }
        public int MenuItemId { get; set; }
        public int OrderId { get; set; }
    }
}
