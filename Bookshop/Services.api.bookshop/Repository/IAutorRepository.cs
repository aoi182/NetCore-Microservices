using Services.api.bookshop.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.api.bookshop.Repository
{
    public interface IAutorRepository
    {
        Task<IEnumerable<Autor>> GetAutores();
    }
}
