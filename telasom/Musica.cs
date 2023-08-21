 class Musica

{   public Musica( Banda artista)
    {
        Artista = artista;
    }
    public string Nome { get; set; } 
    public Banda Artista { get; }
    public int Duracao { get; set; }
 public bool Disponivel { get; set; } //get leitura, set escrita

    public string DescricaoResumida => 
       $"A música {Nome} pertence a banda {Artista}";
    
    //prob atalho para criar uma propriedade


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}"); 
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if(Disponivel)
        {
            Console.WriteLine("Disponível no plano");
        } else 
        {
            Console.WriteLine("Adiquira o plano Plus+");
        }

            
    }
}
