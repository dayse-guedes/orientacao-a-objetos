class Podcast
{
    private List<Epsodio> epsodios = new();
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get;  }
    public string Host { get;  }

    public int TotalEpsodios => epsodios.Count;

    public void AdicionarEpsodio(Epsodio episodio)
    {
        epsodios.Add(episodio);
    }

    public void ExibirDetalhesDoPodcast()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Host}         \n");
        foreach (Epsodio epsodio in epsodios.OrderBy(e => e.Ordem)
        {
            Console.WriteLine(epsodio.Resumo);
        }

        Console.WriteLine($" \n\n Este podcast possui {TotalEpsodios} epsodios");
    }
}