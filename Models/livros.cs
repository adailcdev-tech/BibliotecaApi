using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BibliotecaApi.Models;

public class Livro
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    
    public String? Id {get; set;}
    public String Titulo {get; set;} = string.Empty;
    public String Autor {get; set;} = string.Empty;
    public String Editora {get; set;} = string.Empty;
    public int AnoPublicacao {get; set;}
    public int Quantidade {get; set;}

}
