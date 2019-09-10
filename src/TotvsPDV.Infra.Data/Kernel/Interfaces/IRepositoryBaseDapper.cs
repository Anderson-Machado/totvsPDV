using System;
using System.Collections.Generic;
using System.Data;

namespace TotvsPDV.Infra.Data.Kernel.Interfaces
{
    public interface IRepositoryBaseDapper
    {
        IDbConnection GetConnection();

        int Execute(string sql, object param = null, IDbTransaction transaction = null);

        IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TReturn>(string query, Func<TFirst, TSecond, TThird, TReturn> map, object param = null, string splitOn = "Id", IDbTransaction transaction = null);

        IEnumerable<TReturn> Query<TFirst, TSecond, TReturn>(string query, Func<TFirst, TSecond, TReturn> map, object param = null, string splitOn = "Id", IDbTransaction transaction = null);

        IEnumerable<TResult> Query<TResult>(string query, object param = null, IDbTransaction transaction = null);

        TResult QueryFirstOrDefault<TResult>(string query, object param = null, IDbTransaction transaction = null);
    }
}
