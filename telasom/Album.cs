class Album

{ 
    private List<Musica> musicas = new List<Musica>(); //criação de uma lista de musicas para setar na classe album, inicializando a lista vazia primeiro
    public string Nome{ get; set; }
    public int DuracaoTotal{ get; set; }

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
        
         
        
    }
}