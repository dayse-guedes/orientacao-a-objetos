Banda queen = new Banda();
queen.Nome = "Queen";

Album AlbumDoQueen = new Album();
AlbumDoQueen.Nome = "The nigth of opera";

Musica musica1 = new Musica(queen);
musica1.Nome = "You Don't Know Me";
musica1.Duracao = 250;



Musica musica2 = new Musica(queen);
musica2.Nome = "Nine Out of Ten";
musica2.Duracao = 345;

AlbumDoQueen.AdicionarMusica(musica1);
AlbumDoQueen.AdicionarMusica(musica2);

AlbumDoQueen.ExibaMusicasDoAlbum();



