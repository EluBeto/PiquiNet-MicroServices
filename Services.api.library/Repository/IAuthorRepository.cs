using Services.api.library.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.api.library.Repository
{
    public interface IAuthorRepository
    {
        Task<IEnumerable<Author>> GetAuthors();
    }
}
