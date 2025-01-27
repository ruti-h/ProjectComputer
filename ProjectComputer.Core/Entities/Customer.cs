using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectComputer.Core.Entities
{
    public class Customer
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
       
        public string KindComputer { get; set; }
        public List<Renting> Rentals { get; set; }
        public Customer()
        {
            
        }
    }
}
