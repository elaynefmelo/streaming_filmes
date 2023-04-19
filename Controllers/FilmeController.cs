using Filmes.Models;
using Filmes.Services;
using Microsoft.AspNetCore.Mvc;

namespace Filmes.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase {
    public FilmeController(){

    }

    [HttpGet]
    public ActionResult<List<Filme>> GetAll() =>
    FilmeService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Filme> Get(int id)
    {
        var filme = FilmeService.Get(id);

        if(filme == null)
            return NotFound();

        return filme;
    }

    [HttpPost]
    public IActionResult Create(Filme filme)
    {            
        FilmeService.Add(filme);
        return CreatedAtAction(nameof(Get), new { id = filme.Id }, filme);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Filme filme)
    {
        if (id != filme.Id)
            return BadRequest();
            
        var existingFilme = FilmeService.Get(id);
        if(existingFilme is null)
            return NotFound();
    
        FilmeService.Update(filme);           
    
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var filme = FilmeService.Get(id);
    
        if (filme is null)
            return NotFound();
        
        FilmeService.Delete(id);
    
        return NoContent();
    }
}
