//Semana 1 Exercício 1:

String nome, sobrenome, color;
int idade;

Console.WriteLine("Qual o Seu nome?");
nome = Console.ReadLine();

Console.WriteLine($"Qual o seu sobrenome {nome}?");
sobrenome = Console.ReadLine();

Console.WriteLine($"Qual a sua idade {nome}?");
idade = int.Parse( Console.ReadLine() );

Console.WriteLine($"Qual a sua cor favorita {nome}");
color = Console.ReadLine();

Console.WriteLine($"Seu nome é: {nome} {sobrenome}.");
Console.WriteLine($"Sua idade é: {idade}.");
Console.WriteLine($"Sua cor favorita é: {color}.");

//Finalizado