Musica musica1 = new Musica();
musica1.Nome = "Divino Maravilhoso";
musica1.Artista = "Gal Costa";
musica1.Duracao = 273;
musica1.Disponivel = true;

Console.WriteLine(musica1.Disponivel);


Musica musica2 = new Musica();
musica2.Nome = "Azul";
musica2.Artista = "Chico Buarque";
musica2.Duracao = 373;
musica2.Disponivel = false;

Console.WriteLine(musica2.Disponivel);



musica1.ExibirFichaTecnica();

musica2.ExibirFichaTecnica();