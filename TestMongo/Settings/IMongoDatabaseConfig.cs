namespace TestMongo
{
    public interface IMongoDatabaseConfig
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
