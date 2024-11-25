﻿using AutoMapper;
using RestaurantReservationCore.Db.DataModels;
using RestaurantReservationCore.Db.Repositories.CustomerManagement;
using RestaurantReservationServices.DTOs.CustomerDTOs;

namespace RestaurantReservationServices.Services.CustomerManagementService
{
    public class CustomerService: ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        private readonly IMapper _mapper;
        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<List<CustomerReadDTO>> GetAllCustomersAsync()
        {
            var customers = await _customerRepository.GetAllAsync();
            return _mapper.Map<List<CustomerReadDTO>>(customers);
        }

        public async Task<CustomerReadDTO> GetCustomerByIdAsync(int id)
        {
            var customer = await _customerRepository.GetByIdAsync(id);
            return _mapper.Map<CustomerReadDTO>(customer);
        }

        public async Task<int> AddCustomerAsync(CustomerCreateDTO customer)
        {
            var newCustomer = _mapper.Map<Customer>(customer);
            await _customerRepository.AddAsync(newCustomer);
            return newCustomer.CustomerId;
        }

        public async Task UpdateCustomerAsync(int Id, Customer customer)
        {
            Customer updatedCustomer = await _customerRepository.GetByIdAsync(Id);
            if (updatedCustomer == null)
            {
                Console.WriteLine("Customer not found");
                return;
            }
            updatedCustomer.PhoneNumber = customer.PhoneNumber;
            updatedCustomer.Email = customer.Email;
            updatedCustomer.FirstName = customer.FirstName;
            updatedCustomer.LastName = customer.LastName;
            await _customerRepository.UpdateAsync(updatedCustomer);
        }

        public async Task DeleteCustomerAsync(int id)
        {
            var customer = await _customerRepository.GetByIdAsync(id);
            await _customerRepository.DeleteAsync(customer);
        }

        public async Task GetCustomersWithBigPartySizeAsync(int partySize)
        {
            var customers = await _customerRepository.GetCustomersWithBigPartySizeAsync(partySize);
            if (!customers.Any())
            {
                Console.WriteLine("No customers found");
                return;
            }
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
        }
    }
}