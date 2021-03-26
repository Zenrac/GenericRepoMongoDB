using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMongo.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task Create(TEntity obj);
        Task Update(string id, TEntity obj);
        Task Delete(string id);
        Task<TEntity> Get(string id);
        Task<IEnumerable<TEntity>> GetAll();
    }
}
