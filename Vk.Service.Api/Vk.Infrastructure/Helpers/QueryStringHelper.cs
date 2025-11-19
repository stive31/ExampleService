using System.Text;
using System.Net;

namespace Vk.Infrastructure.Helpers;

internal static class QueryStringHelper
{
    public static string ToQueryString<T>(this IEnumerable<(string Name, T Value)> paramsList, bool addEmptyValues = false)
    {
        return paramsList.Aggregate(
            new StringBuilder(),
            (current, toAdd) =>
            {
                var valueString = toAdd.Value as string ?? toAdd.Value?.ToString();
                if (!addEmptyValues && string.IsNullOrWhiteSpace(valueString))
                {
                    return current;
                }

                if(current.Length == 0)
                {
                    current.Append("?");
                }
                else
                {
                    current.Append("&");
                }

                return current
                      .Append(WebUtility.UrlEncode(toAdd.Name))
                      .Append("=")
                      .Append(WebUtility.UrlEncode(valueString));
            })
            .ToString();
    }

    public static string ToQueryStringDateTime(this DateTime input)
    {
        return input.ToString("yyyy-MM-ddTHH:mm:ss");
    }

    public static string ToQueryStringDate(this DateTime input)
    {
        return input.ToString("yyyy-MM-dd");
    }
}
