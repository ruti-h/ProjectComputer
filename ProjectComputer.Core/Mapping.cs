using ProjectComputer.Core.DTO;
using ProjectComputer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectComputer.Core
{
    public static class Mapping
    {
        public static CustomerDTO MapingDto(Customer customer)
        {
            return new CustomerDTO
            {
                Id = customer.Id,
                City = customer.City,
                Email = customer.Email
            ,
                KindComputer = customer.KindComputer,
                Name = customer.Name,
                Phone = customer.Phone
            };
        }
            
    }
}
