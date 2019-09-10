using System;
using System.Collections.Generic;
using TotvsPDV.Domain.Kernel.Entities;
using TotvsPDV.Domain.Kernel.Interfaces.Repositories;
using TotvsPDV.Domain.Kernel.Interfaces.Services;

namespace TotvsPDV.Domain.Kernel.Services
{
  public class ServiceBaseAllOperations<TEntity> : IServiceBaseAllOperations<TEntity> where TEntity : Entity
  {
    private readonly IRepositoryBaseAllOperations<TEntity> _repository;

    public ServiceBaseAllOperations(IRepositoryBaseAllOperations<TEntity> repository)
    {
      _repository = repository;
    }
    public virtual TEntity Obter(Guid? id)
    {
      return _repository.Obter(id);
    }

    public virtual IEnumerable<TEntity> Obter()
    {
      return _repository.Obter();
    }

    public virtual int Adicionar(TEntity entidade)
    {
      return _repository.Adicionar(entidade);
    }

    public virtual int Alterar(TEntity entidade)
    {
      return _repository.Alterar(entidade);
    }

    public virtual int Remover(Guid? id)
    {
      return _repository.Remover(id);
    }

    public IEnumerable<TEntity> GetById(Guid? id)
    {
      return _repository.GetById(id);
    }
  }
}
