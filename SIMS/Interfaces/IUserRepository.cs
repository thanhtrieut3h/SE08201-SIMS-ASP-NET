using SIMS.SimsDB.Entities;

namespace SIMS.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetUserByUsername(string username);
        Task<User?> GetUserById(int id);
    }
}
