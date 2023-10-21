using BusinessObjects.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IRoleRepository
    {
        public void UpdateRole(Role role);

        public void DeleteRole(int roleId);


        public List<Role?> GetAllRole();

        public Role GetRoleById(int id);

        public void AddNewRole(Role newRole);

    }
}
