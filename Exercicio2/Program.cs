// Semana 1 Exercício 2:

int area, Base, altura;

Console.WriteLine("Quer saber a área de um triângulo?");

Console.WriteLine("Informe a base do triângulo:");
Base = int.Parse(Console.ReadLine() );

Console.WriteLine("Informe a altura do triângulo:");
altura = int.Parse(Console.ReadLine());

area =((Base * altura) /2 );

Console.WriteLine($"A área do seu triângulo é: {area}.");

//Finalizado