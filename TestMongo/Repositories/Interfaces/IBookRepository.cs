using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMongo.Models;

namespace TestMongo.Repositories
{
    public interface IBookRepository : IBaseRepository<Book>
    {
    }
}
