using Microsoft.EntityFrameworkCore;
using ProjectComputer.Core.Entities;
using ProjectComputer.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectComputer.Data.Repository
{
    public class RentingRepository : IRentingRepository
    {
        private readonly DataContext _datacontext;
        public RentingRepository(DataContext dataContext)
        {
            _datacontext = dataContext;
        }
        public bool AddRenting(Renting rentPost)
        {
          _datacontext.Listrentin.Add(rentPost);
            _datacontext.SaveChanges();
            return true;
        }

        public bool DeleteRenting(int id)
        {
            _datacontext.Listrentin.Remove(GetById(id));
            _datacontext.SaveChanges();

            return true;
        }

        public Renting GetById(int id)
        {
            return _datacontext.Listrentin.ToList().Find(x=>x.Id == id);
        }

        public List<Renting> GetRentingList()
        {
            return _datacontext.Listrentin.ToList();
        }

        public bool UpdateRenting(int id, Renting rentPut)
        {
            DeleteRenting(id);
            AddRenting(rentPut);
            _datacontext.SaveChanges();
            return true ;
        }
    }
}
