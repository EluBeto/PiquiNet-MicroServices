using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.api.library.Core.Entities;
using Services.api.library.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.api.library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibreriaServicioController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;

        public LibreriaServicioController(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        [HttpGet("authors")]
        public async Task<ActionResult<IEnumerable<Author>>> GetAuthores()
        {
            var authors = await _authorRepository.GetAuthors();
            return Ok(authors);
        }
    }
}
