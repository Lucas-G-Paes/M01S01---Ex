// Semana 1 Exercício 3:

float media, nota1, nota2, nota3;

Console.WriteLine("Insira sua 1ª nota:");
nota1 = float.Parse(Console.ReadLine() );

Console.WriteLine("Insira sua 2ª nota:");
nota2 = float.Parse(Console.ReadLine() );

Console.WriteLine("Insira sua 3ª nota:");
nota3 = float.Parse(Console.ReadLine() );

media = ((nota1 + nota2 + nota3) /3 );

if(media >= 6){
    Console.WriteLine($"Parabéns você foi aprovado. Sua média foi: {media}.");
    }
    else if(media < 5){
        Console.WriteLine($"Infelizmente você não atingiu a nota necessária. Sua média foi {media}.");
        }
        else { Console.WriteLine($"Você ficou em recuperação. Sua média foi {media}.");}
    
//Finalizado
