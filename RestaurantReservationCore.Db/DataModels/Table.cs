﻿namespace RestaurantReservation.Db.DataModels
{
    public class Table
    {
        public int TableId { get; set; }
        public required int Capacity { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        public List<Reservation> Reservations { get; set; }
        public Table()
        {
            Reservations = new List<Reservation>();
        }
    }

}
