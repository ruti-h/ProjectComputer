
using ProjectComputer.Core.Entities;
using ProjectComputer.Core.Repositories;
using ProjectComputer.Core.Service;

namespace ProjectComputer.Service.Service
{
    public class ComputerService : IComputerService
    {

        private readonly IComputerRepository _computerRepository;
        public ComputerService(IComputerRepository computerRepository)
        {
            _computerRepository = computerRepository;
        }
        List<Computer> IComputerService.GetListComputer()
        {
           return _computerRepository.GetListComputer();
        }
        public bool AddComputer(Computer computerAdd)
        {
            _computerRepository.AddComputer(computerAdd);
            return true;
        }

        public bool DeleteComputer(int id)
        {
            _computerRepository.DeleteComputer(id);
            return true;
        }

        Computer IComputerService.GetComputerById(int id)
        {
            return _computerRepository.GetComputerById(id);

        }




        public bool UpdateComputer(int id, Computer computerPut)
        {
            DeleteComputer(id);
            AddComputer(computerPut);
            return true;

        }

    }
}
