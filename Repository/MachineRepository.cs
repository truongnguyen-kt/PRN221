using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface MachineRepository
    {
        public List<WashingMachine> GetWashingMachines();
        public void AddWashingMachine(WashingMachine washingMachine);
        public void UpdateWashingMachine(WashingMachine washingMachine);
        public void DeleteWashingMachine(WashingMachine washingMachine);
        public WashingMachine GetWashingMachineById(int washingMachineId);
    }
}
