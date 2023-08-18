Album AlbumDoCaetano = new Album();
AlbumDoCaetano.Nome = "Transa";

Musica musica1 = new Musica();
musica1.Nome = "You Don't Know Me";
musica1.Duracao = 250;



Musica musica2 = new Musica();
musica2.Nome = "Nine Out of Ten";
musica2.Duracao = 345;

AlbumDoCaetano.AdicionarMusica(musica1);
AlbumDoCaetano.AdicionarMusica(musica2);

Banda caetano = new Banda();
caetano.Nome = "Caetano Veloso";
caetano.AdicionarAlbum(AlbumDoCaetano);
caetano.ExibirDiscografia();