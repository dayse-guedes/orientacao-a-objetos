Musica musica1 = new Musica();
musica1.nome = "Divino Maravilhoso";
musica1.artista = "Gal Costa";
musica1.duracao = 273;
musica1.Disponivel = true;

Console.WriteLine(musica1.Disponivel);


Musica musica2 = new Musica();
musica2.nome = "Azul";
musica2.artista = "Chico Buarque";
musica2.duracao = 373;
musica2.Disponivel = false;

Console.WriteLine(musica2.Disponivel);



musica1.ExibirFichaTecnica();

musica2.ExibirFichaTecnica();