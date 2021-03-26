using MongoDB.Driver;

namespace TestMongo.Context
{
    public interface IMongoDBContext
    {
        IMongoCollection<T> GetCollection<T>(string name);
    }
}
