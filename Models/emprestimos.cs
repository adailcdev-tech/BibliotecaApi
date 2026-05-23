using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BibliotecaApi.Models;

public class Emprestimo
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonRepresentation(BsonType.ObjectId)]
    public string LivroId { get; set; } = string.Empty;

    public string NomeUsuario { get; set; } = string.Empty;
    public DateTime DataEmprestimo { get; set; }
    public DateTime? DataDevolucao { get; set; }
    public string Status { get; set; } = "ativo"; // "ativo" ou "devolvido"
}