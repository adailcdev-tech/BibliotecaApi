using BibliotecaApi.Models;
using BibliotecaApi.Repositories;

namespace BibliotecaApi.Services;

public class LivroService : ILivroService
{
    private readonly ILivroRepositorios _repository;

    public LivroService(ILivroRepositorios repository)
    {
        _repository = repository;
    }

    public async Task<List<Livro>> GetAllAsync() =>
        await _repository.GetAllAsync();

    public async Task<Livro?> GetByIdAsync(string id) =>
        await _repository.GetByIdAsync(id);

    public async Task CreateAsync(Livro livro) =>
        await _repository.CreateAsync(livro);

    public async Task UpdateAsync(string id, Livro livro) =>
        await _repository.UpdateAsync(id, livro);

    public async Task DeleteAsync(string id) =>
        await _repository.DeleteAsync(id);
}