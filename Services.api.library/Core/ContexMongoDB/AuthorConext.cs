using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Services.api.library.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.api.library.Core.ContexMongoDB
{
    public class AuthorConext : IAutorContexto
    {
        private readonly IMongoDatabase _db;
        public AuthorConext(IOptions<MongoSettings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);
        }
        public IMongoCollection<Author> Autores => _db.GetCollection<Author>("Author");
    }
}
