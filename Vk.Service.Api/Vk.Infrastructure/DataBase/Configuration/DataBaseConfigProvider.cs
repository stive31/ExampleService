using Microsoft.Extensions.Configuration;
using Vk.Infrastructure.Common.Configuration;

namespace Vk.Infrastructure.DataBase.Configuration;

public class DataBaseConfigProvider : ConfigProvider, IDataBaseConfigurationProvider
{
    public DataBaseConfigProvider(IConfiguration config)
        :base(config)
    {
    }
    public string GetConnectionKK()
    {
        throw new NotImplementedException();
    }

    public string GetConnectionLM()
    {
        throw new NotImplementedException();
    }

    public string GetConnectionUser()
    {
        throw new NotImplementedException();
    }
}
