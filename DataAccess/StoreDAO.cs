using BusinessObjects.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class StoreDAO : StoreRepository
    {
        private LaundryMiddlePlatformContext _context;
        public StoreDAO()
        {
            _context = new LaundryMiddlePlatformContext();
        }
        public void AddStore(Store store)
        {
            _context.Add(store);
            _context.SaveChanges();
        }

        public void DeleteStore(Store store)
        {
            throw new NotImplementedException();
        }

        public Store GetStoreById(int id)
        {
            return _context.Stores.FirstOrDefault(x => x.StoreId == id);
        }

        public List<Store> GetStores()
        {
            return _context.Stores.ToList();
        }

        public void UpdateStore(Store store)
        {
            var oldStore = _context.Stores.FirstOrDefault(x => x.StoreId == store.StoreId);
            if (oldStore != null)
            {

                oldStore.StoreName = store.StoreName;
                oldStore.Address = store.Address;
                oldStore.Price = store.Price;
                oldStore.Status = store.Status;
                oldStore.Phone = store.Phone;

                _context.Update(oldStore);
                _context.SaveChanges();
            }
        }
    }
}
