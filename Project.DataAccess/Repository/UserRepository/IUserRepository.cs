using System.Linq.Expressions;
using Microsoft.AspNetCore.Identity;
using Project.Domain.Entities.Identity;

namespace Project.DataAccess.Repository.UserRepository
{
    public interface IUserRepository
    {
        void SetGlobalQueryFilterStatus(bool status);
        Task<User> GetUserByNameAsync(string userName);

        Task<User> GetUserByNameAsync(string userName,
            params Expression<Func<User, object>>[] includeProperties);

        Task<User> GetUserByNameAsync(string userName, params string[] includeProperties);
        Task<User> GetUserByIdAsync(string userId);

        Task<User> GetUserByIdAsync(string userId,
            params Expression<Func<User, object>>[] includeProperties);

        Task<User> GetUserByIdAsync(string userId, params string[] includeProperties);

        Task<User> GetUserByEmailAsync(string email);
        IQueryable<User> FindBy(
            Expression<Func<User, bool>> predicate);

        IQueryable<User> FindBy(
            Expression<Func<User, bool>> predicate, params string[] includeProperties);
        IQueryable<User> FindBy(params string[] includeProperties);

        IQueryable<User> FindBy(params Expression<Func<User, object>>[] includeProperties);

        IQueryable<User> FindBy(
            Expression<Func<User, bool>> predicate,
            params Expression<Func<User, object>>[] includeProperties);

        IQueryable<User> GetAll();


        IQueryable<User> GetAll(params string[] includeProperties);


        IQueryable<User> GetAll(
            params Expression<Func<User, object>>[] includeProperties);




        Task<bool> IsExistAsync(Expression<Func<User, bool>> predicate);

        Task<IdentityResult> CreateAsync(User user, string password);


        Task<IdentityResult> UpdateAsync(User user);


        Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword,
            string newPassword);

        Task<IdentityResult> ResetPasswordAsync(User user, string token, string newPassword);

        Task Delete(User user);
    }
}
