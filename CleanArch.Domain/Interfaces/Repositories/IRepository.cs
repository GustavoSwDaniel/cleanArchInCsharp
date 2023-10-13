using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Domain.Interfaces.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
            
        void Add(TEntity entity);
    }
}