using TotvsPDV.Domain.Kernel.Entities;

namespace TotvsPDV.Domain.Kernel.Interfaces.Services
{
  public interface IServiceBaseAllOperations<TEntity> :
        IServiceBaseWriteOnly<TEntity>,
        IServiceBaseReadOnly<TEntity> where TEntity : Entity
  {
  }
}
