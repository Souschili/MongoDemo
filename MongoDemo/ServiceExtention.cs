using MongoDB.Driver;

namespace MongoDemo
{
    public static class ServiceExtention
    {
        public static IServiceCollection AddMongoDb(this IServiceCollection services)
        {
            services.AddSingleton<IMongoDatabase>(opt =>
            {
                var client = new MongoClient(); // local by deafult
                return client.GetDatabase("LocalMongoDB");
            });

            return services;     
        }
    }
}
