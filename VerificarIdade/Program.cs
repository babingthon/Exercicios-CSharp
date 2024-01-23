int idade;

Console.WriteLine("Informe a idade do usuário.");

idade = Convert.ToInt32(Console.ReadLine());

if (idade >= 18)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Permissão Concedida");
}
else
{
    Console.ForegroundColor= ConsoleColor.Red;
    Console.WriteLine("Sem Permissão");
}

Console.ForegroundColor = ConsoleColor.White;
Console.ReadKey();