using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Services.api.bookshop.Core.Entities
{
    public class Autor
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; }

        [BsonElement("apellidos")]
        public string Apellidos { get; set; }

        [BsonElement("titulo")]
        public string Titulo { get; set; }
    }
}
