class Banda
{
    private List<Album> albums = new List<Album>();

    public Banda(string nome) //Construtor responsável por setar o nome da banda 
    {
        Nome = nome;
    }

    public string Nome { get; } //No charp quando temos apenas get(leitura) precisa necessarimente de um construtor para cumprir o set ou passar outro valor já no parenteses após o get

    public void AdicionarAlbum(Album album) 
    { 
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");

        foreach (Album album in albums)
        {
            Console.WriteLine($"Album: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}