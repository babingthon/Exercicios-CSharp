Console.WriteLine("Vamos realizar a soma dos números impares multiplos de 3 entre 1 e 500");

int SomaDosNumetos = 0;

for (int i = 1; i <= 500; i++ )
{
    if (i % 2 == 1)
    {
        if (i % 3 == 0)
        {
            SomaDosNumetos = SomaDosNumetos + i;        
        }
    }
}

Console.WriteLine("Soma foi de: " + SomaDosNumetos);


