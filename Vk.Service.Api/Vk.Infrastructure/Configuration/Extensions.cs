using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Vk.Infrastructure.Configuration;

public static class Extensions
{
    public static TOptions GetOptions<TOptions>(this IOptionsMonitor<TOptions> optionsAccessor, string name = null)
    {
        try
        {
            return optionsAccessor.Get(name ?? string.Empty);
        }
        catch (OptionsValidationException ex)
        {
            List<string> values = ex.Failures.Select((string x) => Regex.Replace(x, "DataAnnotation validation failed for '\\w+' members: '\\w+' with the error:", string.Empty)).ToList();

            throw new ApplicationException($"При проверку секции настроек '{name}' для типа настроек '{typeof(TOptions).Name}' обнаружены ошибки: {string.Join(", ", values)}", ex);
        }
        catch (Exception ex2)
        {
            throw new ApplicationException($"Ошибка чтения секции настроек '{name}' для типа настроек '{typeof(TOptions).Name}': {ex2.Message}", ex2);
        }
    }
}
