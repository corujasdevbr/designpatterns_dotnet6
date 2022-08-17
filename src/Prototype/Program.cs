// See https://aka.ms/new-console-template for more information
using Prototype;

Console.WriteLine("Prototype");

Jogador jogador = new Jogador();
jogador.Nome = "Fernando Henrique";
jogador.Posicao = "Goleiro";
jogador.Chuteira = new Chuteira { Nome = "Chuteira X Speedportal.4 Fxg Adidas", Numero = 42 };

//clone1 do objeto original
Jogador jogador_clone1 = (Jogador)jogador.Clone(true);
jogador_clone1.Nome = "Jogador clone1";
jogador_clone1.Posicao = "Atacante";
jogador_clone1.Chuteira.Nome = "Chuteira Campo Oxn Velox 2 Preto/Azul";

//clone2 do objeto original
Jogador jogador_clone2 = (Jogador)jogador.Clone();
jogador_clone2.Nome = "Jogador clone2";
jogador_clone2.Posicao = "Meio Campo";
jogador_clone2.Chuteira.Nome = "Chuteira Oxn Express Fit Society";
jogador_clone2.Chuteira.Numero = 43;

//exibe valores do objeto original
Console.WriteLine(">> Objeto Original");
Console.WriteLine(jogador.ToString());

//clone1
Console.WriteLine(">> Objeto Clone1");
Console.WriteLine(jogador_clone1.ToString());

//clone2
Console.WriteLine(">> Objeto Clone2");
Console.WriteLine(jogador_clone2.ToString());

Console.ReadLine();
