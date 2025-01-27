using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectComputer.Core.Entities
{
    public class Renting
    {

        public int Id { get; set; }
        public int IdCustomer { get; set; }
        public DateTime DateRenting { get; set; }
        public bool Status { get; set; }
        public int computerId { get; set; }

        public Computer computer { get; set; }

        public Customer customer { get; set; }
        public int customerId { get; set; }

        public Renting()
        {
            
        }
    }
}
