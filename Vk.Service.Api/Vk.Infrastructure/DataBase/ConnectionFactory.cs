using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Data;
using Vk.Infrastructure.Configuration;
using Vk.Infrastructure.Configuration.Options;

namespace Vk.Infrastructure.DataBase;

public class ConnectionFactory : IConnectionFactory
{
    private readonly ConnectionStringsOptions _options;

    public ConnectionFactory(IOptionsMonitor<ConnectionStringsOptions> options)
    {
        _options = options.GetOptions();
    }
     
    public IDbConnection GetLM()
    {
        return new SqlConnection(_options.LM);
    }

    public IDbConnection GeKK()
    {
        return new SqlConnection(_options.KK);
    }

    public IDbConnection GetEntry()
    {
        return new SqlConnection(_options.EntryConnectionString);
    }
}
