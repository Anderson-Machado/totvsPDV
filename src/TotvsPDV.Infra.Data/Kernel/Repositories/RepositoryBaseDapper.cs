using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using TotvsPDV.Infra.Data.Kernel.DBConfiguration;
using TotvsPDV.Infra.Data.Kernel.Interfaces;

namespace TotvsPDV.Infra.Data.Kernel.Repositories
{
  public class RepositoryBaseDapper : IRepositoryBaseDapper
  {
    private DbConnection _connection;

    public IDbConnection GetConnection() => _connection;

    protected internal DbConnection Connection => _connection ?? (_connection = new SqlConnection(
        DatabaseConnection.ConnectionConfiguration.GetConnectionString("DbConnection")));

    public int Execute(string query, object param = null, IDbTransaction transaction = null)
    {
      using (var cn = Connection)
      {
        if (cn.State != ConnectionState.Open) { cn.Open(); }

        return cn.Execute(query, param: param, transaction: transaction);
      }
    }

    public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TReturn>(string query, Func<TFirst, TSecond, TThird, TReturn> map, object param = null, string splitOn = "Id", IDbTransaction transaction = null)
    {
      using (var cn = Connection)
      {
        return cn.Query<TFirst, TSecond, TThird, TReturn>(query, map, param: param, splitOn: splitOn, transaction: transaction);
      }
    }

    public IEnumerable<TReturn> Query<TFirst, TSecond, TReturn>(string query, Func<TFirst, TSecond, TReturn> map, object param = null, string splitOn = "Id", IDbTransaction transaction = null)
    {
      using (var cn = Connection)
      {
        return cn.Query<TFirst, TSecond, TReturn>(query, map, param: param, splitOn: splitOn, transaction: transaction);
      }
    }

    public IEnumerable<TResult> Query<TResult>(string query, object param = null, IDbTransaction transaction = null)
    {
      using (var cn = Connection)
      {
        return cn.Query<TResult>(query, param: param, transaction: transaction);
      }
    }

    public TResult QueryFirstOrDefault<TResult>(string query, object param = null, IDbTransaction transaction = null)
    {
      using (var cn = Connection)
      {
        return cn.QueryFirstOrDefault<TResult>(query, param: param, transaction: transaction);
      }
    }
  }
}
