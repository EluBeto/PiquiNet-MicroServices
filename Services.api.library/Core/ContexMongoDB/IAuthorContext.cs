using MongoDB.Driver;
using Services.api.library.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.api.library.Core.ContexMongoDB
{
    public interface IAuthorContext
    {
        IMongoCollection<Author> Authors { get; }
    }
}
