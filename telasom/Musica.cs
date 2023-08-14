 class Musica
{
    public string nome;
    public string artista;
    public int duracao;
 public bool Disponivel { get; set; } //get leitura, set escrita

    
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}"); 
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if(Disponivel)
        {
            Console.WriteLine("Disponível no plano");
        } else 
        {
            Console.WriteLine("Adiquira o plano Plus+");
        }

            
    }
}
