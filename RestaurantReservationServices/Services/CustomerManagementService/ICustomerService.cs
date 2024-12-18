﻿using RestaurantReservationServices.DTOs.CustomerDTOs;

namespace RestaurantReservationServices.Services.CustomerManagementService
{
    public interface ICustomerService
    {
        Task<List<CustomerReadDTO>> GetAllCustomersAsync();
        Task<CustomerReadDTO> GetCustomerByIdAsync(int id);
        Task<int> AddCustomerAsync(CustomerCreateDTO customer);
        Task UpdateCustomerAsync(int Id, CustomerUpdateDTO customer);
        Task DeleteCustomerAsync(int Id);
        Task<List<CustomerReadDTO>> GetCustomersWithBigPartySizeAsync(int partySize);
        Task CheckIfEmailAlreadyExists(string email);
    }
}
