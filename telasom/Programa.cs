Banda queen = new Banda("Queen");


Album AlbumDoQueen = new Album("The nigth of opera");

Musica musica1 = new Musica(queen,"You Don't Know Me")
{
     Duracao = 250,
     Disponivel = true,
};


Musica musica2 = new Musica(queen, "Nine Out of Ten")
{ //Inicializadores de propriedades
    Duracao = 375,
    Disponivel = false,


};

AlbumDoQueen.AdicionarMusica(musica1);
AlbumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(AlbumDoQueen);




musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
AlbumDoQueen.ExibaMusicasDoAlbum();
queen.ExibirDiscografia();




