using CarvuBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarvuBackend.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly CarvuDbContext _carvuDbContext;

        public CustomerService(CarvuDbContext carvuDbContext)
        {
            _carvuDbContext = carvuDbContext;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _carvuDbContext.Customers.ToList();
        }

        public Customer GetCustomer(Guid id)
        {
            return _carvuDbContext.Customers.Where(x => x.Id == id).FirstOrDefault();
        }
        public Customer AddCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new Exception("Customer information is empty.");
            }
            
            var newCustomer = _carvuDbContext.Customers.Add(customer).Entity;
            _carvuDbContext.SaveChanges();
            return newCustomer;
        }

        public Customer UpdateCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new Exception("Customer information is empty.");
            }

            var customerToUpdate = _carvuDbContext.Customers.Where(x => x.Id == customer.Id).FirstOrDefault();
            if (customerToUpdate == null)
            {
                throw new Exception("The customer was not found in the database.");
            }

            customerToUpdate.FirstName = customer.FirstName;
            customerToUpdate.LastName = customer.LastName;
            customerToUpdate.Street = customer.Street;
            customerToUpdate.City = customer.City;
            customerToUpdate.State = customer.State;
            customerToUpdate.Zip = customer.Zip;
            customerToUpdate.PhoneNumber = customer.PhoneNumber;
            customerToUpdate.License = customer.License;

            _carvuDbContext.SaveChanges();
            return customerToUpdate;
        }

        public void DeleteCustomer(Guid id)
        {
            var customerToDelete = _carvuDbContext.Customers.Where(x => x.Id == id).FirstOrDefault();
            if (customerToDelete == null)
            {
                throw new Exception("The customer to delete was not found in the database.");
            }

            _carvuDbContext.Customers.Remove(customerToDelete);
            _carvuDbContext.SaveChanges();
        }
    }
}
