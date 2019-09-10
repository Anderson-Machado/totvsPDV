using System;
using System.Collections.Generic;
using TotvsPDV.Domain.Entities;
using TotvsPDV.Domain.Interfaces.Repositories;
using TotvsPDV.Infra.Data.Context;
using TotvsPDV.Infra.Data.Kernel.Interfaces;
using TotvsPDV.Infra.Data.Kernel.Repositories;

namespace TotvsPDV.Infra.Data.Repositories
{
  public class MoedasRepository : RepositoryBaseEF<Moedas>, IMoedasRepository
  {
    private readonly IRepositoryBaseDapper _repositoryBaseDapper;


    public MoedasRepository(TotvsDbContext dbContext,
            IRepositoryBaseDapper repositoryBaseDapper) : base(dbContext)
    {
      _repositoryBaseDapper = repositoryBaseDapper;
    }

    public IEnumerable<Moedas> GetById(Guid? id)
    {
      throw new NotImplementedException();
    }

    public Moedas Obter(Guid? id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Moedas> Obter()
    {
      var query = @"SELECT * FROM Moedas ORDER BY Id";

      return _repositoryBaseDapper.Query<Moedas>(query);
    }
  }
}
