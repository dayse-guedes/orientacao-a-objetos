 class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    private bool disponivel;

    public void EscreveDisponivel(bool value)
    {
        disponivel = value;
    }

    //Preciso proteger o atributo disponivel, preciso criar dois medotos portanto, um para leitura do disponivel e outro para escrita.
    //Para tanto a função de escrever recebe um bool, um argumento, um valor de disponivel e no entanto essa escrita é privada, logo não pode ser alterada facilmente
    //Em contrapartidada, a leitura é publica e retorna o disponivel no console.
    public bool LeDisponivel()
    {
        return disponivel;
    }
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}"); 
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if(disponivel)
        {
            Console.WriteLine("Disponível no plano");
        } else 
        {
            Console.WriteLine("Adiquira o plano Plus+");
        }

            
    }
}
