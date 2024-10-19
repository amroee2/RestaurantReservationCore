﻿using Microsoft.EntityFrameworkCore;
using RestaurantReservationCore.Db.DataModels;

namespace RestaurantReservationCore.Db.Repositories
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly RestaurantReservationDbContext _context;
        public RestaurantRepository(RestaurantReservationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Restaurant>> GetAllAsync()
        {
            return await _context.Restaurants.ToListAsync();
        }

        public async Task<Restaurant> GetByIdAsync(int id)
        {
            return await _context.Restaurants.FirstOrDefaultAsync(r => r.RestaurantId == id);
        }

        public async Task AddAsync(Restaurant restaurant)
        {
            await _context.Restaurants.AddAsync(restaurant);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Restaurant restaurant)
        {
            _context.Restaurants.Update(restaurant);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Restaurant restaurant)
        {
            var employees = _context.Employees
                .Where(e => e.RestaurantId == restaurant.RestaurantId);
            _context.Employees.RemoveRange(employees);

            var tables = _context.Tables
                .Where(t => t.RestaurantId == restaurant.RestaurantId);
            _context.Tables.RemoveRange(tables);

            _context.Restaurants.Remove(restaurant);

            await _context.SaveChangesAsync();
        }



        public async Task<decimal> CalculateRestaurantRevenue(int restaurantId)
        {
            var revenue = await _context.Database
                .SqlQuery<decimal>($"SELECT dbo.CalculateRestaurantRevenue({restaurantId}) AS Value")
                .FirstOrDefaultAsync();
            return revenue;
        }
    }
}
