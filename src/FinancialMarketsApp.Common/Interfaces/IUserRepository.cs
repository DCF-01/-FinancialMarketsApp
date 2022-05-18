using FinancialMarketsApp.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialMarketsApp.Common.Interfaces
{
    public interface IUserRepository
    {
        Task<User> FindById(Guid id);
        Task<User> GetUsersByName(string name);
        Task<User> GetUsersByEmail(string email);

    }
}
