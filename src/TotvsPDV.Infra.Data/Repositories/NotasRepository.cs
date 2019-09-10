using System;
using System.Collections.Generic;
using TotvsPDV.Domain.Entities;
using TotvsPDV.Domain.Interfaces.Repositories;
using TotvsPDV.Infra.Data.Context;
using TotvsPDV.Infra.Data.Kernel.Interfaces;
using TotvsPDV.Infra.Data.Kernel.Repositories;

namespace TotvsPDV.Infra.Data.Repositories
{
  public class NotasRepository : RepositoryBaseEF<Notas>, INotasRepository
  {
    private readonly IRepositoryBaseDapper _repositoryBaseDapper;

    public NotasRepository(TotvsDbContext dbContext,
            IRepositoryBaseDapper repositoryBaseDapper) : base(dbContext)
    {
      _repositoryBaseDapper = repositoryBaseDapper;
    }

    public IEnumerable<Notas> GetById(Guid? id)
    {
      throw new NotImplementedException();
    }

    public Notas Obter(Guid? id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Notas> Obter()
    {
      var query = @"SELECT * FROM Moedas ORDER BY Id";

      return _repositoryBaseDapper.Query<Notas>(query);

    }
  }
}
