using BibliotecaApi.Models;

namespace BibliotecaApi.Repositories;

public interface IEmprestimoRepositorios{
    Task<List<Emprestimo>> GetAllAsync();
    Task<Emprestimo?> GetByIdAsync(string id);
    Task CreateAsync(Emprestimo emprestimo);
    Task UpdateAsync(string id, Emprestimo emprestimo);
    Task DeleteAsync(string id);
}