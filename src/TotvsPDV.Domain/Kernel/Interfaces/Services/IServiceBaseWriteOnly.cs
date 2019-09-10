using System;
using TotvsPDV.Domain.Kernel.Entities;

namespace TotvsPDV.Domain.Kernel.Interfaces.Services
{
  public interface IServiceBaseWriteOnly<in TEntity> where TEntity : Entity
  {
    int Adicionar(TEntity entidade);
    int Alterar(TEntity entidade);
    int Remover(Guid? id);
  }
}
