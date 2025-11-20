using Microsoft.Extensions.Configuration;

namespace Vk.Infrastructure.Common.Configuration;

public class ConfigProvider : IConfigProvider
{
    private IConfiguration _config;

    public ConfigProvider(IConfiguration config)
    {
        _config = config;
    }

    public T Get<T>(string section, string notFoundDescription = null) where T : class, new()
    {
        return ((IConfiguration)GetConfigurationSection(section, notFoundDescription)).Get<T>();
    }

    public string GetAppSettingsValue(string name, string notFoundDescription = null)
    {
        return GetConfigurationValue("AppSettings", name, notFoundDescription);
    }

    public string GetSectionValue(string section, string name, string notFoundDescription = null)
    {
        return GetConfigurationValue(section, name, notFoundDescription);
    }

    protected string GetUncheckedValue(string section, string key) => _config.GetSection(section)?[key];

    private IConfigurationSection GetConfigurationSection(string section, string notFoundDescription = null)
    {
        if(section == null)
        {
            throw new ArgumentException(nameof(section));
        }

        var result = _config.GetSection(section);

        if(result == null)
        {
            string message = $"В конфигурации отсутствует секция {section}";
            throw new ArgumentException(string.IsNullOrEmpty(notFoundDescription) ? message : notFoundDescription);
        }

        return result;
    }

    private string GetConfigurationValue(string section, string name, string notFoundDescription = null)
    {
        if (section == null)
        {
            throw new ArgumentException(nameof(section));
        }

        if (name == null)
        {
            throw new ArgumentException(nameof(name));
        }

        var result = GetConfigurationSection(section, notFoundDescription)?[name];
        if (result == null)
        {
            string message = $"В конфигурации отсутствует настройка {section}.{name}";
            throw new ArgumentException(string.IsNullOrEmpty(notFoundDescription) ? message : notFoundDescription);
        }

        return result;

    }
}
