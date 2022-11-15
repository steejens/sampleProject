using Project.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Web;
using Project.Core.Enums.Enitity;

namespace Project.DataAccess.Repository.UserRepository
{
    public class UserRepository : IUserRepository, IRepositoryIdentifier
    {
        private readonly UserManager<User> _userManager;
        private bool _isQueryFilterApplied = true;
        public UserRepository(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public void SetGlobalQueryFilterStatus(bool status)
        {
            this._isQueryFilterApplied = status;
        }
        public Task<User> GetUserByNameAsync(string userName)
        {
            if (string.IsNullOrEmpty(userName))
                return Task.FromResult<User>(null);
            return _userManager.Users.ApplyQueryFilter(this._isQueryFilterApplied).FirstOrDefaultAsync(c => c.UserName.ToLower() == userName.ToLowerInvariant());
        }
        public Task<User> GetUserByNameAsync(string userName, params Expression<Func<User, object>>[] includeProperties)
        {
            if (includeProperties == null) throw new ArgumentNullException(nameof(includeProperties));
            if (string.IsNullOrEmpty(userName))
                return Task.FromResult<User>(null);
            var query = _userManager.Users.ApplyQueryFilter(this._isQueryFilterApplied).IncludeAll(includeProperties);
            return query.FirstOrDefaultAsync(c => c.UserName.ToLower() == userName.ToLowerInvariant());
        }
        public Task<User> GetUserByNameAsync(string userName, params string[] includeProperties)
        {
            if (string.IsNullOrEmpty(userName))
                return Task.FromResult<User>(null);
            var query = _userManager.Users.ApplyQueryFilter(this._isQueryFilterApplied).IncludeAll(includeProperties);
            return query.FirstOrDefaultAsync(c => c.UserName.ToLower() == userName.ToLowerInvariant());
        }

        public Task<User> GetUserByEmailAsync(string email)
        {
            if (string.IsNullOrEmpty(email))
                return Task.FromResult<User>(null);
            return _userManager.Users.ApplyQueryFilter(this._isQueryFilterApplied).FirstOrDefaultAsync(c => c.Email.ToLower() == email.ToLowerInvariant());
        }

        public Task<User> GetUserByIdAsync(string userId)
        {
            return _userManager.Users.ApplyQueryFilter(this._isQueryFilterApplied).FirstOrDefaultAsync(c => c.Id == userId);
        }

        public Task<User> GetUserByIdAsync(string userId, params Expression<Func<User, object>>[] includeProperties)
        {
            var query = _userManager.Users.ApplyQueryFilter(this._isQueryFilterApplied).IncludeAll(includeProperties);
            return query.FirstOrDefaultAsync(c => c.Id == userId);
        }


        public Task<User> GetUserByIdAsync(string userId, params string[] includeProperties)
        {
            var query = _userManager.Users.ApplyQueryFilter(this._isQueryFilterApplied).IncludeAll(includeProperties);

            return query.FirstOrDefaultAsync(c => c.Id == userId);
        }

        public IQueryable<User> FindBy(Expression<Func<User, bool>> predicate)
        {
            return _userManager.Users.ApplyQueryFilter(this._isQueryFilterApplied).Where(predicate);
        }
        public IQueryable<User> FindBy(Expression<Func<User, bool>> predicate, params string[] includeProperties)
        {
            return _userManager.Users.ApplyQueryFilter(this._isQueryFilterApplied).IncludeAll(includeProperties).Where(predicate);
        }

        public IQueryable<Domain.Entities.Identity.User> FindBy(params string[] includeProperties)
        {
            return _userManager.Users.ApplyQueryFilter(this._isQueryFilterApplied).IncludeAll(includeProperties);
        }

        public IQueryable<User> FindBy(params Expression<Func<User, object>>[] includeProperties)
        {
            return _userManager.Users.ApplyQueryFilter(this._isQueryFilterApplied).IncludeAll(includeProperties);
        }

        public IQueryable<User> FindBy(Expression<Func<User, bool>> predicate, params Expression<Func<User, object>>[] includeProperties)
        {
            return _userManager.Users.ApplyQueryFilter(this._isQueryFilterApplied).IncludeAll(includeProperties).Where(predicate);
        }
        public IQueryable<User> GetAll()
        {
            return _userManager.Users.ApplyQueryFilter(this._isQueryFilterApplied);
        }
        public IQueryable<User> GetAll(params string[] includeProperties)
        {
            return _userManager.Users.ApplyQueryFilter(this._isQueryFilterApplied).IncludeAll(includeProperties);
        }
        public IQueryable<User> GetAll(params Expression<Func<User, object>>[] includeProperties)
        {
            return _userManager.Users.ApplyQueryFilter(this._isQueryFilterApplied).IncludeAll(includeProperties);
        }



        public Task<bool> IsExistAsync(Expression<Func<User, bool>> predicate)
        {
            return _userManager.Users.ApplyQueryFilter(this._isQueryFilterApplied).AnyAsync(predicate);
        }
        public Task<IdentityResult> CreateAsync(User user, string password)
        {
            return _userManager.CreateAsync(user, password);
        }
        public Task<IdentityResult> UpdateAsync(User user)
        {
            return _userManager.UpdateAsync(user);
        }
        public async Task Delete(User user)
        {

            await _userManager.DeleteAsync(user);
        }

        public Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword, string newPassword)
        {
            return _userManager.ChangePasswordAsync(user, oldPassword, newPassword);
        }

        public async Task<IdentityResult> ResetPasswordAsync(Domain.Entities.Identity.User user, string token, string newPassword)
        {
            // var user = await GetUserByIdAsync(userId, c => c.EmailConfirmationRequests);
            return await _userManager.ResetPasswordAsync(user, token, newPassword).ConfigureAwait(false);
        }
       
    }
}
