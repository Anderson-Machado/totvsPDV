
using System;
using System.Collections.Generic;
using TotvsPDV.Domain.Kernel.Entities;

namespace TotvsPDV.Application.Kernel.Interfaces
{
  public interface IAppServiceReadOnly<out TEntity> where TEntity : Entity
  {
    TEntity Obter(Guid? id);
    IEnumerable<TEntity> Obter();

    IEnumerable<TEntity> GetById(Guid? id);


  }
}