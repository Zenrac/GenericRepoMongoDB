using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMongo.Context;
using TestMongo.Models;

namespace TestMongo.Repositories
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {

        public BookRepository(IMongoDBContext context) : base(context)
        {
        }
    }
}
