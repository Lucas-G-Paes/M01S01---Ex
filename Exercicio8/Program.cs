// Semana 1 Exercício 8


int repeticoes;
int x = 1, y = 0, z = 0;
Console.WriteLine("Digite o número de vezes que a sequência de Fibonacci mostrará:");
repeticoes = int.Parse(Console.ReadLine());

for (int i = 0; i < repeticoes; i++){
z = x + y;
Console.WriteLine($"{i +1}°: {z}");
y = x;
x = z;
}

//Finalizado

