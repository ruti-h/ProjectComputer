using ProjectComputer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectComputer.Core.Repositories
{
    public interface IComputerRepository
    {
        public List<Computer> GetListComputer();
        public Computer GetComputerById(int id);
        public bool AddComputer(Computer computerAdd);
        public bool DeleteComputer(int id);
        public bool UpdateComputer(int id, Computer computerPut);

    }
}
