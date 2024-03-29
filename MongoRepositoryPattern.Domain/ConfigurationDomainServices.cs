﻿using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using MongoRepositoryPattern.Domain.Context;
using MongoRepositoryPattern.Domain.Repository;
using MongoRepositoryPattern.Domain.Repository.Interfaces;

namespace MongoRepositoryPattern.Domain
{
    public static class ConfigurationDomainServices
    {
        public static void AddRepository(this IServiceCollection services)
        {
            // don't work if genericrepo abstract
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<IAuthorRepository, AuthorRepository>();

        }

        [Obsolete("Use MongoDataBase services")]
        public static void AddMongoDbContext(this IServiceCollection service)
        {
            service.AddSingleton<IMongoDbContext, MongoDbContext>();
        }
        [Obsolete("Still don't support in progress")]
        static public void AddKeyedMongoDataBase(this IServiceCollection services)
        {
            //register mongoclient
            services.AddSingleton<IMongoClient>(cfg=>{
                return new MongoClient();
            });

            //register keyed MongoDatabase to get concrete database
            services.AddKeyedSingleton("def", (provider,obj) =>
            {
               var client=provider.GetService<MongoClient>() ?? throw new NullReferenceException("client is null"); 
                return client.GetDatabase("default");
            });

            services.AddKeyedSingleton("def1", (provider,_) =>
            {
                var client = provider.GetService<MongoClient>() ?? throw new NullReferenceException("client is null");
                return client.GetDatabase("default1");
            });
        }

        
        static public void AddMongoDataBase(this IServiceCollection service)
        {
            service.AddSingleton(cfg =>
            {
                var client = new MongoClient();
                return client.GetDatabase("TestRepo");

            });
        }
    }
}
