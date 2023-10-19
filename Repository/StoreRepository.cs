using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface StoreRepository
    {
        public List<Store> GetStores(); 
        public Store GetStoreById(int id);
        public void AddStore(Store store);
        public void DeleteStore(Store store);
        public void UpdateStore(Store store);

    }
}
