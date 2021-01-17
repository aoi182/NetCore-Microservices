using Microsoft.AspNetCore.Mvc;
using Services.api.bookshop.Core.Entities;
using Services.api.bookshop.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.api.bookshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IAutorRepository _autorRepository;

        public BookController(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Autor>>> Get()
        {
            return Ok(await _autorRepository.GetAutores());
        }
    }
}
