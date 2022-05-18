using Dapper;
using FinanceMarketsApp.Infrastructure.SQL.Context;
using FinancialMarketsApp.Common.Interfaces;
using FinancialMarketsApp.Common.Models;

namespace FinanceMarketsApp.Infrastructure.SQL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DapperContext _dapperContext;
        public UserRepository(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task<User> FindById(Guid id)
        {
            var query = $"SELECT Id, Name, Email FROM Users WHERE Id='{id}'";

            using(var connection = _dapperContext.CreateConnection())
            {
                var user = await connection.QuerySingleAsync<User>(query);
                return user;
            }
        }

        public Task<User> GetUsersByEmail(string email)
        {
            return null;
        }

        public Task<User> GetUsersByName(string name)
        {
            return null;
        }
    }
}
