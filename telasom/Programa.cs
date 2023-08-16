Album AlbumDoCaetano = new Album();
AlbumDoCaetano.Nome = "Transa";

Musica musica1 = new Musica();
musica1.Nome = "You Don't Know Me";



Musica musica2 = new Musica();
musica2.Nome = "Nine Out of Ten";

AlbumDoCaetano.AdicionarMusica(musica1);
AlbumDoCaetano.AdicionarMusica(musica2);

AlbumDoCaetano.ExibaMusicasDoAlbum();
