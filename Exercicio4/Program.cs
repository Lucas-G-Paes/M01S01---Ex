//Semana 1 Exercício 4:

float salario, imposto;

Console.WriteLine("Para que possamos calcular o seu imposto, informe seu salário:");
salario = float.Parse(Console.ReadLine());

if(salario <= 900){
    Console.WriteLine("Você está isento do imposto.");
    }
    else if(salario > 900 && salario <= 1500){
        imposto = salario / 100 * 5;
        Console.WriteLine($"Você deve pagar R$ {imposto}.");
        }
        else if(salario > 1500 && salario <= 2500){
            imposto = salario / 100 * 10;
            Console.WriteLine($"Você deve pagar R$ {imposto}.");
            }
            else if(salario > 2500){
                imposto = salario / 100 * 20;
                Console.WriteLine($"Você deve pagar R$ {imposto}.");
                }

//Finalizado

