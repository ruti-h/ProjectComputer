using ProjectComputer.Core.Entities;
using ProjectComputer.Core.Repositories;
using ProjectComputer.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectComputer.Service
{
    public class CusromerService : ICustomerService
    {
        private readonly ICustomerRepository _CustomerRepository;
        public CusromerService(ICustomerRepository customerService)
        {
            _CustomerRepository = customerService;
        }
        public bool AddCustomer(Customer customer)
        {
            return _CustomerRepository.AddCustomer(customer);
        }

        public bool Delete(int id)
        {
            _CustomerRepository.Delete(id);
            return true;
        }

        public Customer GetById(int id)
        {
            return _CustomerRepository.GetById(id);
        }

        public List<Customer> GetListCustomers()
        {
            return _CustomerRepository.GetListCustomers();
        }

        public bool Put(int id, Customer customer)
        {
              Delete(id);
            AddCustomer(customer);
            return true;
        }
    }
}
