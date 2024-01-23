int numeroTeste;
int divisoresTeste = 0;

Console.WriteLine("Informe o número a ser testado: ");
numeroTeste = Convert.ToInt32(Console.ReadLine());

for (int i=1; i<=numeroTeste; i++)
{
    if (numeroTeste % i == 0)
        divisoresTeste++;
}

if (divisoresTeste == 2)
    Console.WriteLine("É número primo.");
else
    Console.WriteLine("É número par.");

Console.ReadKey();