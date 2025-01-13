using ProjectComputer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProjectComputer.Core.Repositories
{
    public interface ICustomerRepository
    {
        public List<Customer> GetListCustomers();
        public Customer GetById(int id);
        public bool AddCustomer(Customer customer);
        public bool Put(int id, Customer customer);

        public bool Delete(int id);
    }
}
