using TotvsPDV.Domain.Kernel.Entities;

namespace TotvsPDV.Domain.Kernel.Interfaces.Repositories
{
  public interface IRepositoryBaseAllOperations<TEntity> :
        IRepositoryBaseWriteOnly<TEntity>,
        IRepositoryBaseReadOnly<TEntity> where TEntity : Entity
  {
  }
}
