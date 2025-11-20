using Vk.Domain.Dictionary.Models;
using Vk.Domain.User.Models;
using Vk.Domain.User.Models.Models;

namespace Vk.Application
{
    public interface IUserApplication
    {
        Task<UserModel> GetAsync(string winLogin);

        Task<UserModel> SuncAsync(string winLogin);

        Task<IEnumerable<DomainDrTypeItemFull>> GetRolesAsync(string winLogin);
        Task<IEnumerable<UserModel>> ImportAsync(IEnumerable<string> winLogins);
        Task<IEnumerable<UserCredentials>> SearchUserAsync(string filter);
    }
}
