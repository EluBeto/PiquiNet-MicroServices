using MongoDB.Driver;
using Services.api.library.Core.ContexMongoDB;
using Services.api.library.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.api.library.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly IAuthorContext _authorContext;
        public AuthorRepository(IAuthorContext authorContext)
        {
            _authorContext = authorContext;
        }
        public async Task<IEnumerable<Author>> GetAuthors()
        {
           return await _authorContext.Authors.Find(prop => true).ToListAsync(); 
        }
    }
}
