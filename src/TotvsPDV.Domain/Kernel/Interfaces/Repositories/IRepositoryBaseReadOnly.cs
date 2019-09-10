using System;
using System.Collections.Generic;
using TotvsPDV.Domain.Kernel.Entities;

namespace TotvsPDV.Domain.Kernel.Interfaces.Repositories
{
  public interface IRepositoryBaseReadOnly<out TEntity> where TEntity : Entity
  {
    TEntity Obter(Guid? id);
    IEnumerable<TEntity> Obter();

    IEnumerable<TEntity> GetById(Guid? id);
  }
}
