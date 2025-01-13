using ProjectComputer.Core.Entities;
using ProjectComputer.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectComputer.Data.Repository
{

    public class ComputerRepository : IComputerRepository
    {
        private readonly DataContext _dataContext;
        public ComputerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public bool AddComputer(Computer computerAdd)
        {
            _dataContext.computers.Add(computerAdd);
            _dataContext.SaveChanges();
            return true;
        }

        public bool DeleteComputer(int id)
        {
           _dataContext.computers.Remove(GetComputerById(id));
            _dataContext.SaveChanges();

            return true;
        }

        public Computer GetComputerById(int id)
        {
          return  _dataContext.computers.ToList().Find(x => x.Id == id);
        }

        public List<Computer> GetListComputer()
        {
            return _dataContext.computers.ToList();
        }

        public bool UpdateComputer(int id, Computer computerPut)
        {
            DeleteComputer(id);
            AddComputer(computerPut);
            _dataContext.SaveChanges();

            return true;
        }
    }
}
