int numeroTeste;

Console.WriteLine("Informe o número a ser testado: ");
numeroTeste = Convert.ToInt32(Console.ReadLine());

if (numeroTeste % 2 == 0)
    Console.WriteLine("É número par.");
else
    Console.WriteLine("É número impar.");

Console.ReadKey();
