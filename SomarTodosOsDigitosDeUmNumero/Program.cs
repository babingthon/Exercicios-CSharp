using System.ComponentModel.Design;

Console.WriteLine("Digite o número desejado: ");
int numeroCalculo = Convert.ToInt32(Console.ReadLine());

int soma = SomarDigitos(numeroCalculo);
Console.WriteLine("A soma do número " + numeroCalculo + " é: " + soma);

int SomarDigitos(int numero)
{
    int soma = 0;

    while (numero > 0)
    {
        soma += numero % 10;
        numero /= 10;
    }
    return soma;
}

