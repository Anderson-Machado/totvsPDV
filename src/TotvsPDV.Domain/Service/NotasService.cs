using TotvsPDV.Domain.Entities;
using TotvsPDV.Domain.Interfaces.Repositories;
using TotvsPDV.Domain.Interfaces.Services;
using TotvsPDV.Domain.Kernel.Services;

namespace TotvsPDV.Domain.Service
{
  public class NotasService : ServiceBaseAllOperations<Notas>, INotasService
  {
    private readonly INotasRepository _repositoryLocal;

    public NotasService(INotasRepository repository, INotasRepository repositoryLocal) : base(repository)
    {
      _repositoryLocal = repositoryLocal;

    }

  }
}
