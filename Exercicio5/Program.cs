//Semana 1 Exercício 5:

int a, b, c;

Console.WriteLine("Forme um triângulo informando seus 3 lados");

Console.WriteLine("Insira o 1º lado do triângulo");
a = int.Parse(Console.ReadLine() );

Console.WriteLine("Insira o 2º lado do triângulo");
b = int.Parse( Console.ReadLine() );

Console.WriteLine("Insira o 3º lado do triângulo");
c = int.Parse( Console.ReadLine() );


if(a < b + c && b < a + c && c < a + b)
    {
        Console.WriteLine("Os valores formam um triângulo.");
        }
        else Console.WriteLine($"Os valores não formam um triângulo.");

    if(a < b + c && b < a + c && c < a + b)
        {
        if(a == b && b == c)
            {
                Console.WriteLine($"Você possui um triângulo equilátero.");
            }
                else if(a == b || b == c || a == c)
                    {   
                        Console.WriteLine($"Você possui um triângulo isósceles.");
                    }
                        else Console.WriteLine($"Você possui um triângulo escaleno.");
                    
        }







            



    



