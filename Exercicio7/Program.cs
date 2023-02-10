// Semana 1 Exercício 7

int u;
Console.WriteLine("Qual a Quantidade de Alunos deseja adicionar?");
u = int.Parse(Console.ReadLine());

float [] nota1 = new float[u];
float [] nota2 = new float[u];
float [] nota3 = new float[u];
float [] notamedia = new float[u];
string [] nomes = new string[u];


for(int i = 0; i < u; i++){
Console.WriteLine($"Digite o {i+1}° nome:");
nomes[i] = Console.ReadLine();

Console.WriteLine($"Digite a 1ª nota:");
nota1[i] = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a 2ª nota:");
nota2[i] = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a 3ª nota:");
nota3[i] = float.Parse(Console.ReadLine());

}

for(int i = 0; i < u; i++){
    notamedia[i] = ((nota1[i] + nota2[i] + nota3[i])/3); 
    
    if(notamedia[i] >= 6){
        Console.WriteLine($"nome {i+1}: {nomes[i]}");
        Console.WriteLine($"Nota 1: {nota1[i]}");
        Console.WriteLine($"Nota 2: {nota2[i]}");
        Console.WriteLine($"Nota 3: {nota3[i]}");
        Console.WriteLine($"Média do {nomes[i]}: {notamedia[i]}");
        Console.WriteLine($"Parabéns você foi aprovado.");
        }

        else if(notamedia[i] < 5){
            Console.WriteLine($"nome {i+1}: {nomes[i]}");
            Console.WriteLine($"Nota 1: {nota1[i]}");
            Console.WriteLine($"Nota 2: {nota2[i]}");
            Console.WriteLine($"Nota 3: {nota3[i]}");
            Console.WriteLine($"Média do {nomes}: {notamedia[i]}");
            Console.WriteLine($"Você foi reprovado.");
            }

            else{
                Console.WriteLine($"nome {i+1}: {nomes[i]}");
                Console.WriteLine($"Nota 1: {nota1[i]}");
                Console.WriteLine($"Nota 2: {nota2[i]}");
                Console.WriteLine($"Nota 3: {nota3[i]}");
                Console.WriteLine($"Média do {nomes}: {notamedia[i]}");
                Console.WriteLine($"Você ficou em recuperação.");
                }
                }
//Finalizado
