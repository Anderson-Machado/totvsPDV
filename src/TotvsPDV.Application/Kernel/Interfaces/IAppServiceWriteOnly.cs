using System;
using TotvsPDV.Domain.Kernel.Entities;

namespace TotvsPDV.Application.Kernel.Interfaces
{
  public interface IAppServiceWriteOnly<in TEntity> where TEntity : Entity
  {
    int Adicionar(TEntity entidade);
    int Alterar(TEntity entidade);
    int Remover(Guid? id);
  }
}