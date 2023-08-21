Epsodio ep1 = new(1, "Técnicas de facilitação", 45);
ep1.AdicionarCovidados("Dayse Guedes");
ep1.AdicionarCovidados("Felipe");


Epsodio ep2 = new(2, "Técnicasde Aprendizado", 65);
ep2.AdicionarCovidados("Maria Guedes");
ep2.AdicionarCovidados("Carlos");
ep2.AdicionarCovidados("Bia");

Podcast podcast = new("Podcast Especial", Carla);
podcast.AdicionarEpsodio(ep1);
podcast.AdicionarEpsodio(ep2);

ExibirDetalhesDoPodcast();




