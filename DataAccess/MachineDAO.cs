using BusinessObjects.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class MachineDAO : MachineRepository
    {
        private LaundryMiddlePlatformContext _context;
        public MachineDAO()
        {
            _context = new LaundryMiddlePlatformContext();
        }
        public void AddWashingMachine(WashingMachine washingMachine)
        {
            _context.Add(washingMachine);
            _context.SaveChanges();
        }

        public void DeleteWashingMachine(WashingMachine washingMachine)
        {
            throw new NotImplementedException();
        }

        public WashingMachine GetWashingMachineById(int washingMachineId)
        {
            return _context.WashingMachines.FirstOrDefault(x => x.MachineId == washingMachineId);
        }

        public List<WashingMachine> GetWashingMachines()
        {
           return _context.WashingMachines.ToList();    
        }

        public void UpdateWashingMachine(WashingMachine washingMachine)
        {
            var oldWashingMachine = _context.WashingMachines.FirstOrDefault(x => x.MachineId == washingMachine.MachineId);
            if (oldWashingMachine != null)
            {

                oldWashingMachine.MachineName = washingMachine.MachineName;
                oldWashingMachine.Performmance = washingMachine.Performmance;
                oldWashingMachine.Status = washingMachine.Status;
                oldWashingMachine.StoreId = washingMachine.StoreId;

                _context.Update(oldWashingMachine);
                _context.SaveChanges();
            }
        }
    }
}
