using Filmes.Models;
namespace Filmes.Services;

public class FilmeService
{ 
    static List<Filme> Filmes { get; }
    static int nextId = 3;

    static FilmeService()
    {
        Filmes = new List<Filme>
        {
            new Filme 
            {
              Id = 1,
              Nome = "Super Mario",
              Genero = "Animação",
              EhLancamento = true

            },

            new Filme 
            {
              Id = 2,
              Nome = "Barbie",
              Genero = "Drama",
              EhLancamento = true

            }
            
        };
    }
    
}

