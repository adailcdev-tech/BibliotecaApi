using BibliotecaApi.Models;
using MongoDB.Driver;

namespace BibliotecaApi.Repositories;

public class EmprestimoRepository : IEmprestimoRepositorios
{
    private readonly IMongoCollection<Emprestimo> _collection;

    public EmprestimoRepository(IMongoClient client, IConfiguration config)
    {
        var database = client.GetDatabase(config["MongoDBSettings:DatabaseName"]);
        _collection = database.GetCollection<Emprestimo>("emprestimos");
    }

    public async Task<List<Emprestimo>> GetAllAsync() =>
        await _collection.Find(_ => true).ToListAsync();

    public async Task<Emprestimo?> GetByIdAsync(string id) =>
        await _collection.Find(e => e.Id == id).FirstOrDefaultAsync();

    public async Task CreateAsync(Emprestimo emprestimo) =>
        await _collection.InsertOneAsync(emprestimo);

    public async Task UpdateAsync(string id, Emprestimo emprestimo) =>
        await _collection.ReplaceOneAsync(e => e.Id == id, emprestimo);

    public async Task DeleteAsync(string id) =>
        await _collection.DeleteOneAsync(e => e.Id == id);
}