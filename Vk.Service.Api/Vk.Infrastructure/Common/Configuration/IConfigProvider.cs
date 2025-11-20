namespace Vk.Infrastructure.Common.Configuration;

public interface IConfigProvider
{
    /// <summary>
    /// Возвращает значение из секции AppSettings конфигурации.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="notFoundDescription"></param>
    /// <returns>Значение из конфигураци</returns>
    string GetAppSettingsValue(string name, string notFoundDescription = null);

    /// <summary>
    /// Возвращает значение из заданной секции конфигурации.
    /// </summary>
    /// <param name="section">Секция</param>
    /// <param name="name">Наименование значения</param>
    /// <param name="notFoundDescription">Опциональный текст сообщения об ошибки, если секция не найдена в конфигурации.</param>
    /// <returns>Значение из конфигураци</returns>
    string GetSectionValue(string section, string name, string notFoundDescription = null);

    /// <summary>
    /// Возвращает экземпляр типа <typeparamref name="T"/> из заданной секции конфигурации.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="section">Секция</param>
    /// <param name="notFoundDescription">Опциональный текст сообщения об ошибки, если секция не найдена в конфигурации.</param>
    /// <returns>Экземпляр типа <typeparamref name="T"/></returns>
    T Get<T>(string section, string notFoundDescription = null)
        where T : class, new();

}
