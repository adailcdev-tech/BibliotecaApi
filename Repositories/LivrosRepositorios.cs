using BibliotecaApi.Models;
using MongoDB.Driver;

namespace BibliotecaApi.Repositories;

public class LivroRepository : ILivroRepositorios
{
    private readonly IMongoCollection<Livro> _collection;

    public LivroRepository(IMongoClient client, IConfiguration config)
    {
        var database = client.GetDatabase(config["MongoDBSettings:DatabaseName"]);
        _collection = database.GetCollection<Livro>("livros");
    }

    public async Task<List<Livro>> GetAllAsync() =>
        await _collection.Find(_ => true).ToListAsync();

    public async Task<Livro?> GetByIdAsync(string id) =>
        await _collection.Find(l => l.Id == id).FirstOrDefaultAsync();

    public async Task CreateAsync(Livro livro) =>
        await _collection.InsertOneAsync(livro);

    public async Task UpdateAsync(string id, Livro livro) =>
        await _collection.ReplaceOneAsync(l => l.Id == id, livro);

    public async Task DeleteAsync(string id) =>
        await _collection.DeleteOneAsync(l => l.Id == id);
}