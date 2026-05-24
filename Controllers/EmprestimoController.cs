using BibliotecaApi.Models;
using BibliotecaApi.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;


namespace BibliotecaApi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class livrosController : ControllerBase
{
    private readonly ILivroService _service;
    public livrosController (ILivroService service)
    {
        _service = service;
    }
     [HttpGet]
     public async Task <IActionResult> GetAll()
    {
        var livros= await _service.GetAllAsync();
        return Ok (livros);

    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var livro = await _service.GetByIdAsync(id);
        if (livro is null) return NotFound();
        return Ok(livro);

    }
          [HttpPost]
    public async Task<IActionResult> Create([FromBody] Livro livro)
    {
        await _service.CreateAsync(livro);
        return CreatedAtAction(nameof(GetById), new { id = livro.Id }, livro);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(string id, [FromBody] Livro livro)
    {
        var existingLivro = await _service.GetByIdAsync(id);
        if (existingLivro is null) return NotFound();
        livro.Id = id;
        await _service.UpdateAsync(id, livro);
        return NoContent();
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        var existingLivro = await _service.GetByIdAsync(id);
        if (existingLivro is null) return NotFound();
        await _service.DeleteAsync(id);
        return NoContent();
    }
}
