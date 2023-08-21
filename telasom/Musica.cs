 class Musica

{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }



    public string Nome { get;  } 
    public Banda Artista { get; }
    public int Duracao { get; set; }
 public bool Disponivel { get; set; } //get leitura, set escrita

    public string DescricaoResumida => 
       $"A música {Nome} pertence a banda {Artista}";
    
    //prob atalho para criar uma propriedade


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}"); 
        Console.WriteLine($"Artista: {Artista.Nome}");
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
