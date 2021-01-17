using MongoDB.Driver;
using Services.api.bookshop.Core.ContextMongoDB;
using Services.api.bookshop.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.api.bookshop.Repository
{
    public class AutorRepository : IAutorRepository
    {
        private readonly IAutorContext _autorContext;

        public AutorRepository(IAutorContext autorContext)
        {
            _autorContext = autorContext;
        }

        public async Task<IEnumerable<Autor>> GetAutores()
        {
            return await _autorContext.Autores.Find(q => true).ToListAsync();
        }
    }
}
