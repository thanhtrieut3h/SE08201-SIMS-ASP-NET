using Microsoft.EntityFrameworkCore;
using SIMS.Interfaces;
using SIMS.SimsDB;
using SIMS.SimsDB.Entities;

namespace SIMS.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SimsDbContext _dbContext;
        public UserRepository(SimsDbContext context)
        {
            _dbContext = context;
        }
        public async Task<User?> GetUserById(int id)
        {
            return await _dbContext.Users.FindAsync(id).AsTask();
        }

        public async Task<User?> GetUserByUsername(string username)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(u => u.Username == username);
        }
    }
}
