using ShopsRUs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.Contracts
{
    public interface IUserRepository
    {
        Task<IEnumerable<Users>> GetAllCustomers(bool trackChanges);
        void CreateUser(Users user, string userType);
        Task<Users> GetCustomerById(int customerId, bool trackChanges);
        Task<Users> GetCustomersByName(string name, bool trackChanges); 
    }
}
