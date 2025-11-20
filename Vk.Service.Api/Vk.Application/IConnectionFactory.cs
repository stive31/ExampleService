using System.Data;

namespace Vk.Application;

/// <summary>
///  Фабрика соединений
/// </summary>
public interface IConnectionFactory
{
    /// <summary>
    /// Возвращает соединение с бд LM
    /// </summary>
    /// <returns>Соединение с БД LM</returns>
    IDbConnection GetLM();

    IDbConnection GetKK();

    IDbConnection GetUsers();
}