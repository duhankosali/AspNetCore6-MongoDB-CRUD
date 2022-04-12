using NetCore_MongoDB_CRUDOperation.Models;

namespace NetCore_MongoDB_CRUDOperation.Settings
{
    public class MongoDbConfig
    {
        // Repositoryler için
        public static string Connection = "mongodb://localhost:27017/?readPreference=primary&directConnection=true&ssl=false";
        public static string DbName = "GithubTest";
        public static string collection = "Test";
    }
}
