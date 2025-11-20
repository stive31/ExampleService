using System.Data;
using Vk.Domain.User.Models;

namespace Vk.Domain.User;

public interface IUserRepository
{
    /// <summary>
    /// Возвращает пользователя по winlogin
    /// </summary>
    /// <param name="winLogin">winLogin пользователя</param>
    /// <param name="conn"></param>
    /// <param name="tran"></param>
    /// <returns></returns>
    Task<UserModel> GetUserAsync(string winLogin, IDbConnection conn, IDbTransaction tran);
}
