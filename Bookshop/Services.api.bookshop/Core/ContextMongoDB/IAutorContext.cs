using MongoDB.Driver;
using Services.api.bookshop.Core.Entities;

namespace Services.api.bookshop.Core.ContextMongoDB
{
    public interface IAutorContext
    {
        IMongoCollection<Autor> Autores { get; }
    }
}
