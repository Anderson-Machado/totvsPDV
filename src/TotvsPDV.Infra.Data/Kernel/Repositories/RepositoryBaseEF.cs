using Microsoft.EntityFrameworkCore;
using System;
using TotvsPDV.Domain.Kernel.Entities;
using TotvsPDV.Domain.Kernel.Interfaces.Repositories;

namespace TotvsPDV.Infra.Data.Kernel.Repositories
{
  public abstract class RepositoryBaseEF<TEntity> : IRepositoryBaseWriteOnly<TEntity> where TEntity : Entity
  {
    protected readonly DbContext _dbContext;
    protected readonly DbSet<TEntity> _dbSet;

    public RepositoryBaseEF(DbContext dbContext)
    {
      _dbContext = dbContext;
      _dbSet = _dbContext.Set<TEntity>();
    }

    public virtual int Adicionar(TEntity entidade)
    {
      _dbSet.Add(entidade);
      return Commit();
    }

    public virtual int Alterar(TEntity entidade)
    {
      _dbContext.Entry(entidade).State = EntityState.Modified;
      return Commit();
    }

    public virtual int Remover(Guid? id)
    {
      _dbSet.Remove(_dbSet.Find(id));
      return Commit();
    }

    private int Commit()
    {
      return _dbContext.SaveChanges();
    }

    public void Dispose()
    {
      _dbContext.Dispose();
      GC.SuppressFinalize(this);
    }
  }
}
