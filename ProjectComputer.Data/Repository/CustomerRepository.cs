using ProjectComputer.Core.Entities;
using ProjectComputer.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectComputer.Data.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _dataContext;
        public CustomerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public bool AddCustomer( Customer customer)
        {
             _dataContext.customers.Add(customer);
            _dataContext.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            _dataContext.customers.Remove(GetById(id));
            _dataContext.SaveChanges();

            return true;
        }

        public Customer GetById(int id)
        {
          return  _dataContext.customers.ToList().Find(x => x.Id == id);
        }

        public List<Customer> GetListCustomers()
        {
           return _dataContext.customers.ToList();
        }

        public bool Put(int id, Customer customer)
        {
           Delete(id);
            AddCustomer(customer);
            _dataContext.SaveChanges();

            return true;
        }
    }
}
