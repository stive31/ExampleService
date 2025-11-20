namespace Vk.Infrastructure.DataBase.Configuration;

public interface IDataBaseConfigurationProvider
{
    /// <summary>
    /// Возвращает строку соединения с КК.
    /// </summary>
    /// <returns></returns>
    string GetConnectionKK();

    /// <summary>
    /// Возвращает строку соединения с LM.
    /// </summary>
    /// <returns></returns>
    string GetConnectionLM();
    string GetConnectionUser();

}
