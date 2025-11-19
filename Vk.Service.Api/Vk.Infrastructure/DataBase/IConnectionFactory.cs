using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vk.Infrastructure.DataBase;

/// <summary>
///  Фабрика соединений
/// </summary>
public interface IConnectionFactory
{
    /// <summary>
    /// Возвращает соединение с бд LM
    /// </summary>
    /// <returns>Соединение с БД LM</returns>
    public IDbConnection GetLM();

    public IDbConnection GeKK();

    public IDbConnection GetEntry();
}
