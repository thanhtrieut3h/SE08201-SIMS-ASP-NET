using SIMS.Interfaces;
using SIMS.SimsDB.Entities;

namespace SIMS.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;
        public UserService(IUserRepository repository)
        {
            _repo = repository;
        }
        public async Task<User?> LoginUserAsync(string username, string password)
        {
            var user = await _repo.GetUserByUsername(username);
            if (user == null) return null;
            // xu ly giai ma MK 
            return user.Password.Equals(password) ? user : null;
        }
    }
}
