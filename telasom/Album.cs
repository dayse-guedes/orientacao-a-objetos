class Album

{ 
    private List<Musica> musicas = new List<Musica>(); //criação de uma lista de musicas para setar na classe album, inicializando a lista vazia primeiro

    public Album(string nome) //Construtor responsável por setar o nome da album
    {
        Nome = nome;
    }

    public string Nome{ get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica); //add a musica dentro da lista interna do album, relação entre album e musica
    }

    public void ExibaMusicasDoAlbum()

    {
        Console.WriteLine($"Discografia do disco {Nome}: \n");
        foreach (var musica in musicas) //percorrer array com musicas do album e então exibir no console
        {
            Console.WriteLine($"Músicas: {musica.Nome}"); //exibir nome das musicas
        }

        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal}");


    }
}