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

    //Métodos Publicos

    public static List<Filme> GetAll() => Filmes;


    public static Filme? Get(int id) => Filmes.FirstOrDefault(f => f.Id == id);
    
    public static void Add(Filme filme){
      filme.Id = nextId++;
      Filmes.Add(filme);
    }

    public static void Delete(int id){
      var filme = Get(id);
      if(filme is null)
        return;

      Filmes.Remove(filme);
    }

    public static void Update(Filme filme){
      
      var index = Filmes.FindIndex(f => f.Id == filme.Id);
      if(index == -1)
        return;

      Filmes[index] = filme;

    }
}

