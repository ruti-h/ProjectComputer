using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectComputer.Core.Entities
{
    public class Computer
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Destination { get; set; }
        public int Price { get; set; }
        public int DorComputer { get; set; }
        public List<Renting> Rentals { get; set; }

        public Computer()
        {
            
        }
    }
}
