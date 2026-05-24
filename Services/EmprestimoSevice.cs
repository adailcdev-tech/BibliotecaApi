using BibliotecaApi.Models;
using BibliotecaApi.Repositories;

namespace BibliotecaApi.Services;

public class EmprestimoService : IEmprestimoService
{
    private readonly IEmprestimoRepositorios _repository;

    public EmprestimoService(IEmprestimoRepositorios repository)
    {
        _repository = repository;
    }

    public async Task<List<Emprestimo>> GetAllAsync() =>
        await _repository.GetAllAsync();

    public async Task<Emprestimo?> GetByIdAsync(string id) =>
        await _repository.GetByIdAsync(id);

    public async Task CreateAsync(Emprestimo emprestimo) =>
        await _repository.CreateAsync(emprestimo);

    public async Task UpdateAsync(string id, Emprestimo emprestimo) =>
        await _repository.UpdateAsync(id, emprestimo);

    public async Task DeleteAsync(string id) =>
        await _repository.DeleteAsync(id);
}