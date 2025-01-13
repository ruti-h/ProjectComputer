using ProjectComputer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectComputer.Core.Service
{
    public interface IRentingService
    {
        public List<Renting> GetRentingList();
        public Renting GetById(int id);
        public bool AddRenting(Renting rentPost);
        public bool UpdateRenting(int id, Renting rentPut);
        public bool DeleteRenting(int id);

    }
}
