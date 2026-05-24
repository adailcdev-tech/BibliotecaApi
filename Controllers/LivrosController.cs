using BibliotecaApi.Models;
using BibliotecaApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmprestimosController : ControllerBase
{
    private readonly IEmprestimoService _service;

    public EmprestimosController(IEmprestimoService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var emprestimos = await _service.GetAllAsync();
        return Ok(emprestimos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var emprestimo = await _service.GetByIdAsync(id);
        if (emprestimo is null) return NotFound();
        return Ok(emprestimo);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Emprestimo emprestimo)
    {
        await _service.CreateAsync(emprestimo);
        return CreatedAtAction(nameof(GetById), new { id = emprestimo.Id }, emprestimo);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(string id, [FromBody] Emprestimo emprestimo)
    {
        var existing = await _service.GetByIdAsync(id);
        if (existing is null) return NotFound();
        await _service.UpdateAsync(id, emprestimo);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        var existing = await _service.GetByIdAsync(id);
        if (existing is null) return NotFound();
        await _service.DeleteAsync(id);
        return NoContent();
    }
}