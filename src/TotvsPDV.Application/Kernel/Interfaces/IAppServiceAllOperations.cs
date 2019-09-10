using TotvsPDV.Domain.Kernel.Entities;

namespace TotvsPDV.Application.Kernel.Interfaces
{
  public interface IAppServiceAllOperations<TEntity> :
        IAppServiceWriteOnly<TEntity>,
        IAppServiceReadOnly<TEntity> where TEntity : Entity
  {
  }
}