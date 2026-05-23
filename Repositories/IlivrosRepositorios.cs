using BibliotecaApi.Models;

namespace BibliotecaApi.Repositories;

public interface ILivroRepositorios
{
    Task<List<Livro>> GetAllAsync();
    Task<Livro?> GetByIdAsync(string id);
    Task CreateAsync(Livro livro);
    Task UpdateAsync(string id, Livro livro);
    Task DeleteAsync(string id);
}