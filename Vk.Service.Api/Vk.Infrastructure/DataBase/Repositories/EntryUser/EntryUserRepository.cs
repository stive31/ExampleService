using Dapper;
using Vk.Application;
using Vk.Domain.Repositories.EntryUser;

namespace Vk.Infrastructure.DataBase.Repositories.EntryUser;

public class EntryUserRepository : IEntryUserRepository
{
    private readonly IConnectionFactory _connectionFactory;

    public EntryUserRepository(IConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public void ChangeUser(EntryUserModel user)
    {
        using (var conn = _connectionFactory.GetUsers())
        {
            var sql = @"if not exists (
                           select top 1 1
                           from [dbo].[entry]
                           where token = @token)
                           begin
                               insert into [dbo].[entry](token, login, name, admin)
                               values(@token, @login, @name, @admin)
                           end
                           else
                           begin
                               update [dbo].[entry]
                           set login = @login, name = @name, admin = @admin
                           where token = @token
                           end";
            conn.Execute(sql, new
            {
                token = user.Token,
                login = user.WinLogin,
                name = user.UserName,
                admin = user.IsAdmin
            });
        }
    }

    public EntryUserModel GetUser(string token)
    {
        using(var conn = _connectionFactory.GetUsers())
        {
            var sql = @"
            select token as Token
                ,login as WinLogin
                ,name as UserName
                ,admin as IsAdmin
                from [dbo].[entry]
                where token = @token";
            return conn.QuerySingleOrDefault<EntryUserModel>(sql, new
            {
                token
            });
        }
    }
}
