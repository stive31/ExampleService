using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Data;
using Vk.Infrastructure.Configuration;
using Vk.Infrastructure.Configuration.Options;
using Vk.Infrastructure.DataBase.Configuration;

namespace Vk.Infrastructure.DataBase;

public class ConnectionFactory : IConnectionFactory
{
    private IDataBaseConfigurationProvider _config;

    public ConnectionFactory(IDataBaseConfigurationProvider configProvider)
    {
        _config = configProvider;
    }
     
    public IDbConnection GetLM()
    {
        return new SqlConnection(_config.GetConnectionLM());
    }

    public IDbConnection GetKK()
    {
        return new SqlConnection(_config.GetConnectionKK());
    }

    public IDbConnection GetUsers()
    {
        return new SqlConnection(_config.GetConnectionUser());
    }
}
