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
    public class RentingService : IRentingService
    {
        private readonly IRentingRepository _rentingRepository;
        public RentingService(IRentingRepository rentingRepository)
        {
            _rentingRepository = rentingRepository;
        }
        public bool AddRenting(Renting rentPost)
        {
            _rentingRepository.AddRenting(rentPost);
            return true;    
        }

        public bool DeleteRenting(int id)
        {
            _rentingRepository.DeleteRenting(id);
            return true;
        }

        public Renting GetById(int id)
        {
          return _rentingRepository.GetById(id);
        }

        public List<Renting> GetRentingList()
        {
            return _rentingRepository.GetRentingList();
        }

        public bool UpdateRenting(int id, Renting rentPut)
        {
            DeleteRenting(id);
            AddRenting(rentPut);
            return true;
        }
    }
}
