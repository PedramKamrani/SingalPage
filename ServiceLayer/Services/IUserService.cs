using DataLayer.Entites.Account;

namespace AngularEshop.Core.Services.Interfaces
{
    public interface IUserService : IDisposable
    {
        Task<List<User>> GetAllUsers();
    }
}