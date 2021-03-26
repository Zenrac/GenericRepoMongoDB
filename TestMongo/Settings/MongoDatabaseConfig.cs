namespace TestMongo
{
    public class MongoDatabaseConfig : IMongoDatabaseConfig
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
