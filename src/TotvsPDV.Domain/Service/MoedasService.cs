using TotvsPDV.Domain.Entities;
using TotvsPDV.Domain.Interfaces.Repositories;
using TotvsPDV.Domain.Interfaces.Services;
using TotvsPDV.Domain.Kernel.Services;

namespace TotvsPDV.Domain.Service
{
  public class MoedasService : ServiceBaseAllOperations<Moedas>, IMoedasService
  {
    private readonly IMoedasRepository _repositoryLocal;
    public MoedasService(IMoedasRepository repository, IMoedasRepository repositoryLocal) : base(repository)
    {
      _repositoryLocal = repositoryLocal;

    }
  }
}
