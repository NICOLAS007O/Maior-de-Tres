
Console.Clear();

double numero1 = 0;
double numero2 = 0;
double numero3 = 0;

Console.WriteLine("--- Exercicio Maior de Tres ---");

Console.Write("Digite o primeiro valor: ");
numero1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o segundo valor: ");
numero2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o terceiro valor: ");
numero3 = Convert.ToDouble(Console.ReadLine());


if (numero1 > numero2 && numero1 > numero3)
{
    Console.WriteLine();
    Console.WriteLine($"Esse é o maior numero: {numero1}");
}

else if (numero2 > numero1 && numero2 > numero3)
{
    Console.WriteLine();
    Console.WriteLine($"Esse é o maior numero: {numero2}");
}
else 
{
    Console.WriteLine();
    Console.WriteLine($"Esse é o maior numero: {numero3}");
}